using System;
using System.IO;

namespace TMF.Structs.MapStructs
{
	// Token: 0x02000039 RID: 57
	public struct BoxInt
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00011A3D File Offset: 0x0000FC3D
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00011A45 File Offset: 0x0000FC45
		public GlobalPoint3D Min { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00011A4E File Offset: 0x0000FC4E
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00011A56 File Offset: 0x0000FC56
		public GlobalPoint3D Max { get; set; }

		// Token: 0x0600022F RID: 559 RVA: 0x00011A60 File Offset: 0x0000FC60
		public void Write(BinaryWriter writer)
		{
			writer.Write(this.Min.X);
			writer.Write(this.Min.Y);
			writer.Write(this.Min.Z);
			writer.Write(this.Max.X);
			writer.Write(this.Max.Y);
			writer.Write(this.Max.Z);
		}
	}
}
