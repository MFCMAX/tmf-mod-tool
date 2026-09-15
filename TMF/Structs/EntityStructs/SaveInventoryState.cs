using System;
using System.Collections.Generic;
using System.IO;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200001F RID: 31
	public class SaveInventoryState
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000FEF1 File Offset: 0x0000E0F1
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000FEF9 File Offset: 0x0000E0F9
		public short PackSize { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000FF02 File Offset: 0x0000E102
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000FF0A File Offset: 0x0000E10A
		public short EquipSize { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000FF13 File Offset: 0x0000E113
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000FF1B File Offset: 0x0000E11B
		public short TempSize { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000FF24 File Offset: 0x0000E124
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000FF2C File Offset: 0x0000E12C
		public ushort HotBarLeftID { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000FF35 File Offset: 0x0000E135
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000FF3D File Offset: 0x0000E13D
		public ushort HotBarRightID { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000FF46 File Offset: 0x0000E146
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000FF4E File Offset: 0x0000E14E
		public bool AllowZeroCountItems { get; set; }

		// Token: 0x06000157 RID: 343 RVA: 0x0000FF58 File Offset: 0x0000E158
		public void Write(BinaryWriter writer)
		{
			writer.Write(this.PackSize);
			writer.Write(this.EquipSize);
			writer.Write(this.TempSize);
			writer.Write(this.HotBarLeftID);
			writer.Write(this.HotBarRightID);
			writer.Write(this.Items.Count);
			writer.Write(this.AllowZeroCountItems);
			writer.Write(0);
			writer.Write(0);
			for (int i = 0; i < this.Items.Count; i++)
			{
				writer.Write(this.Items[i].SlotID);
				writer.Write(this.Items[i].ItemID);
				writer.Write(this.Items[i].Count);
				writer.Write(this.Items[i].Durability);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0001004C File Offset: 0x0000E24C
		public static SaveInventoryState ReadInventory(BinaryReader reader)
		{
			SaveInventoryState saveInventoryState = new SaveInventoryState();
			saveInventoryState.PackSize = reader.ReadInt16();
			saveInventoryState.EquipSize = reader.ReadInt16();
			saveInventoryState.TempSize = reader.ReadInt16();
			saveInventoryState.HotBarLeftID = reader.ReadUInt16();
			saveInventoryState.HotBarRightID = reader.ReadUInt16();
			int num = reader.ReadInt32();
			saveInventoryState.AllowZeroCountItems = reader.ReadBoolean();
			reader.ReadInt16();
			reader.ReadInt16();
			saveInventoryState.Items = new List<SaveInventoryItem>();
			for (int i = 0; i < num; i++)
			{
				SaveInventoryItem item = default(SaveInventoryItem);
				item.SlotID = reader.ReadUInt16();
				item.ItemID = reader.ReadUInt16();
				item.Count = reader.ReadInt32();
				item.Durability = reader.ReadUInt16();
				if (item.ItemID != 0)
				{
					saveInventoryState.Items.Add(item);
				}
			}
			return saveInventoryState;
		}

		// Token: 0x04000167 RID: 359
		public List<SaveInventoryItem> Items;
	}
}
