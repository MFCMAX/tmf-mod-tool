using System;
using TMF.Enums;

namespace TMF.Structs.MapStructs
{
	// Token: 0x02000052 RID: 82
	public class MapMarker
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001451B File Offset: 0x0001271B
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00014523 File Offset: 0x00012723
		public GlobalPoint3D Point { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001452C File Offset: 0x0001272C
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00014534 File Offset: 0x00012734
		public string Label { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001453D File Offset: 0x0001273D
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00014545 File Offset: 0x00012745
		public MapMarkerType Type { get; set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001454E File Offset: 0x0001274E
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00014556 File Offset: 0x00012756
		public float Time { get; set; }
	}
}
