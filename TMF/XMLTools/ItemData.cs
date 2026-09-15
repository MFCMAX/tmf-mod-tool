using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TMF.Enums;

namespace TMF.XMLTools
{
	// Token: 0x02000048 RID: 72
	[XmlRoot("ItemDataXML")]
	public class ItemData
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00012430 File Offset: 0x00010630
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00012438 File Offset: 0x00010638
		[XmlArray("ArrayOfItemDataXML")]
		public ItemDataXML[] ArrayOfItemDataXML { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00012441 File Offset: 0x00010641
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00012449 File Offset: 0x00010649
		[XmlIgnore]
		public Dictionary<string, int> ItemIDIndexes { get; set; }

		// Token: 0x0600028D RID: 653 RVA: 0x00012454 File Offset: 0x00010654
		public static ItemData ReadItemData(string itemdataxmlpath, string itemidindexespath)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ItemData));
			FileStream stream = new FileStream(itemdataxmlpath, FileMode.Open, FileAccess.Read, FileShare.Read);
			ItemData itemData = (ItemData)xmlSerializer.Deserialize(stream);
			Stream itemidindexesstream = File.Open(itemidindexespath, FileMode.Open);
			itemData.ReadItemIDIndexes(itemidindexesstream);
			return itemData;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00012498 File Offset: 0x00010698
		public int GetImageIndexFromItemID(string itemID)
		{
			foreach (KeyValuePair<string, int> keyValuePair in this.ItemIDIndexes)
			{
				if (keyValuePair.Key == itemID)
				{
					return keyValuePair.Value + 1;
				}
			}
			return 0;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00012504 File Offset: 0x00010704
		private void ReadItemIDIndexes(Stream itemidindexesstream)
		{
			StreamReader streamReader = new StreamReader(itemidindexesstream);
			this.ItemIDIndexes = new Dictionary<string, int>();
			while (!streamReader.EndOfStream)
			{
				string text = streamReader.ReadLine();
				if (!text.StartsWith("#") && text != null && !(text == ""))
				{
					string[] array = text.Split(new char[]
					{
						':'
					});
					this.ItemIDIndexes.Add(array[0], int.Parse(array[1]));
				}
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001257B File Offset: 0x0001077B
		public ItemType GetItemType(Item itemID)
		{
			return this.ArrayOfItemDataXML[(int)itemID].ItemType;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001258A File Offset: 0x0001078A
		public ushort GetItemDurability(Item itemID)
		{
			return this.ArrayOfItemDataXML[(int)itemID].Durability;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00012599 File Offset: 0x00010799
		public int GetStackSize(Item itemID)
		{
			if (this.GetItemDurability(itemID) == 0)
			{
				return this.ArrayOfItemDataXML[(int)itemID].StackSize;
			}
			return 1;
		}
	}
}
