using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

// Token: 0x0200000B RID: 11
public class EmbeddedAssembly
{
	// Token: 0x0600007D RID: 125 RVA: 0x0000EC08 File Offset: 0x0000CE08
	public static void Load(string embeddedResource, string fileName)
	{
		if (EmbeddedAssembly.dic == null)
		{
			EmbeddedAssembly.dic = new Dictionary<string, Assembly>();
		}
		byte[] array = null;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Assembly assembly;
		using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(embeddedResource))
		{
			if (manifestResourceStream == null)
			{
				throw new Exception(embeddedResource + " is not found in Embedded Resources.");
			}
			array = new byte[(int)manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
			try
			{
				assembly = Assembly.Load(array);
				EmbeddedAssembly.dic.Add(assembly.FullName, assembly);
				return;
			}
			catch
			{
			}
		}
		bool flag = false;
		string path = "";
		using (SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider())
		{
			string a = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(array)).Replace("-", string.Empty);
			path = Path.GetTempPath() + fileName;
			if (File.Exists(path))
			{
				byte[] buffer = File.ReadAllBytes(path);
				string b = BitConverter.ToString(sha1CryptoServiceProvider.ComputeHash(buffer)).Replace("-", string.Empty);
				flag = (a == b);
			}
			else
			{
				flag = false;
			}
		}
		if (!flag)
		{
			File.WriteAllBytes(path, array);
		}
		assembly = Assembly.LoadFile(path);
		EmbeddedAssembly.dic.Add(assembly.FullName, assembly);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0000ED78 File Offset: 0x0000CF78
	public static Assembly Get(string assemblyFullName)
	{
		if (EmbeddedAssembly.dic == null || EmbeddedAssembly.dic.Count == 0)
		{
			return null;
		}
		if (EmbeddedAssembly.dic.ContainsKey(assemblyFullName))
		{
			return EmbeddedAssembly.dic[assemblyFullName];
		}
		return null;
	}

	// Token: 0x040000DB RID: 219
	private static Dictionary<string, Assembly> dic;
}
