using System;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200002B RID: 43
	public struct SaveInventoryItem
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000105E4 File Offset: 0x0000E7E4
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000105EC File Offset: 0x0000E7EC
		public ushort SlotID { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000105F5 File Offset: 0x0000E7F5
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000105FD File Offset: 0x0000E7FD
		public ushort ItemID { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00010606 File Offset: 0x0000E806
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0001060E File Offset: 0x0000E80E
		public int Count { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00010617 File Offset: 0x0000E817
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0001061F File Offset: 0x0000E81F
		public ushort Durability { get; set; }
	}
}
