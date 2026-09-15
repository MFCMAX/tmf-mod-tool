using System;

namespace TMF.Enums
{
	// Token: 0x02000030 RID: 48
	public enum ZoneType : byte
	{
		// Token: 0x040003EF RID: 1007
		None,
		// Token: 0x040003F0 RID: 1008
		Spawn,
		// Token: 0x040003F1 RID: 1009
		NoEdit,
		// Token: 0x040003F2 RID: 1010
		NoCombat = 4,
		// Token: 0x040003F3 RID: 1011
		Moving = 8,
		// Token: 0x040003F4 RID: 1012
		Jail = 16,
		// Token: 0x040003F5 RID: 1013
		NoFly = 32,
		// Token: 0x040003F6 RID: 1014
		NoMobs = 64
	}
}
