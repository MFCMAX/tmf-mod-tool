using System;
using System.IO;
using TMF.Enums;

namespace TMF.Structs.MapStructs
{
	// Token: 0x0200003F RID: 63
	public class TerrainData
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00011ADB File Offset: 0x0000FCDB
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00011AE3 File Offset: 0x0000FCE3
		public BiomeType Biome { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00011AEC File Offset: 0x0000FCEC
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		public int Iterations { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00011AFD File Offset: 0x0000FCFD
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00011B05 File Offset: 0x0000FD05
		public int MaxParticles { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00011B0E File Offset: 0x0000FD0E
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00011B16 File Offset: 0x0000FD16
		public Item GroundBlock { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00011B1F File Offset: 0x0000FD1F
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00011B27 File Offset: 0x0000FD27
		public ushort SeaLevel { get; set; }

		// Token: 0x0600023B RID: 571 RVA: 0x00011B30 File Offset: 0x0000FD30
		public static TerrainData ReadTerrainData(BinaryReader reader)
		{
			TerrainData terrainData = new TerrainData();
			int num = reader.ReadInt32();
			if (num < 0 || num > 8)
			{
				num = 6;
			}
			terrainData.Biome = (BiomeType)num;
			terrainData.GroundBlock = (Item)reader.ReadUInt16();
			terrainData.Iterations = reader.ReadInt32();
			terrainData.MaxParticles = reader.ReadInt32();
			terrainData.SeaLevel = reader.ReadUInt16();
			return terrainData;
		}
	}
}
