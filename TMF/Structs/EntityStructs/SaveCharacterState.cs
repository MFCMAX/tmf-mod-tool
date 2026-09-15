using System;
using TMF.Enums;
using TMF.Structs.OtherStructs;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000025 RID: 37
	public class SaveCharacterState : SaveCharacterBaseState
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00010181 File Offset: 0x0000E381
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00010189 File Offset: 0x0000E389
		public Vector2 ViewAngle { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00010192 File Offset: 0x0000E392
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0001019A File Offset: 0x0000E39A
		public float Oxygen { get; set; }

		// Token: 0x04000377 RID: 887
		public Permissions Permission;
	}
}
