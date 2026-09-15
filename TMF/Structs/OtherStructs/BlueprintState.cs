using System;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x0200002F RID: 47
	public class BlueprintState
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00011390 File Offset: 0x0000F590
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00011398 File Offset: 0x0000F598
		public bool IsEnabled { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000113A1 File Offset: 0x0000F5A1
		// (set) Token: 0x06000206 RID: 518 RVA: 0x000113A9 File Offset: 0x0000F5A9
		public bool IsUnearthed { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000113B2 File Offset: 0x0000F5B2
		// (set) Token: 0x06000208 RID: 520 RVA: 0x000113BA File Offset: 0x0000F5BA
		public bool IsGenerated { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000209 RID: 521 RVA: 0x000113C3 File Offset: 0x0000F5C3
		// (set) Token: 0x0600020A RID: 522 RVA: 0x000113CB File Offset: 0x0000F5CB
		public GlobalPoint3D Point { get; set; }

		// Token: 0x0600020B RID: 523 RVA: 0x000113D4 File Offset: 0x0000F5D4
		public BlueprintState()
		{
			this.Point = new GlobalPoint3D();
		}
	}
}
