using System;
using System.Collections.Generic;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000056 RID: 86
	public class SaveSignsState
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00014954 File Offset: 0x00012B54
		// (set) Token: 0x0600035E RID: 862 RVA: 0x0001495C File Offset: 0x00012B5C
		public int SignCount { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00014965 File Offset: 0x00012B65
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0001496D File Offset: 0x00012B6D
		public List<string> SignText { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00014976 File Offset: 0x00012B76
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0001497E File Offset: 0x00012B7E
		public List<SaveSignState> Signs { get; set; }
	}
}
