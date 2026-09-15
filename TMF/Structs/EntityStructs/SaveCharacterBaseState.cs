using System;
using System.IO;
using TMF.Enums;
using TMF.Structs.OtherStructs;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200001D RID: 29
	public class SaveCharacterBaseState
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000FDB9 File Offset: 0x0000DFB9
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000FDC1 File Offset: 0x0000DFC1
		public MobType MobType { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000FDCA File Offset: 0x0000DFCA
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000FDD2 File Offset: 0x0000DFD2
		public Vector3 Position { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000FDDB File Offset: 0x0000DFDB
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000FDE3 File Offset: 0x0000DFE3
		public float Health { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000FDEC File Offset: 0x0000DFEC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		public int Seed { get; set; }

		// Token: 0x06000147 RID: 327 RVA: 0x0000FE00 File Offset: 0x0000E000
		public void ReadBaseState(BinaryReader reader)
		{
			this.MobType = (MobType)reader.ReadByte();
			this.Position = new Vector3
			{
				X = reader.ReadSingle(),
				Y = reader.ReadSingle(),
				Z = reader.ReadSingle()
			};
			this.Health = reader.ReadSingle();
			this.Seed = reader.ReadInt32();
			this.Inventory = SaveInventoryState.ReadInventory(reader);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000FE70 File Offset: 0x0000E070
		public void WriteBaseState(BinaryWriter writer)
		{
			writer.Write((byte)this.MobType);
			writer.Write(this.Position.X);
			writer.Write(this.Position.Y);
			writer.Write(this.Position.Z);
			writer.Write(this.Health);
			writer.Write(this.Seed);
			this.Inventory.Write(writer);
		}

		// Token: 0x04000162 RID: 354
		public SaveInventoryState Inventory;
	}
}
