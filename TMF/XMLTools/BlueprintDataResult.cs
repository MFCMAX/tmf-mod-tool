using System;
using TMF.Enums;

namespace TMF.XMLTools
{
	// Token: 0x0200005B RID: 91
	public class BlueprintDataResult
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00014CC7 File Offset: 0x00012EC7
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00014CCF File Offset: 0x00012ECF
		public Item ItemID { get; set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00014CD8 File Offset: 0x00012ED8
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00014CE0 File Offset: 0x00012EE0
		public ushort Durability { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00014CE9 File Offset: 0x00012EE9
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00014CF1 File Offset: 0x00012EF1
		public int Count { get; set; }
	}
}
