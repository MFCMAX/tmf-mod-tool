using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TMF_Tools
{
	// Token: 0x02000043 RID: 67
	internal static class Program
	{
		// Token: 0x0600025C RID: 604 RVA: 0x000120EC File Offset: 0x000102EC
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string embeddedResource = "TMF_Tools.betterlistviewexpress-net35.dll";
			EmbeddedAssembly.Load(embeddedResource, "betterlistviewexpress-net35.dll");
			AppDomain.CurrentDomain.AssemblyResolve += Program.TMF_Tools_AssemblyResolve;
			string str = Program.AssemblyDirectory + "\\";
			if (!File.Exists(str + "ItemData.xml"))
			{
				MessageBox.Show("ItemData.xml not found.\nPlease place ItemData.xml in the current directory.\nProgram will exit.", "Error - File Not Found", MessageBoxButtons.OK);
				return;
			}
			if (!File.Exists(str + "itemidindexes.txt"))
			{
				MessageBox.Show("itemidindexes.txt not found.\nPlease place itemidindexes.txt in the current directory.\nProgram will exit.", "Error - File Not Found", MessageBoxButtons.OK);
				return;
			}
			if (!File.Exists(str + "BlueprintData.xml"))
			{
				MessageBox.Show("BlueprintData.xml not found.\nPlease place BlueprintData.xml in the current directory.\nProgram will exit.", "Error - File Not Found", MessageBoxButtons.OK);
				return;
			}
			if (!File.Exists(str + "itemblueprintids.txt"))
			{
				MessageBox.Show("itemblueprintids.txt not found.\nPlease place itemblueprintids.txt in the current directory.\nProgram will exit.", "Error - File Not Found", MessageBoxButtons.OK);
				return;
			}
			Application.Run(new Main());
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000121D5 File Offset: 0x000103D5
		private static Assembly TMF_Tools_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			return EmbeddedAssembly.Get(args.Name);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000121E4 File Offset: 0x000103E4
		public static string AssemblyDirectory
		{
			get
			{
				string codeBase = Assembly.GetExecutingAssembly().CodeBase;
				UriBuilder uriBuilder = new UriBuilder(codeBase);
				string path = Uri.UnescapeDataString(uriBuilder.Path);
				return Path.GetDirectoryName(path);
			}
		}
	}
}
