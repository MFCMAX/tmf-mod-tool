using System;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000020 RID: 32
	public class SaveChestState : SaveInventoryState
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0001012D File Offset: 0x0000E32D
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00010135 File Offset: 0x0000E335
		public GlobalPoint3D Point { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0001013E File Offset: 0x0000E33E
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00010146 File Offset: 0x0000E346
		public string Gamertag { get; set; }
	}
}
