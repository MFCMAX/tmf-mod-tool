using System;
using System.Xml.Serialization;
using TMF.Enums;
using TMF.Structs.EntityStructs;

namespace TMF.Structs.OtherStructs
{
	// Token: 0x02000010 RID: 16
	public class Blueprint
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000EF58 File Offset: 0x0000D158
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000EF60 File Offset: 0x0000D160
		public SaveInventoryItem Result { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000EF69 File Offset: 0x0000D169
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000EF71 File Offset: 0x0000D171
		[XmlElement("CraftType")]
		public BlueprintCraftType CraftType { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000EF7A File Offset: 0x0000D17A
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000EF82 File Offset: 0x0000D182
		[XmlElement("SortID")]
		public int SortID { get; set; }
	}
}
