using System;
using TMF.Structs.OtherStructs;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000024 RID: 36
	public class SaveItemParticle
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00010157 File Offset: 0x0000E357
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0001015F File Offset: 0x0000E35F
		public SaveInventoryItem Item { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00010168 File Offset: 0x0000E368
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00010170 File Offset: 0x0000E370
		public Vector3 Position { get; set; }
	}
}
