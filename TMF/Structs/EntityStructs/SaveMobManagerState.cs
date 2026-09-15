using System;
using System.Collections.Generic;
using System.IO;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000046 RID: 70
	public class SaveMobManagerState
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00012352 File Offset: 0x00010552
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0001235A File Offset: 0x0001055A
		public List<SaveSpiderState> Spiders { get; set; }

		// Token: 0x06000285 RID: 645 RVA: 0x00012364 File Offset: 0x00010564
		public static SaveMobManagerState ReadState(BinaryReader reader)
		{
			SaveMobManagerState saveMobManagerState = new SaveMobManagerState();
			int num = reader.ReadInt32();
			saveMobManagerState.Spiders = new List<SaveSpiderState>();
			for (int i = 0; i < num; i++)
			{
				saveMobManagerState.Spiders.Add(SaveMobManagerState.ReadSpiderData(reader));
			}
			return saveMobManagerState;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000123A8 File Offset: 0x000105A8
		private static SaveSpiderState ReadSpiderData(BinaryReader reader)
		{
			SaveSpiderState saveSpiderState = new SaveSpiderState();
			saveSpiderState.ReadBaseState(reader);
			return saveSpiderState;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000123C4 File Offset: 0x000105C4
		public void WriteMobState(BinaryWriter writer)
		{
			writer.Write(this.Spiders.Count);
			foreach (SaveSpiderState saveSpiderState in this.Spiders)
			{
				saveSpiderState.WriteBaseState(writer);
			}
		}
	}
}
