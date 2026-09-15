using System;
using System.IO;
using TMF.Enums;
using TMF.Structs;
using TMF.Structs.EntityStructs;
using TMF.Structs.MapStructs;
using TMF.Utils;

namespace TMF.FileTypes
{
	// Token: 0x02000014 RID: 20
	public class HeaderDAT
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000F1AE File Offset: 0x0000D3AE
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000F1B6 File Offset: 0x0000D3B6
		public int ExeVersion { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000F1BF File Offset: 0x0000D3BF
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000F1C7 File Offset: 0x0000D3C7
		public int SaveVersion { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		public int CreatedVersion { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000F1E1 File Offset: 0x0000D3E1
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000F1E9 File Offset: 0x0000D3E9
		public string MapName { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000F1F2 File Offset: 0x0000D3F2
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000F1FA File Offset: 0x0000D3FA
		public string OwnerGamerTag { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000F203 File Offset: 0x0000D403
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000F20B File Offset: 0x0000D40B
		public long DateCreated { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000F214 File Offset: 0x0000D414
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000F21C File Offset: 0x0000D41C
		public int TimeCreated { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000F225 File Offset: 0x0000D425
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000F22D File Offset: 0x0000D42D
		public bool IsAutoSave { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000F236 File Offset: 0x0000D436
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000F23E File Offset: 0x0000D43E
		public Point3D RegionSize { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000F247 File Offset: 0x0000D447
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000F24F File Offset: 0x0000D44F
		public Point3D ChunkSize { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000F258 File Offset: 0x0000D458
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000F260 File Offset: 0x0000D460
		public int MapSeed { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000F269 File Offset: 0x0000D469
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000F271 File Offset: 0x0000D471
		public SaveFormat Format { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000F27A File Offset: 0x0000D47A
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000F282 File Offset: 0x0000D482
		public int GameType { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000F28B File Offset: 0x0000D48B
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000F293 File Offset: 0x0000D493
		public GameMode GameMode { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000F29C File Offset: 0x0000D49C
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
		public MapAttribute MapAttribute { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000F2AD File Offset: 0x0000D4AD
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000F2B5 File Offset: 0x0000D4B5
		public GameDifficulty GameDifficulty { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000F2BE File Offset: 0x0000D4BE
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000F2C6 File Offset: 0x0000D4C6
		public bool GoodHash { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000F2CF File Offset: 0x0000D4CF
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000F2D7 File Offset: 0x0000D4D7
		public bool PvPCombat { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000F2E0 File Offset: 0x0000D4E0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public bool CombatEnabled { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000F2F1 File Offset: 0x0000D4F1
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000F2F9 File Offset: 0x0000D4F9
		public bool FiniteMode { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000F302 File Offset: 0x0000D502
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000F30A File Offset: 0x0000D50A
		public bool PassiveMobs { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000F313 File Offset: 0x0000D513
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000F31B File Offset: 0x0000D51B
		public bool EnemyMobs { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000F324 File Offset: 0x0000D524
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000F32C File Offset: 0x0000D52C
		public bool KeepItemsOnDeath { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000F335 File Offset: 0x0000D535
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000F33D File Offset: 0x0000D53D
		public bool DayNightActive { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000F346 File Offset: 0x0000D546
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000F34E File Offset: 0x0000D54E
		public int DaysIntoGame { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000F357 File Offset: 0x0000D557
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000F35F File Offset: 0x0000D55F
		public int TicksSlept { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000F368 File Offset: 0x0000D568
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000F370 File Offset: 0x0000D570
		public int UnusedInt1 { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000F379 File Offset: 0x0000D579
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000F381 File Offset: 0x0000D581
		public byte UnusedByte1 { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000F38A File Offset: 0x0000D58A
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000F392 File Offset: 0x0000D592
		public int DepthReached { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000F39B File Offset: 0x0000D59B
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000F3A3 File Offset: 0x0000D5A3
		public float RatingStars { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		public int RatingCount { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000F3BD File Offset: 0x0000D5BD
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000F3C5 File Offset: 0x0000D5C5
		public bool SkillsEnabled { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000F3CE File Offset: 0x0000D5CE
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000F3D6 File Offset: 0x0000D5D6
		public Permissions DefaultPermission { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000F3DF File Offset: 0x0000D5DF
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000F3E7 File Offset: 0x0000D5E7
		public string TexturePack { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000F3F8 File Offset: 0x0000D5F8
		public TerrainData TerrainData { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000F401 File Offset: 0x0000D601
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000F409 File Offset: 0x0000D609
		public BiomeParams BiomeParams { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000107 RID: 263 RVA: 0x0000F412 File Offset: 0x0000D612
		// (set) Token: 0x06000108 RID: 264 RVA: 0x0000F41A File Offset: 0x0000D61A
		public int MaxPlayers { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000F423 File Offset: 0x0000D623
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000F42B File Offset: 0x0000D62B
		public int PrivateSlots { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000F434 File Offset: 0x0000D634
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000F43C File Offset: 0x0000D63C
		public short CombatLevelDifference { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000F445 File Offset: 0x0000D645
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000F44D File Offset: 0x0000D64D
		public int MapWidth { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000F456 File Offset: 0x0000D656
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000F45E File Offset: 0x0000D65E
		public int MapHeight { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000F467 File Offset: 0x0000D667
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000F46F File Offset: 0x0000D66F
		public bool Pre18 { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000F478 File Offset: 0x0000D678
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000F480 File Offset: 0x0000D680
		public SaveGameState GameState { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000F489 File Offset: 0x0000D689
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000F491 File Offset: 0x0000D691
		public SaveMobManagerState MobState { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000F49A File Offset: 0x0000D69A
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000F4A2 File Offset: 0x0000D6A2
		public SaveArcadeState ArcadeState { get; set; }

		// Token: 0x06000119 RID: 281 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		public static HeaderDAT ReadHeader(Stream headerIn)
		{
			HeaderDAT headerDAT = new HeaderDAT();
			BinaryReader binaryReader = new BinaryReader(headerIn);
			headerDAT.SaveVersion = binaryReader.ReadInt32();
			headerDAT.ExeVersion = binaryReader.ReadInt32();
			headerDAT.CreatedVersion = binaryReader.ReadInt32();
			headerDAT.MapName = binaryReader.ReadString();
			headerDAT.OwnerGamerTag = binaryReader.ReadString();
			headerDAT.DateCreated = binaryReader.ReadInt64();
			binaryReader.ReadByte();
			headerDAT.TimeCreated = binaryReader.ReadInt32();
			headerDAT.IsAutoSave = binaryReader.ReadBoolean();
			headerDAT.MapBound = new BoxInt
			{
				Min = new GlobalPoint3D
				{
					X = binaryReader.ReadInt32(),
					Y = binaryReader.ReadInt32(),
					Z = binaryReader.ReadInt32()
				},
				Max = new GlobalPoint3D
				{
					X = binaryReader.ReadInt32(),
					Y = binaryReader.ReadInt32(),
					Z = binaryReader.ReadInt32()
				}
			};
			headerDAT.RegionSize = new Point3D
			{
				X = (int)binaryReader.ReadUInt16(),
				Y = (int)binaryReader.ReadUInt16(),
				Z = (int)binaryReader.ReadUInt16()
			};
			headerDAT.ChunkSize = new Point3D
			{
				X = (int)binaryReader.ReadUInt16(),
				Y = (int)binaryReader.ReadUInt16(),
				Z = (int)binaryReader.ReadUInt16()
			};
			headerDAT.MapSeed = binaryReader.ReadInt32();
			headerDAT.Format = (SaveFormat)binaryReader.ReadInt32();
			headerDAT.GameType = binaryReader.ReadInt32();
			headerDAT.GameMode = (GameMode)binaryReader.ReadInt32();
			headerDAT.TicksSlept = binaryReader.ReadInt32();
			headerDAT.RatingCount = binaryReader.ReadInt32() / 144;
			headerDAT.UnusedInt1 = binaryReader.ReadInt32();
			headerDAT.DepthReached = binaryReader.ReadInt32();
			headerDAT.MapAttribute = (MapAttribute)binaryReader.ReadInt32();
			headerDAT.RatingStars = binaryReader.ReadSingle() / 4498.25f;
			headerDAT.GameDifficulty = (GameDifficulty)binaryReader.ReadInt32();
			headerDAT.PvPCombat = binaryReader.ReadBoolean();
			headerDAT.CombatEnabled = binaryReader.ReadBoolean();
			headerDAT.FiniteMode = binaryReader.ReadBoolean();
			headerDAT.PassiveMobs = binaryReader.ReadBoolean();
			headerDAT.EnemyMobs = binaryReader.ReadBoolean();
			headerDAT.KeepItemsOnDeath = binaryReader.ReadBoolean();
			headerDAT.SkillsEnabled = binaryReader.ReadBoolean();
			headerDAT.DayNightActive = binaryReader.ReadBoolean();
			headerDAT.UnusedByte1 = binaryReader.ReadByte();
			headerDAT.DaysIntoGame = binaryReader.ReadInt32();
			headerDAT.DefaultPermission = (Permissions)binaryReader.ReadInt32();
			headerDAT.MaxPlayers = binaryReader.ReadInt32();
			headerDAT.PrivateSlots = binaryReader.ReadInt32();
			headerDAT.CombatLevelDifference = binaryReader.ReadInt16();
			headerDAT.TexturePack = binaryReader.ReadString();
			headerDAT.TerrainData = TerrainData.ReadTerrainData(binaryReader);
			headerDAT.BiomeParams = BiomeParams.ReadBiomeParams(binaryReader);
			headerDAT.GameState = SaveGameState.ReadSaveGameState(binaryReader);
			headerDAT.MobState = SaveMobManagerState.ReadState(binaryReader);
			headerDAT.ArcadeState = new SaveArcadeState
			{
				SpaceInvadersHighScore = binaryReader.ReadInt32()
			};
			return headerDAT;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		public void WriteData(Stream xOut)
		{
			BinaryWriter binaryWriter = new BinaryWriter(xOut);
			binaryWriter.Write(this.SaveVersion);
			binaryWriter.Write(this.ExeVersion);
			binaryWriter.Write(this.CreatedVersion);
			binaryWriter.Write(this.MapName);
			binaryWriter.Write(this.OwnerGamerTag);
			binaryWriter.Write(this.DateCreated);
			binaryWriter.Write(49);
			binaryWriter.Write(this.TimeCreated);
			binaryWriter.Write(this.IsAutoSave);
			this.MapBound.Write(binaryWriter);
			binaryWriter.Write((ushort)this.RegionSize.X);
			binaryWriter.Write((ushort)this.RegionSize.Y);
			binaryWriter.Write((ushort)this.RegionSize.Z);
			binaryWriter.Write((ushort)this.ChunkSize.X);
			binaryWriter.Write((ushort)this.ChunkSize.Y);
			binaryWriter.Write((ushort)this.ChunkSize.Z);
			binaryWriter.Write(this.MapSeed);
			binaryWriter.Write((int)this.Format);
			binaryWriter.Write(this.GameType);
			binaryWriter.Write((int)this.GameMode);
			binaryWriter.Write(this.TicksSlept);
			binaryWriter.Write(this.RatingCount * 144);
			binaryWriter.Write(this.UnusedInt1);
			binaryWriter.Write(this.DepthReached);
			binaryWriter.Write((int)this.MapAttribute);
			binaryWriter.Write(this.RatingStars * 4498.25f);
			binaryWriter.Write((int)this.GameDifficulty);
			binaryWriter.Write(this.PvPCombat);
			binaryWriter.Write(this.CombatEnabled);
			binaryWriter.Write(this.FiniteMode);
			binaryWriter.Write(this.PassiveMobs);
			binaryWriter.Write(this.EnemyMobs);
			binaryWriter.Write(this.KeepItemsOnDeath);
			binaryWriter.Write(this.SkillsEnabled);
			binaryWriter.Write(this.DayNightActive);
			binaryWriter.Write(this.UnusedByte1);
			binaryWriter.Write(this.DaysIntoGame);
			binaryWriter.Write((int)this.DefaultPermission);
			binaryWriter.Write(this.MaxPlayers);
			binaryWriter.Write(this.PrivateSlots);
			binaryWriter.Write(this.CombatLevelDifference);
			binaryWriter.Write(this.TexturePack);
			binaryWriter.Write((int)this.TerrainData.Biome);
			binaryWriter.Write((ushort)this.TerrainData.GroundBlock);
			binaryWriter.Write(this.TerrainData.Iterations);
			binaryWriter.Write(this.TerrainData.MaxParticles);
			binaryWriter.Write(this.TerrainData.SeaLevel);
			binaryWriter.Write(this.BiomeParams.MaxHeight);
			binaryWriter.Write(this.BiomeParams.MaxSeaDepth);
			binaryWriter.Write(this.BiomeParams.WaterSaturation);
			binaryWriter.Write(this.BiomeParams.DirtHeight);
			binaryWriter.Write(this.BiomeParams.BasaltHeight);
			binaryWriter.Write(this.BiomeParams.SnowLayerHeight);
			binaryWriter.Write(this.BiomeParams.SnowHeight);
			binaryWriter.Write(this.BiomeParams.BigDetailNoise);
			binaryWriter.Write(this.BiomeParams.MediumDetailNoise);
			binaryWriter.Write(this.BiomeParams.FineDetailNoise);
			binaryWriter.Write(this.BiomeParams.BigDetailMultiplier);
			binaryWriter.Write(this.BiomeParams.MediumDetailMultiplier);
			binaryWriter.Write(this.BiomeParams.FineDetailMultiplier);
			binaryWriter.Write(this.BiomeParams.TotalNoiseDivisor);
			this.GameState.WriteState(binaryWriter);
			this.MobState.WriteMobState(binaryWriter);
			binaryWriter.Write(this.ArcadeState.SpaceInvadersHighScore);
			Encryption.WriteHashToStream(xOut);
		}

		// Token: 0x04000101 RID: 257
		public BoxInt MapBound;
	}
}
