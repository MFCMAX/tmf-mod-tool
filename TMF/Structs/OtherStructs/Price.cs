using System;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x0200001B RID: 27
	public struct Price
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000FD3A File Offset: 0x0000DF3A
		// (set) Token: 0x06000131 RID: 305 RVA: 0x0000FD42 File Offset: 0x0000DF42
		public int Buy { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000FD4B File Offset: 0x0000DF4B
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000FD53 File Offset: 0x0000DF53
		public int Sell { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000FD64 File Offset: 0x0000DF64
		public int Perc { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000FD6D File Offset: 0x0000DF6D
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000FD75 File Offset: 0x0000DF75
		public bool UsePerc { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000FD7E File Offset: 0x0000DF7E
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000FD86 File Offset: 0x0000DF86
		public bool ForSale { get; set; }
	}
}
