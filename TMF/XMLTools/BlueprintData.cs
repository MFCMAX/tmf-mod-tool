using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TMF.Enums;
using TMF.Structs.EntityStructs;
using TMF.Structs.OtherStructs;
using TMF.Utils;

namespace TMF.XMLTools
{
	// Token: 0x02000059 RID: 89
	[XmlRoot("BlueprintData")]
	public class BlueprintData
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600036B RID: 875 RVA: 0x000149CA File Offset: 0x00012BCA
		// (set) Token: 0x0600036C RID: 876 RVA: 0x000149D2 File Offset: 0x00012BD2
		[XmlArray("ArrayOfBlueprintXML")]
		public BlueprintXML[] ArrayOfBlueprintXML { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600036D RID: 877 RVA: 0x000149DB File Offset: 0x00012BDB
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000149E3 File Offset: 0x00012BE3
		[XmlIgnore]
		public Blueprint[] BlueprintList { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000149EC File Offset: 0x00012BEC
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000149F4 File Offset: 0x00012BF4
		[XmlIgnore]
		public Dictionary<int, string> BlueprintIndexes { get; set; }

		// Token: 0x06000371 RID: 881 RVA: 0x00014A00 File Offset: 0x00012C00
		public static BlueprintData ReadBlueprintData(string blueprintpath, string blueprintidspath)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(BlueprintData));
			FileStream stream = new FileStream(blueprintpath, FileMode.Open, FileAccess.Read, FileShare.Read);
			BlueprintData blueprintData = (BlueprintData)xmlSerializer.Deserialize(stream);
			blueprintData.InitializeBlueprints();
			blueprintData.ReadBlueprintItemIds(blueprintidspath);
			return blueprintData;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00014A44 File Offset: 0x00012C44
		private void ReadBlueprintItemIds(string blueprintidspath)
		{
			Stream stream = File.Open(blueprintidspath, FileMode.Open);
			StreamReader streamReader = new StreamReader(stream);
			this.BlueprintIndexes = new Dictionary<int, string>();
			while (!streamReader.EndOfStream)
			{
				string text = streamReader.ReadLine();
				if (!text.StartsWith("#") && !(text == "") && text != null)
				{
					string[] array = text.Split(new char[]
					{
						':'
					});
					int key = int.Parse(array[0]);
					this.BlueprintIndexes.Add(key, array[1]);
				}
			}
			stream.Close();
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00014AD0 File Offset: 0x00012CD0
		public byte GetBlueprintIndex(Item itemID)
		{
			for (int i = 0; i < this.BlueprintList.Length; i++)
			{
				if (this.BlueprintList[i].Result.ItemID == (ushort)itemID)
				{
					return (byte)i;
				}
			}
			return byte.MaxValue;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00014B10 File Offset: 0x00012D10
		public string GetBlueprintItemNameFromIndex(int num)
		{
			foreach (KeyValuePair<int, string> keyValuePair in this.BlueprintIndexes)
			{
				if (keyValuePair.Key == num)
				{
					return keyValuePair.Value;
				}
			}
			return "[NULL]";
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00014B78 File Offset: 0x00012D78
		public void InitializeBlueprints()
		{
			List<Blueprint> list = new List<Blueprint>(this.ArrayOfBlueprintXML.Length);
			for (int i = 0; i < this.ArrayOfBlueprintXML.Length; i++)
			{
				if (BlueprintData.IsValidBlueprint(this.ArrayOfBlueprintXML[i].ItemID))
				{
					list.Add(new Blueprint
					{
						Result = new SaveInventoryItem
						{
							ItemID = (ushort)this.ArrayOfBlueprintXML[i].Result.ItemID,
							Count = this.ArrayOfBlueprintXML[i].Result.Count,
							Durability = this.ArrayOfBlueprintXML[i].Result.Durability
						},
						SortID = this.ArrayOfBlueprintXML[i].SortID
					});
				}
			}
			this.BlueprintList = list.ToArray();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00014C46 File Offset: 0x00012E46
		public static bool IsValidBlueprint(Item itemID)
		{
			return itemID != Item.Sundial && itemID != Item.SledgeHammer && itemID != Item.GreenstoneGoldSledgeHammer && Globals.ItemData.ArrayOfItemDataXML[(int)itemID].IsValid;
		}
	}
}
