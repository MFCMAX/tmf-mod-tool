using System;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000035 RID: 53
	public class SaveTeleportState
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000119E0 File Offset: 0x0000FBE0
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000119E8 File Offset: 0x0000FBE8
		public GlobalPoint3D Point { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000119F1 File Offset: 0x0000FBF1
		// (set) Token: 0x06000223 RID: 547 RVA: 0x000119F9 File Offset: 0x0000FBF9
		public byte Channel { get; set; }
	}
}
