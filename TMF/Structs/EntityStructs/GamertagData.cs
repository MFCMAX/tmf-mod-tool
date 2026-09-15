using System;
using System.Collections.Generic;
using System.IO;
using TMF.Structs.OtherStructs;
using TMF.Utils;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000042 RID: 66
	public class GamertagData
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00011FA2 File Offset: 0x000101A2
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00011FAA File Offset: 0x000101AA
		public string Gamertag { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00011FB3 File Offset: 0x000101B3
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00011FBB File Offset: 0x000101BB
		public PlayerUnlockData UnlockData { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00011FC4 File Offset: 0x000101C4
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00011FCC File Offset: 0x000101CC
		public CharacterSkilldata SkillData { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00011FD5 File Offset: 0x000101D5
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00011FDD File Offset: 0x000101DD
		public List<ServerEntry> ServerData { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00011FE6 File Offset: 0x000101E6
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00011FEE File Offset: 0x000101EE
		public GlobalGamerSettings Settings { get; set; }

		// Token: 0x06000259 RID: 601 RVA: 0x00011FF8 File Offset: 0x000101F8
		public static GamertagData ReadGamertagData(BinaryReader reader)
		{
			GamertagData gamertagData = new GamertagData();
			gamertagData.Gamertag = ReadingUtils.ReadGamertag(reader);
			gamertagData.UnlockData = PlayerUnlockData.ReadPlayerUnlockData(reader);
			gamertagData.SkillData = CharacterSkilldata.ReadCharacterSkillData(reader);
			gamertagData.ServerData = new List<ServerEntry>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				gamertagData.ServerData.Add(ServerEntry.ReadServerEntry(reader));
			}
			gamertagData.Settings = GlobalGamerSettings.ReadSettings(reader);
			return gamertagData;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001206C File Offset: 0x0001026C
		public void WriteGamertagData(BinaryWriter writer)
		{
			ReadingUtils.WriteGamertag(writer, this.Gamertag);
			this.UnlockData.WriteUnlockState(writer);
			this.SkillData.WriteState(writer);
			writer.Write(this.ServerData.Count);
			for (int i = 0; i < this.ServerData.Count; i++)
			{
				this.ServerData[i].WriteServerEntry(writer);
			}
			this.Settings.WriteData(writer);
		}
	}
}
