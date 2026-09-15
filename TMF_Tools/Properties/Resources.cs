using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TMF_Tools.Properties
{
	// Token: 0x0200002E RID: 46
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x060001FE RID: 510 RVA: 0x0001130F File Offset: 0x0000F50F
		internal Resources()
		{
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00011318 File Offset: 0x0000F518
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("TMF_Tools.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00011357 File Offset: 0x0000F557
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0001135E File Offset: 0x0000F55E
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00011368 File Offset: 0x0000F568
		internal static Bitmap InvalidItem
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("InvalidItem", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x040003E8 RID: 1000
		private static ResourceManager resourceMan;

		// Token: 0x040003E9 RID: 1001
		private static CultureInfo resourceCulture;
	}
}
