using System;
using System.Collections.Generic;
using System.IO;
using TMF.Structs.EntityStructs;
using TMF.Utils;

namespace TMF.FileTypes
{
	// Token: 0x02000015 RID: 21
	public class GamertagDataDb
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600011C RID: 284 RVA: 0x0000FB6F File Offset: 0x0000DD6F
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000FB77 File Offset: 0x0000DD77
		public int Version { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000FB80 File Offset: 0x0000DD80
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000FB88 File Offset: 0x0000DD88
		public List<GamertagData> Gamertags { get; set; }

		// Token: 0x06000120 RID: 288 RVA: 0x0000FB91 File Offset: 0x0000DD91
		public GamertagDataDb()
		{
			this.Gamertags = new List<GamertagData>();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000FBA4 File Offset: 0x0000DDA4
		public static GamertagDataDb ReadGamertagData(Stream xIn)
		{
			GamertagDataDb gamertagDataDb = new GamertagDataDb();
			BinaryReader binaryReader = new BinaryReader(xIn);
			gamertagDataDb.Version = binaryReader.ReadInt32();
			int num = binaryReader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				gamertagDataDb.Gamertags.Add(GamertagData.ReadGamertagData(binaryReader));
			}
			return gamertagDataDb;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		public void WriteData(Stream xOut)
		{
			BinaryWriter binaryWriter = new BinaryWriter(xOut);
			binaryWriter.Write(this.Version);
			binaryWriter.Write(this.Gamertags.Count);
			for (int i = 0; i < this.Gamertags.Count; i++)
			{
				this.Gamertags[i].WriteGamertagData(binaryWriter);
			}
			Encryption.WriteHashToStream(xOut);
		}
	}
}
