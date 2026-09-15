using System;
using System.IO;

namespace TMF.Structs.MapStructs
{
	// Token: 0x02000013 RID: 19
	public class BiomeParams
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000F000 File Offset: 0x0000D200
		public int MaxHeight { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000F009 File Offset: 0x0000D209
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000F011 File Offset: 0x0000D211
		public int MaxSeaDepth { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000F01A File Offset: 0x0000D21A
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000F022 File Offset: 0x0000D222
		public int WaterSaturation { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000F02B File Offset: 0x0000D22B
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000F033 File Offset: 0x0000D233
		public int DirtHeight { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000F03C File Offset: 0x0000D23C
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000F044 File Offset: 0x0000D244
		public int BasaltHeight { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000F04D File Offset: 0x0000D24D
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000F055 File Offset: 0x0000D255
		public int SnowLayerHeight { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000F05E File Offset: 0x0000D25E
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000F066 File Offset: 0x0000D266
		public int SnowHeight { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000F06F File Offset: 0x0000D26F
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000F077 File Offset: 0x0000D277
		public float BigDetailNoise { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000F080 File Offset: 0x0000D280
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000F088 File Offset: 0x0000D288
		public float MediumDetailNoise { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000F091 File Offset: 0x0000D291
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000F099 File Offset: 0x0000D299
		public float FineDetailNoise { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000F0A2 File Offset: 0x0000D2A2
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000F0AA File Offset: 0x0000D2AA
		public float BigDetailMultiplier { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000F0B3 File Offset: 0x0000D2B3
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000F0BB File Offset: 0x0000D2BB
		public float MediumDetailMultiplier { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		public float FineDetailMultiplier { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000F0D5 File Offset: 0x0000D2D5
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000F0DD File Offset: 0x0000D2DD
		public float TotalNoiseDivisor { get; set; }

		// Token: 0x060000BD RID: 189 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
		public static BiomeParams ReadBiomeParams(BinaryReader reader)
		{
			return new BiomeParams
			{
				MaxHeight = reader.ReadInt32(),
				MaxSeaDepth = reader.ReadInt32(),
				WaterSaturation = reader.ReadInt32(),
				DirtHeight = reader.ReadInt32(),
				BasaltHeight = reader.ReadInt32(),
				SnowLayerHeight = reader.ReadInt32(),
				SnowHeight = reader.ReadInt32(),
				BigDetailNoise = reader.ReadSingle(),
				MediumDetailNoise = reader.ReadSingle(),
				FineDetailNoise = reader.ReadSingle(),
				BigDetailMultiplier = reader.ReadSingle(),
				MediumDetailMultiplier = reader.ReadSingle(),
				FineDetailMultiplier = reader.ReadSingle(),
				TotalNoiseDivisor = reader.ReadSingle()
			};
		}
	}
}
