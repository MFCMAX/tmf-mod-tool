using System;
using System.IO;

namespace TMF.Utils
{
	// Token: 0x02000032 RID: 50
	public static class Encryption
	{
		// Token: 0x06000216 RID: 534 RVA: 0x000115D8 File Offset: 0x0000F7D8
		public static void WriteHashToStream(Stream xOut)
		{
			byte[] messageHash = Encryption.GetMessageHash(xOut, (int)xOut.Length, 190);
			byte value = DataScrambler.RandomScramble(messageHash);
			BinaryWriter binaryWriter = new BinaryWriter(xOut);
			binaryWriter.Write(messageHash);
			binaryWriter.Write(value);
			binaryWriter.Write(messageHash.Length);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00011620 File Offset: 0x0000F820
		public static byte[] GetMessageHash(Stream message, int length, int version)
		{
			byte[] array = new byte[64];
			Encryption.BuildMessageHash(message, length, array, version);
			return array;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00011640 File Offset: 0x0000F840
		private static void BuildMessageHash(Stream message, int length, byte[] hash, int version)
		{
			int num = hash.Length;
			if ((long)length > message.Length)
			{
				length = (int)message.Length;
			}
			message.Position = 0L;
			for (int i = 0; i < length; i++)
			{
				byte b = (byte)message.ReadByte();
				int num2 = i % num;
				int num3 = num2;
				int num4 = num3;
				hash[num4] += b;
			}
			long num5 = 0L;
			int num6 = (version < 130) ? 1 : 13;
			int num7 = (version < 130) ? 2000 : 3591;
			int num8 = (version < 130) ? 1000 : 1901;
			for (int j = 0; j < num; j++)
			{
				num5 += (long)(((int)hash[j] + num6) * num7);
			}
			num5 /= (long)num8;
			byte b2 = (byte)(num5 & 255L);
			for (int k = 0; k < num; k++)
			{
				int num9 = k;
				int num10 = num9;
				hash[num10] += b2;
			}
		}
	}
}
