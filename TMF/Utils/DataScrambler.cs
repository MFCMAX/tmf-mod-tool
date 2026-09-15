using System;

namespace TMF.Utils
{
	// Token: 0x02000034 RID: 52
	internal static class DataScrambler
	{
		// Token: 0x0600021A RID: 538 RVA: 0x000117E0 File Offset: 0x0000F9E0
		public static byte RandomScramble(byte[] data)
		{
			byte result = (byte)new Random().Next(4);
			byte b = DataScrambler.test;
			DataScrambler.test = b + 1;
			if (b == 4)
			{
				DataScrambler.test = 0;
			}
			result = DataScrambler.test;
			switch (result)
			{
			case 1:
				DataScrambler.Scramble4thBitSwap(data);
				DataScrambler.ScrambleOppositeEndsSwap(data);
				DataScrambler.ScramblePairSwap(data);
				break;
			case 2:
				DataScrambler.Scramble6thBitSwap(data);
				DataScrambler.ScrambleOppositeEndsSwap(data);
				DataScrambler.ScramblePairSwap(data);
				break;
			case 3:
				DataScrambler.Scramble6thBitSwap(data);
				DataScrambler.ScramblePairSwap(data);
				DataScrambler.ScrambleOppositeEndsSwap(data);
				break;
			default:
				DataScrambler.Scramble4thBitSwap(data);
				DataScrambler.ScramblePairSwap(data);
				DataScrambler.ScrambleOppositeEndsSwap(data);
				break;
			}
			return result;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00011880 File Offset: 0x0000FA80
		public static void Unscramble(byte[] data, byte scrambleID)
		{
			switch (scrambleID)
			{
			case 1:
				DataScrambler.ScramblePairSwap(data);
				DataScrambler.ScrambleOppositeEndsSwap(data);
				DataScrambler.Scramble4thBitSwap(data);
				return;
			case 2:
				DataScrambler.ScramblePairSwap(data);
				DataScrambler.ScrambleOppositeEndsSwap(data);
				DataScrambler.Scramble6thBitSwap(data);
				return;
			case 3:
				DataScrambler.ScrambleOppositeEndsSwap(data);
				DataScrambler.ScramblePairSwap(data);
				DataScrambler.Scramble6thBitSwap(data);
				return;
			default:
				DataScrambler.ScrambleOppositeEndsSwap(data);
				DataScrambler.ScramblePairSwap(data);
				DataScrambler.Scramble4thBitSwap(data);
				return;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000118F0 File Offset: 0x0000FAF0
		public static void ScramblePairSwap(byte[] data)
		{
			for (int i = 0; i < data.Length - 1; i += 2)
			{
				byte b = data[i];
				data[i] = data[i + 1];
				data[i + 1] = b;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00011920 File Offset: 0x0000FB20
		public static void ScrambleOppositeEndsSwap(byte[] data)
		{
			int i = 0;
			int num = data.Length - 1;
			while (i < data.Length / 2)
			{
				byte b = data[i];
				data[i] = data[num];
				data[num] = b;
				i++;
				num--;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00011958 File Offset: 0x0000FB58
		public static void Scramble4thBitSwap(byte[] data)
		{
			for (int i = 0; i < data.Length - 1; i++)
			{
				byte b = data[i];
				if ((b & 8) > 0)
				{
					if ((b & 4) > 0)
					{
						b &= 251;
					}
					else
					{
						b |= 4;
					}
				}
				data[i] = b;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001199C File Offset: 0x0000FB9C
		public static void Scramble6thBitSwap(byte[] data)
		{
			for (int i = 0; i < data.Length - 1; i++)
			{
				byte b = data[i];
				if ((b & 32) > 0)
				{
					if ((b & 16) > 0)
					{
						b &= 239;
					}
					else
					{
						b |= 16;
					}
				}
				data[i] = b;
			}
		}

		// Token: 0x040003F7 RID: 1015
		public const int ScrambleMethodCount = 4;

		// Token: 0x040003F8 RID: 1016
		private static byte test;
	}
}
