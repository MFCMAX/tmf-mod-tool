using System;
using System.IO;
using TMF.Enums;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000007 RID: 7
	public class CharacterSkilldata
	{
		// Token: 0x17000017 RID: 23
		public SkillData this[int i]
		{
			get
			{
				return this.skilldata[i];
			}
			set
			{
				this.skilldata[i] = value;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002204 File Offset: 0x00000404
		public CharacterSkilldata()
		{
			this.skilldata = new SkillData[16];
			for (int i = 0; i < this.skilldata.Length; i++)
			{
				this.skilldata[i] = new SkillData();
				this.skilldata[i].SkillType = (SkillType)i;
				this.skilldata[i].CurrentXP = 0.0;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000226C File Offset: 0x0000046C
		public static CharacterSkilldata ReadCharacterSkillData(BinaryReader reader)
		{
			CharacterSkilldata characterSkilldata = new CharacterSkilldata();
			int num = (int)reader.ReadByte();
			for (int i = 0; i < num; i++)
			{
				SkillData skillData = characterSkilldata[i];
				double currentXP = reader.ReadDouble();
				skillData.CurrentXP = currentXP;
				skillData.Level = SkillData.GetLevelForXP(skillData.CurrentXP);
				skillData.nextLevelXP = (double)SkillData.GetXPForLevel(skillData.Level + 1);
				characterSkilldata[i] = skillData;
			}
			return characterSkilldata;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022D8 File Offset: 0x000004D8
		public void WriteState(BinaryWriter writer)
		{
			int num = this.skilldata.Length;
			writer.Write((byte)num);
			for (int i = 0; i < num; i++)
			{
				writer.Write(this[i].CurrentXP);
			}
		}

		// Token: 0x04000017 RID: 23
		public SkillData[] skilldata;
	}
}
