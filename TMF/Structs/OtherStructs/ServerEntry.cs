using System;
using System.IO;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x0200001A RID: 26
	public class ServerEntry
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000FC4F File Offset: 0x0000DE4F
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000FC57 File Offset: 0x0000DE57
		public int ID { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000FC60 File Offset: 0x0000DE60
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000FC68 File Offset: 0x0000DE68
		public byte MyRating { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000FC71 File Offset: 0x0000DE71
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000FC79 File Offset: 0x0000DE79
		public bool IsFavourite { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000FC82 File Offset: 0x0000DE82
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000FC8A File Offset: 0x0000DE8A
		public string MapName { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000FC93 File Offset: 0x0000DE93
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000FC9B File Offset: 0x0000DE9B
		public string Desc { get; set; }

		// Token: 0x0600012D RID: 301 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		public static ServerEntry ReadServerEntry(BinaryReader reader)
		{
			return new ServerEntry
			{
				ID = reader.ReadInt32(),
				MyRating = reader.ReadByte(),
				IsFavourite = reader.ReadBoolean(),
				MapName = reader.ReadString(),
				Desc = reader.ReadString()
			};
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000FCF4 File Offset: 0x0000DEF4
		public void WriteServerEntry(BinaryWriter writer)
		{
			writer.Write(this.ID);
			writer.Write(this.MyRating);
			writer.Write(this.IsFavourite);
			writer.Write(this.MapName);
			writer.Write(this.Desc);
		}
	}
}
