using System;
using System.IO;
using System.Xml.Serialization;

namespace TMF.XMLTools
{
	// Token: 0x0200005D RID: 93
	[XmlRoot("SkillData")]
	public class SkillData
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001524C File Offset: 0x0001344C
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00015254 File Offset: 0x00013454
		[XmlArray("ArrayOfSkillDataXML")]
		public SkillDataXML[] ArrayOfSkillDataXML { get; set; }

		// Token: 0x06000394 RID: 916 RVA: 0x00015260 File Offset: 0x00013460
		public static SkillData ReadSkillData(string skilldatapath)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(SkillData));
			FileStream stream = new FileStream(skilldatapath, FileMode.Open, FileAccess.Read, FileShare.Read);
			return (SkillData)xmlSerializer.Deserialize(stream);
		}
	}
}
