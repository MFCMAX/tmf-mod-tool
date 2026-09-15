using System;
using TMF.Enums;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000053 RID: 83
	public class SkillData
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00014567 File Offset: 0x00012767
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0001456F File Offset: 0x0001276F
		public SkillType SkillType { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00014578 File Offset: 0x00012778
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00014580 File Offset: 0x00012780
		public double CurrentXP { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00014589 File Offset: 0x00012789
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00014591 File Offset: 0x00012791
		public int Level { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0001459A File Offset: 0x0001279A
		// (set) Token: 0x0600030E RID: 782 RVA: 0x000145A2 File Offset: 0x000127A2
		public double nextLevelXP { get; set; }

		// Token: 0x0600030F RID: 783 RVA: 0x000145AC File Offset: 0x000127AC
		public static int GetXPForLevel(int level)
		{
			int i = 1;
			double num = 60.0;
			double num2 = 60.0;
			while (i < level - 1)
			{
				double num3 = num;
				num += num2 * 1.12;
				num2 = num - num3;
				i++;
			}
			return (int)num;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000145F4 File Offset: 0x000127F4
		public static int GetLevelForXP(double xp)
		{
			int num = 1;
			double num2 = 60.0;
			double num3 = 60.0;
			while (xp > num2 && num < 99)
			{
				double num4 = num2;
				num2 += num3 * 1.12;
				num3 = num2 - num4;
				num++;
			}
			return num;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0001463B File Offset: 0x0001283B
		public int GetXP(int level)
		{
			if (this.LevelXP == null)
			{
				this.InitLevelXPArray();
			}
			if (level > 0 && level < this.LevelXP.Length)
			{
				return (int)this.LevelXP[level];
			}
			if (level < 1)
			{
				return 0;
			}
			if (level > 99)
			{
				level = 99;
			}
			return SkillData.GetXPForLevel(level);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00014679 File Offset: 0x00012879
		public void SetNextLevelXP(double xp)
		{
			this.Level = SkillData.GetLevelForXP(xp);
			this.nextLevelXP = (double)SkillData.GetXPForLevel(this.Level + 1);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0001469C File Offset: 0x0001289C
		private void InitLevelXPArray()
		{
			this.LevelXP = new double[101];
			this.LevelXP[1] = 0.0;
			for (int i = 2; i < this.LevelXP.Length; i++)
			{
				this.LevelXP[i] = (double)SkillData.GetXPForLevel(i);
			}
		}

		// Token: 0x040005D2 RID: 1490
		public double[] LevelXP;
	}
}
