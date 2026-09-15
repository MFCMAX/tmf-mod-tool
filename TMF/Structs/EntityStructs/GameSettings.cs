using System;
using TMF.Enums;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200002D RID: 45
	public class GameSettings
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001122A File Offset: 0x0000F42A
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00011232 File Offset: 0x0000F432
		public AutoSaveSetting AutoSave { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001123B File Offset: 0x0000F43B
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00011243 File Offset: 0x0000F443
		public ShaderDetail ShaderDetail { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001124C File Offset: 0x0000F44C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00011254 File Offset: 0x0000F454
		public float SoundVolume { get; set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0001125D File Offset: 0x0000F45D
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00011265 File Offset: 0x0000F465
		public float MusicVolume { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0001126E File Offset: 0x0000F46E
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00011276 File Offset: 0x0000F476
		public bool ViewClouds { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0001127F File Offset: 0x0000F47F
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00011287 File Offset: 0x0000F487
		public bool UseMipMaps { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00011290 File Offset: 0x0000F490
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00011298 File Offset: 0x0000F498
		public bool OldSkoolLight { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000112A1 File Offset: 0x0000F4A1
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000112A9 File Offset: 0x0000F4A9
		public NotificationType Notifications { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000112B2 File Offset: 0x0000F4B2
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x000112BA File Offset: 0x0000F4BA
		public bool SplitScreenVertical { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000112C3 File Offset: 0x0000F4C3
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000112CB File Offset: 0x0000F4CB
		public float TextureSmoothing { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000112D4 File Offset: 0x0000F4D4
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000112DC File Offset: 0x0000F4DC
		public float ViewDistance { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000112E5 File Offset: 0x0000F4E5
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000112ED File Offset: 0x0000F4ED
		public string TexturePack { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000112F6 File Offset: 0x0000F4F6
		// (set) Token: 0x060001FC RID: 508 RVA: 0x000112FE File Offset: 0x0000F4FE
		public string WindowBorder { get; set; }
	}
}
