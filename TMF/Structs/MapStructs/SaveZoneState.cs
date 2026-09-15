using System;
using TMF.Enums;

namespace TMF.Structs.MapStructs
{
	// Token: 0x02000005 RID: 5
	public class SaveZoneState
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020DF File Offset: 0x000002DF
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020E7 File Offset: 0x000002E7
		public string Label { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020F0 File Offset: 0x000002F0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020F8 File Offset: 0x000002F8
		public ZoneType Type { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002101 File Offset: 0x00000301
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002109 File Offset: 0x00000309
		public GlobalPoint3D Min { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002112 File Offset: 0x00000312
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000211A File Offset: 0x0000031A
		public GlobalPoint3D Max { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002123 File Offset: 0x00000323
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000212B File Offset: 0x0000032B
		public string Builder { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002134 File Offset: 0x00000334
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000213C File Offset: 0x0000033C
		public string OnEntryScript { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000214D File Offset: 0x0000034D
		public string OnExitScript { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002156 File Offset: 0x00000356
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000215E File Offset: 0x0000035E
		public short CombatLevelDifference { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002167 File Offset: 0x00000367
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000216F File Offset: 0x0000036F
		public float SpeedMultiplier { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002178 File Offset: 0x00000378
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002180 File Offset: 0x00000380
		public float GravityMultiplier { get; set; }
	}
}
