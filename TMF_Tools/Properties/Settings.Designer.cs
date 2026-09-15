using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace TMF_Tools.Properties
{
	// Token: 0x02000044 RID: 68
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00012215 File Offset: 0x00010415
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000582 RID: 1410
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
