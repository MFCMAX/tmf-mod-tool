using System;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000058 RID: 88
	public class SaveBookState
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0001498F File Offset: 0x00012B8F
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00014997 File Offset: 0x00012B97
		public ushort ID { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000149A0 File Offset: 0x00012BA0
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000149A8 File Offset: 0x00012BA8
		public string Title { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000149B1 File Offset: 0x00012BB1
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000149B9 File Offset: 0x00012BB9
		public string[] Text { get; set; }
	}
}
