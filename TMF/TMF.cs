using System;
using System.IO;
using TMF.FileTypes;

namespace TMF
{
	// Token: 0x02000012 RID: 18
	public class TMF
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000EF93 File Offset: 0x0000D193
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000EF9B File Offset: 0x0000D19B
		public HeaderDAT Header { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		public PlayerDAT PlayerData { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000EFB5 File Offset: 0x0000D1B5
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000EFBD File Offset: 0x0000D1BD
		public GamertagDataDb GamertagData { get; set; }

		// Token: 0x0600009D RID: 157 RVA: 0x0000EFC6 File Offset: 0x0000D1C6
		public void OpenHeaderDAT(Stream xIn)
		{
			this.Header = HeaderDAT.ReadHeader(xIn);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000EFD4 File Offset: 0x0000D1D4
		public void OpenPlayerDAT(Stream xIn)
		{
			this.PlayerData = PlayerDAT.ReadPlayerData(xIn);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000EFE2 File Offset: 0x0000D1E2
		public void OpenGamertagData(Stream xIn)
		{
			this.GamertagData = GamertagDataDb.ReadGamertagData(xIn);
		}
	}
}
