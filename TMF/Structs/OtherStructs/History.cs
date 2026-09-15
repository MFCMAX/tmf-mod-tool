using System;
using System.Collections.Generic;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x0200004B RID: 75
	public class History
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x0001263A File Offset: 0x0001083A
		public History()
		{
			this.Table = new Dictionary<string, int>();
		}

		// Token: 0x040005A7 RID: 1447
		public Dictionary<string, int> Table;
	}
}
