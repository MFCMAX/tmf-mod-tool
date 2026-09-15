using System;
using System.Xml.Serialization;
using TMF.Enums;

namespace TMF.XMLTools
{
	// Token: 0x02000049 RID: 73
	public class ItemDataXML
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000125BB File Offset: 0x000107BB
		// (set) Token: 0x06000295 RID: 661 RVA: 0x000125C3 File Offset: 0x000107C3
		[XmlElement("ItemID")]
		public string ItemID { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000296 RID: 662 RVA: 0x000125CC File Offset: 0x000107CC
		// (set) Token: 0x06000297 RID: 663 RVA: 0x000125D4 File Offset: 0x000107D4
		[XmlElement("Desc")]
		public string Desc { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000125DD File Offset: 0x000107DD
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000125E5 File Offset: 0x000107E5
		[XmlElement("IsValid")]
		public bool IsValid { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000125EE File Offset: 0x000107EE
		// (set) Token: 0x0600029B RID: 667 RVA: 0x000125F6 File Offset: 0x000107F6
		[XmlElement("MinCSPrice")]
		public int MinCSPrice { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000125FF File Offset: 0x000107FF
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00012607 File Offset: 0x00010807
		[XmlElement("StackSize")]
		public int StackSize { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00012610 File Offset: 0x00010810
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00012618 File Offset: 0x00010818
		[XmlElement("Durability")]
		public ushort Durability { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00012621 File Offset: 0x00010821
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00012629 File Offset: 0x00010829
		[XmlElement("ItemType")]
		public ItemType ItemType { get; set; }
	}
}
