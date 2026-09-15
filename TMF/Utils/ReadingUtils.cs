using System;
using System.Collections.Generic;
using System.IO;

namespace TMF.Utils
{
	// Token: 0x02000031 RID: 49
	public static class ReadingUtils
	{
		// Token: 0x0600020C RID: 524 RVA: 0x000113E7 File Offset: 0x0000F5E7
		public static string ReadGamertag(BinaryReader reader)
		{
			return ReadingUtils.ReadEncryptedString(reader);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000113F0 File Offset: 0x0000F5F0
		public static string ReadEncryptedString(BinaryReader reader)
		{
			int key = (int)reader.ReadByte();
			int num = (int)reader.ReadByte();
			byte[] array = new byte[num];
			if (num > 0)
			{
				reader.Read(array, 0, num);
			}
			string text = ReadingUtils.UnencryptString(array, key);
			if (text != null)
			{
				return text;
			}
			return "";
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00011434 File Offset: 0x0000F634
		public static string UnencryptString(byte[] data, int key)
		{
			string text = null;
			if (data != null && data.Length > 0)
			{
				for (int i = 0; i < data.Length; i++)
				{
					text += (char)((int)data[i] - key);
				}
			}
			return text;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00011470 File Offset: 0x0000F670
		public static List<string> ReadStringList(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			List<string> list = new List<string>(num);
			for (int i = 0; i < num; i++)
			{
				list.Add(reader.ReadString());
			}
			return list;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000114A4 File Offset: 0x0000F6A4
		public static void WriteStringList(BinaryWriter writer, List<string> list)
		{
			writer.Write(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				writer.Write(list[i]);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000114DB File Offset: 0x0000F6DB
		public static void WriteGamertag(BinaryWriter writer, string tag)
		{
			ReadingUtils.WriteEncryptedString(writer, tag);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000114E4 File Offset: 0x0000F6E4
		public static void WriteEncryptedString(BinaryWriter writer, string s)
		{
			int num = new Random().Next(44, 86);
			writer.Write((byte)num);
			if (s == null)
			{
				writer.Write(0);
				return;
			}
			writer.Write((byte)s.Length);
			writer.Write(ReadingUtils.EncryptString(s, num));
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00011530 File Offset: 0x0000F730
		public static byte[] EncryptString(string str, int key)
		{
			byte[] array = new byte[str.Length];
			for (int i = 0; i < str.Length; i++)
			{
				array[i] = (byte)((int)str.ToCharArray()[i] + key);
			}
			return array;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001156C File Offset: 0x0000F76C
		public static void ReadRandBuffer(BinaryReader reader)
		{
			byte b = reader.ReadByte();
			for (int i = 0; i < (int)b; i++)
			{
				reader.ReadByte();
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00011594 File Offset: 0x0000F794
		public static void WriteRandBuffer(BinaryWriter writer, int max)
		{
			Random random = new Random();
			byte b = (byte)random.Next(max);
			writer.Write(b);
			for (int i = 0; i < (int)b; i++)
			{
				writer.Write((byte)random.Next(255));
			}
		}
	}
}
