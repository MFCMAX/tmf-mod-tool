using System;
using TMF.Enums;

namespace TMF.XMLTools
{
	// Token: 0x0200005E RID: 94
	public class SkillDataXML
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0001529D File Offset: 0x0001349D
		// (set) Token: 0x06000397 RID: 919 RVA: 0x000152A5 File Offset: 0x000134A5
		public Item ItemID { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000152AE File Offset: 0x000134AE
		// (set) Token: 0x06000399 RID: 921 RVA: 0x000152B6 File Offset: 0x000134B6
		public int MinReq { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000152BF File Offset: 0x000134BF
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000152C7 File Offset: 0x000134C7
		public int UseReq { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600039C RID: 924 RVA: 0x000152D0 File Offset: 0x000134D0
		// (set) Token: 0x0600039D RID: 925 RVA: 0x000152D8 File Offset: 0x000134D8
		public string UseSkill { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000152E1 File Offset: 0x000134E1
		// (set) Token: 0x0600039F RID: 927 RVA: 0x000152E9 File Offset: 0x000134E9
		public int CraftReq { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000152F2 File Offset: 0x000134F2
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000152FA File Offset: 0x000134FA
		public string CraftSkill { get; set; }
	}
}
