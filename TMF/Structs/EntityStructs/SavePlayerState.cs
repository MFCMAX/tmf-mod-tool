using System;
using TMF.Enums;
using TMF.Structs.OtherStructs;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000055 RID: 85
	public class SavePlayerState : SaveCharacterState
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000334 RID: 820 RVA: 0x000147F8 File Offset: 0x000129F8
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00014800 File Offset: 0x00012A00
		public string Gamertag { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00014809 File Offset: 0x00012A09
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00014811 File Offset: 0x00012A11
		public bool IsNewPlayer { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001481A File Offset: 0x00012A1A
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00014822 File Offset: 0x00012A22
		public PlayerSettings Settings { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001482B File Offset: 0x00012A2B
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00014833 File Offset: 0x00012A33
		public PlayerStats Stats { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001483C File Offset: 0x00012A3C
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00014844 File Offset: 0x00012A44
		public bool JetPackActive { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001484D File Offset: 0x00012A4D
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00014855 File Offset: 0x00012A55
		public bool CraftInstructionMessageShown { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001485E File Offset: 0x00012A5E
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00014866 File Offset: 0x00012A66
		public bool NewComPackMessageShown { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001486F File Offset: 0x00012A6F
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00014877 File Offset: 0x00012A77
		public bool Message4 { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00014880 File Offset: 0x00012A80
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00014888 File Offset: 0x00012A88
		public byte RatingStars { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00014891 File Offset: 0x00012A91
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00014899 File Offset: 0x00012A99
		public int GoldEarned { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000148A2 File Offset: 0x00012AA2
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000148AA File Offset: 0x00012AAA
		public ushort[] ItemsCrafted { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000148B3 File Offset: 0x00012AB3
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000148BB File Offset: 0x00012ABB
		public ItemAction[] ItemActions { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000148C4 File Offset: 0x00012AC4
		// (set) Token: 0x0600034D RID: 845 RVA: 0x000148CC File Offset: 0x00012ACC
		public int ScrollsFound { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000148D5 File Offset: 0x00012AD5
		// (set) Token: 0x0600034F RID: 847 RVA: 0x000148DD File Offset: 0x00012ADD
		public bool BedRockProspected { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000350 RID: 848 RVA: 0x000148E6 File Offset: 0x00012AE6
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000148EE File Offset: 0x00012AEE
		public int EnemiesKilledBeforeBedRock { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000352 RID: 850 RVA: 0x000148F7 File Offset: 0x00012AF7
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000148FF File Offset: 0x00012AFF
		public PriceList DefaultPriceList { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00014908 File Offset: 0x00012B08
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00014910 File Offset: 0x00012B10
		public int LastTransmitterFrequency { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00014919 File Offset: 0x00012B19
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00014921 File Offset: 0x00012B21
		public GlobalPoint3D WayPoint { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0001492A File Offset: 0x00012B2A
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00014932 File Offset: 0x00012B32
		public History History { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0001493B File Offset: 0x00012B3B
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00014943 File Offset: 0x00012B43
		public ActionLog ActionLog { get; set; }
	}
}
