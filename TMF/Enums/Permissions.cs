using System;

namespace TMF.Enums
{
	// Token: 0x0200003D RID: 61
	public enum Permissions : ushort
	{
		// Token: 0x0400050D RID: 1293
		None,
		// Token: 0x0400050E RID: 1294
		Adventure,
		// Token: 0x0400050F RID: 1295
		Edit,
		// Token: 0x04000510 RID: 1296
		Creative = 4,
		// Token: 0x04000511 RID: 1297
		Fly = 8,
		// Token: 0x04000512 RID: 1298
		Map = 16,
		// Token: 0x04000513 RID: 1299
		Save = 32,
		// Token: 0x04000514 RID: 1300
		Admin = 64,
		// Token: 0x04000515 RID: 1301
		Grief = 128,
		// Token: 0x04000516 RID: 1302
		Chat = 256,
		// Token: 0x04000517 RID: 1303
		Spectate = 512
	}
}
