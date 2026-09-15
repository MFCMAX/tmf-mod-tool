using System;
using TMF.Enums;

namespace TMF.Structs.MapStructs
{
	// Token: 0x02000040 RID: 64
	public class FloodData
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00011B94 File Offset: 0x0000FD94
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00011B9C File Offset: 0x0000FD9C
		public Block BlockID { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00011BA5 File Offset: 0x0000FDA5
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00011BAD File Offset: 0x0000FDAD
		public UpdateBlockMethod Method { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00011BB6 File Offset: 0x0000FDB6
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00011BBE File Offset: 0x0000FDBE
		public string Gamertag { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00011BC7 File Offset: 0x0000FDC7
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00011BCF File Offset: 0x0000FDCF
		public GlobalPoint3D[] FloodPoints { get; set; }
	}
}
