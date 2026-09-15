using System;
using System.Collections.Generic;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200001C RID: 28
	public class Script
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000FD8F File Offset: 0x0000DF8F
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0000FD97 File Offset: 0x0000DF97
		public string Name { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000FDA0 File Offset: 0x0000DFA0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000FDA8 File Offset: 0x0000DFA8
		public List<string> Commands { get; set; }
	}
}
