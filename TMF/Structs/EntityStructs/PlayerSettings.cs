using System;
using TMF.Enums;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000045 RID: 69
	public class PlayerSettings
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0001223A File Offset: 0x0001043A
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00012242 File Offset: 0x00010442
		public float GamePadSensitivity { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0001224B File Offset: 0x0001044B
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00012253 File Offset: 0x00010453
		public float FOVNormalized { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0001225C File Offset: 0x0001045C
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00012264 File Offset: 0x00010464
		public bool HudVisible { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0001226D File Offset: 0x0001046D
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00012275 File Offset: 0x00010475
		public bool CompassTop { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0001227E File Offset: 0x0001047E
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00012286 File Offset: 0x00010486
		public bool MapVisible { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0001228F File Offset: 0x0001048F
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00012297 File Offset: 0x00010497
		public bool RumbleOn { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000122A0 File Offset: 0x000104A0
		// (set) Token: 0x0600026F RID: 623 RVA: 0x000122A8 File Offset: 0x000104A8
		public bool DisplayXPGains { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000122B1 File Offset: 0x000104B1
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000122B9 File Offset: 0x000104B9
		public NamePlateSetting NamePlateSetting { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000122C2 File Offset: 0x000104C2
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000122CA File Offset: 0x000104CA
		public bool MobNameplates { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000122D3 File Offset: 0x000104D3
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000122DB File Offset: 0x000104DB
		public bool BlueprintFinderVisible { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000122E4 File Offset: 0x000104E4
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000122EC File Offset: 0x000104EC
		public bool InvertY { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000122F5 File Offset: 0x000104F5
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000122FD File Offset: 0x000104FD
		public float AutoplaceTime { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00012306 File Offset: 0x00010506
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0001230E File Offset: 0x0001050E
		public byte HotBarToTransparentTime { get; set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00012317 File Offset: 0x00010517
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0001231F File Offset: 0x0001051F
		public MobType MobType { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00012328 File Offset: 0x00010528
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00012330 File Offset: 0x00010530
		public CameraType CameraType { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00012339 File Offset: 0x00010539
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00012341 File Offset: 0x00010541
		public UserControlSetting UserControlSetting { get; set; }
	}
}
