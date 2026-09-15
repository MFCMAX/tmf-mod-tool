using System;
using System.Xml.Serialization;
using TMF.Enums;

namespace TMF.XMLTools
{
	// Token: 0x0200005A RID: 90
	public class BlueprintXML
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00014C7B File Offset: 0x00012E7B
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00014C83 File Offset: 0x00012E83
		[XmlElement("ItemID")]
		public Item ItemID { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00014C8C File Offset: 0x00012E8C
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00014C94 File Offset: 0x00012E94
		[XmlElement("Result")]
		public BlueprintDataResult Result { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00014C9D File Offset: 0x00012E9D
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00014CA5 File Offset: 0x00012EA5
		[XmlElement("CraftType")]
		public BlueprintCraftType CraftType { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00014CAE File Offset: 0x00012EAE
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00014CB6 File Offset: 0x00012EB6
		[XmlElement("SortID")]
		public int SortID { get; set; }
	}
}
