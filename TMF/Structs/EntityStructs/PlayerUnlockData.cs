using System;
using System.Collections.Generic;
using System.IO;
using TMF.Enums;
using TMF.Structs.OtherStructs;
using TMF.Utils;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200002C RID: 44
	public class PlayerUnlockData
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00010628 File Offset: 0x0000E828
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00010630 File Offset: 0x0000E830
		public int ArrowsCrafted { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00010639 File Offset: 0x0000E839
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00010641 File Offset: 0x0000E841
		public bool BedrockReached { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0001064A File Offset: 0x0000E84A
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00010652 File Offset: 0x0000E852
		public int BlocksClearedWithWoodPick { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0001065B File Offset: 0x0000E85B
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00010663 File Offset: 0x0000E863
		public int BlueprintsFound { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0001066C File Offset: 0x0000E86C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00010674 File Offset: 0x0000E874
		public bool BowCrafted { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0001067D File Offset: 0x0000E87D
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00010685 File Offset: 0x0000E885
		public int DetonationCount { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0001068E File Offset: 0x0000E88E
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00010696 File Offset: 0x0000E896
		public bool EscapedToSurface { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0001069F File Offset: 0x0000E89F
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000106A7 File Offset: 0x0000E8A7
		public int EnemiesKilledWithArrow { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000106B0 File Offset: 0x0000E8B0
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000106B8 File Offset: 0x0000E8B8
		public int EnemiesKilledWithGrenadeLauncher { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000106C1 File Offset: 0x0000E8C1
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000106C9 File Offset: 0x0000E8C9
		public int EnemiesKilledWhileHangingFromRope { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000106D2 File Offset: 0x0000E8D2
		// (set) Token: 0x0600018D RID: 397 RVA: 0x000106DA File Offset: 0x0000E8DA
		public int EnemiesKilledBeforeReachingBedrock { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000106E3 File Offset: 0x0000E8E3
		// (set) Token: 0x0600018F RID: 399 RVA: 0x000106EB File Offset: 0x0000E8EB
		public int GoldEarned { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000106F4 File Offset: 0x0000E8F4
		// (set) Token: 0x06000191 RID: 401 RVA: 0x000106FC File Offset: 0x0000E8FC
		public int GrenadesCrafted { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00010705 File Offset: 0x0000E905
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0001070D File Offset: 0x0000E90D
		public int GrenadesLaunched { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00010716 File Offset: 0x0000E916
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0001071E File Offset: 0x0000E91E
		public bool GrenadeLauncherCrafted { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00010727 File Offset: 0x0000E927
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0001072F File Offset: 0x0000E92F
		public int HealedSelf { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00010738 File Offset: 0x0000E938
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00010740 File Offset: 0x0000E940
		public int HealedOther { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00010749 File Offset: 0x0000E949
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00010751 File Offset: 0x0000E951
		public bool[][] HowToRead { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001075A File Offset: 0x0000E95A
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00010762 File Offset: 0x0000E962
		public bool HandyManUnlocked { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0001076B File Offset: 0x0000E96B
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00010773 File Offset: 0x0000E973
		public bool EntrepreneurUnlocked { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001077C File Offset: 0x0000E97C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00010784 File Offset: 0x0000E984
		public bool GoldenKnightUnlocked { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0001078D File Offset: 0x0000E98D
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00010795 File Offset: 0x0000E995
		public bool KingUnlocked { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0001079E File Offset: 0x0000E99E
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000107A6 File Offset: 0x0000E9A6
		public bool SageUnlocked { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000107AF File Offset: 0x0000E9AF
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000107B7 File Offset: 0x0000E9B7
		public bool KnightUnlocked { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000107C0 File Offset: 0x0000E9C0
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000107C8 File Offset: 0x0000E9C8
		public bool ExplorerUnlocked { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000107D1 File Offset: 0x0000E9D1
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000107D9 File Offset: 0x0000E9D9
		public int InvadersScore { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000107E2 File Offset: 0x0000E9E2
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000107EA File Offset: 0x0000E9EA
		public int PlayersSavedFromDeath { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000107F3 File Offset: 0x0000E9F3
		// (set) Token: 0x060001AF RID: 431 RVA: 0x000107FB File Offset: 0x0000E9FB
		public bool RastaFill { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00010804 File Offset: 0x0000EA04
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0001080C File Offset: 0x0000EA0C
		public int RemotePlayersKilled { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00010815 File Offset: 0x0000EA15
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0001081D File Offset: 0x0000EA1D
		public bool ThrownFishAtSleepingPlayer { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00010826 File Offset: 0x0000EA26
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0001082E File Offset: 0x0000EA2E
		public int FlowersThrownAtEnemy { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00010837 File Offset: 0x0000EA37
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0001083F File Offset: 0x0000EA3F
		public int TreesChopped { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00010848 File Offset: 0x0000EA48
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00010850 File Offset: 0x0000EA50
		public int SaplingsPlanted { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00010859 File Offset: 0x0000EA59
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00010861 File Offset: 0x0000EA61
		public int WoodPlanksCrafted { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0001086A File Offset: 0x0000EA6A
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00010872 File Offset: 0x0000EA72
		public int TreasureChestsOpened { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0001087B File Offset: 0x0000EA7B
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00010883 File Offset: 0x0000EA83
		public int RemoteVisitors { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0001088C File Offset: 0x0000EA8C
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00010894 File Offset: 0x0000EA94
		public int WisdomFound { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0001089D File Offset: 0x0000EA9D
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000108A5 File Offset: 0x0000EAA5
		public bool WorkbenchCrafted { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000108AE File Offset: 0x0000EAAE
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000108B6 File Offset: 0x0000EAB6
		public bool KilledDiablo { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000108BF File Offset: 0x0000EABF
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x000108C7 File Offset: 0x0000EAC7
		public bool ShopPurchase { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000108D0 File Offset: 0x0000EAD0
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000108D8 File Offset: 0x0000EAD8
		public List<int> WorldsVisited { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000108E1 File Offset: 0x0000EAE1
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000108E9 File Offset: 0x0000EAE9
		public bool ZuesPlaced { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000108F2 File Offset: 0x0000EAF2
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000108FA File Offset: 0x0000EAFA
		public BadBoyType BadBoy { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00010903 File Offset: 0x0000EB03
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0001090B File Offset: 0x0000EB0B
		public int SurvivalDaysSurvived { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00010914 File Offset: 0x0000EB14
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0001091C File Offset: 0x0000EB1C
		public ActionLog ActionLog { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00010925 File Offset: 0x0000EB25
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0001092D File Offset: 0x0000EB2D
		public List<int> KillStreamGamerID { get; set; }

		// Token: 0x060001D4 RID: 468 RVA: 0x00010936 File Offset: 0x0000EB36
		public PlayerUnlockData()
		{
			this.KillStreamGamerID = new List<int>();
			this.WorldsVisited = new List<int>();
			this.ActionLog = new ActionLog();
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00010960 File Offset: 0x0000EB60
		public static PlayerUnlockData ReadPlayerUnlockData(BinaryReader reader)
		{
			PlayerUnlockData playerUnlockData = new PlayerUnlockData();
			playerUnlockData.ArrowsCrafted = reader.ReadInt32();
			playerUnlockData.KnightUnlocked = reader.ReadBoolean();
			playerUnlockData.BlocksClearedWithWoodPick = reader.ReadInt32();
			playerUnlockData.BlueprintsFound = reader.ReadInt32();
			playerUnlockData.BowCrafted = reader.ReadBoolean();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			playerUnlockData.DetonationCount = reader.ReadInt32();
			playerUnlockData.EnemiesKilledWithArrow = reader.ReadInt32();
			playerUnlockData.EnemiesKilledWithGrenadeLauncher = reader.ReadInt32();
			playerUnlockData.EnemiesKilledWhileHangingFromRope = reader.ReadInt32();
			playerUnlockData.GrenadesCrafted = reader.ReadInt32();
			playerUnlockData.GrenadesLaunched = reader.ReadInt32();
			playerUnlockData.GrenadeLauncherCrafted = reader.ReadBoolean();
			playerUnlockData.HealedSelf = reader.ReadInt32();
			playerUnlockData.HealedOther = reader.ReadInt32();
			playerUnlockData.HowToRead = playerUnlockData.InitHowToUnlockData();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				playerUnlockData.ReadHowToUnlockData(reader, 190, playerUnlockData.HowToRead);
			}
			playerUnlockData.InvadersScore = reader.ReadInt32();
			int num2 = reader.ReadInt32();
			for (int j = 0; j < num2; j++)
			{
				playerUnlockData.KillStreamGamerID.Add(reader.ReadInt32());
			}
			playerUnlockData.PlayersSavedFromDeath = reader.ReadInt32();
			playerUnlockData.RastaFill = reader.ReadBoolean();
			playerUnlockData.RemotePlayersKilled = reader.ReadInt32();
			playerUnlockData.SaplingsPlanted = reader.ReadInt32();
			playerUnlockData.ThrownFishAtSleepingPlayer = reader.ReadBoolean();
			playerUnlockData.FlowersThrownAtEnemy = reader.ReadInt32();
			playerUnlockData.TreesChopped = reader.ReadInt32();
			playerUnlockData.SaplingsPlanted = reader.ReadInt32();
			playerUnlockData.WoodPlanksCrafted = reader.ReadInt32();
			playerUnlockData.TreasureChestsOpened = reader.ReadInt32();
			playerUnlockData.WorkbenchCrafted = reader.ReadBoolean();
			playerUnlockData.KilledDiablo = reader.ReadBoolean();
			playerUnlockData.EscapedToSurface = reader.ReadBoolean();
			playerUnlockData.HandyManUnlocked = reader.ReadBoolean();
			playerUnlockData.EntrepreneurUnlocked = reader.ReadBoolean();
			playerUnlockData.GoldenKnightUnlocked = reader.ReadBoolean();
			playerUnlockData.SageUnlocked = reader.ReadBoolean();
			playerUnlockData.ExplorerUnlocked = reader.ReadBoolean();
			playerUnlockData.ShopPurchase = reader.ReadBoolean();
			int num3 = reader.ReadInt32();
			for (int k = 0; k < num3; k++)
			{
				playerUnlockData.WorldsVisited.Add(reader.ReadInt32());
			}
			playerUnlockData.KingUnlocked = reader.ReadBoolean();
			playerUnlockData.ZuesPlaced = reader.ReadBoolean();
			playerUnlockData.BadBoy = (BadBoyType)reader.ReadByte();
			playerUnlockData.SurvivalDaysSurvived = reader.ReadInt32();
			playerUnlockData.ActionLog.ReadState(reader);
			return playerUnlockData;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00010BE0 File Offset: 0x0000EDE0
		public void WriteUnlockState(BinaryWriter writer)
		{
			writer.Write(this.ArrowsCrafted);
			writer.Write(this.KnightUnlocked);
			writer.Write(this.BlocksClearedWithWoodPick);
			writer.Write(this.BlueprintsFound);
			writer.Write(false);
			writer.Write(0);
			writer.Write(0);
			writer.Write(0);
			writer.Write(this.DetonationCount);
			writer.Write(this.EnemiesKilledWithArrow);
			writer.Write(this.EnemiesKilledWithGrenadeLauncher);
			writer.Write(this.EnemiesKilledWhileHangingFromRope);
			writer.Write(this.GrenadesCrafted);
			writer.Write(this.GrenadesLaunched);
			writer.Write(false);
			writer.Write(this.HealedSelf);
			writer.Write(this.HealedOther);
			writer.Write(this.HowToRead.Length);
			for (int i = 0; i < this.HowToRead.Length; i++)
			{
				writer.Write(i);
				writer.Write(this.HowToRead[i].Length);
				for (int j = 0; j < this.HowToRead[i].Length; j++)
				{
					writer.Write(this.HowToRead[i][j]);
				}
			}
			writer.Write(this.InvadersScore);
			writer.Write(this.KillStreamGamerID.Count);
			for (int k = 0; k < this.KillStreamGamerID.Count; k++)
			{
				writer.Write(this.KillStreamGamerID[k]);
			}
			writer.Write(this.PlayersSavedFromDeath);
			writer.Write(this.RastaFill);
			writer.Write(this.RemotePlayersKilled);
			writer.Write(this.SaplingsPlanted);
			writer.Write(this.ThrownFishAtSleepingPlayer);
			writer.Write(this.FlowersThrownAtEnemy);
			writer.Write(this.TreesChopped);
			writer.Write(this.SaplingsPlanted);
			writer.Write(this.WoodPlanksCrafted);
			writer.Write(this.TreasureChestsOpened);
			writer.Write(false);
			writer.Write(this.KilledDiablo);
			writer.Write(this.EscapedToSurface);
			writer.Write(this.HandyManUnlocked);
			writer.Write(this.EntrepreneurUnlocked);
			writer.Write(this.GoldenKnightUnlocked);
			writer.Write(this.SageUnlocked);
			writer.Write(this.ExplorerUnlocked);
			writer.Write(this.ShopPurchase);
			writer.Write(this.WorldsVisited.Count);
			for (int l = 0; l < this.WorldsVisited.Count; l++)
			{
				writer.Write(this.WorldsVisited[l]);
			}
			writer.Write(this.KingUnlocked);
			writer.Write(this.ZuesPlaced);
			writer.Write((byte)this.BadBoy);
			writer.Write(this.SurvivalDaysSurvived);
			this.ActionLog.WriteState(writer);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00010E98 File Offset: 0x0000F098
		private bool[][] InitHowToUnlockData()
		{
			bool[][] array = new bool[4][];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new bool[this.GetMaxHowToUnlockIDCount(i) + 1];
			}
			return array;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00010ECC File Offset: 0x0000F0CC
		private int GetMaxHowToUnlockIDCount(int i)
		{
			switch (i)
			{
			case 1:
				return 9;
			case 2:
				return 3;
			case 3:
				return 4;
			default:
				return -1;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00010EFC File Offset: 0x0000F0FC
		private void ReadHowToUnlockData(BinaryReader reader, int version, bool[][] howToData)
		{
			int num = reader.ReadInt32();
			int num2 = reader.ReadInt32();
			for (int i = 0; i < num2; i++)
			{
				if (num < howToData.Length && i < howToData[num].Length)
				{
					howToData[num][i] = reader.ReadBoolean();
				}
				else
				{
					reader.ReadBoolean();
				}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00010F45 File Offset: 0x0000F145
		public bool HasDoneAction(Item itemID, ItemAction action)
		{
			return this.ActionLog.HasAction(itemID, action);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00010F54 File Offset: 0x0000F154
		public bool IsPupilUnlocked()
		{
			foreach (bool[] array in this.HowToRead)
			{
				bool[] array2 = array;
				for (int j = 0; j < array2.Length; j++)
				{
					if (!array2[j])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00010F98 File Offset: 0x0000F198
		public void SetPupilUnlocked(bool unlocked)
		{
			for (int i = 0; i < this.HowToRead.Length; i++)
			{
				for (int j = 0; j < this.HowToRead[i].Length; j++)
				{
					this.HowToRead[i][j] = unlocked;
				}
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00010FD8 File Offset: 0x0000F1D8
		public bool IsChefUnlocked()
		{
			return this.AllItemsCooked();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		public void SetChefUnlocked(bool unlocked)
		{
			foreach (Blueprint blueprint in Globals.BlueprintData.BlueprintList)
			{
				if (unlocked)
				{
					if (Globals.ItemData.ArrayOfItemDataXML[(int)blueprint.Result.ItemID].ItemType == ItemType.Food && !this.HasDoneAction((Item)blueprint.Result.ItemID, ItemAction.Crafted))
					{
						this.ActionLog.AddAction((Item)blueprint.Result.ItemID, ItemAction.Crafted);
					}
				}
				else if (Globals.ItemData.ArrayOfItemDataXML[(int)blueprint.Result.ItemID].ItemType == ItemType.Food && this.HasDoneAction((Item)blueprint.Result.ItemID, ItemAction.Crafted))
				{
					this.ActionLog.RemoveAction((Item)blueprint.Result.ItemID, ItemAction.Crafted);
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000110C1 File Offset: 0x0000F2C1
		public bool IsHandymanUnlocked()
		{
			return this.AllItemsCrafted();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000110CC File Offset: 0x0000F2CC
		public void SetHandymanUnlocked(bool unlocked)
		{
			foreach (Blueprint blueprint in Globals.BlueprintData.BlueprintList)
			{
				if (unlocked)
				{
					if (blueprint.CraftType == BlueprintCraftType.Crafting && !this.HasDoneAction((Item)blueprint.Result.ItemID, ItemAction.Crafted))
					{
						this.ActionLog.AddAction((Item)blueprint.Result.ItemID, ItemAction.Crafted);
					}
				}
				else if (blueprint.CraftType == BlueprintCraftType.Crafting && this.HasDoneAction((Item)blueprint.Result.ItemID, ItemAction.Crafted))
				{
					this.ActionLog.RemoveAction((Item)blueprint.Result.ItemID, ItemAction.Crafted);
				}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00011178 File Offset: 0x0000F378
		private bool AllItemsCrafted()
		{
			foreach (Blueprint blueprint in Globals.BlueprintData.BlueprintList)
			{
				if (blueprint.CraftType == BlueprintCraftType.Crafting && !this.HasDoneAction((Item)blueprint.Result.ItemID, ItemAction.Crafted))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000111C4 File Offset: 0x0000F3C4
		private bool AllItemsCooked()
		{
			foreach (Blueprint blueprint in Globals.BlueprintData.BlueprintList)
			{
				if (Globals.ItemData.ArrayOfItemDataXML[(int)blueprint.Result.ItemID].ItemType == ItemType.Food && !this.HasDoneAction((Item)blueprint.Result.ItemID, ItemAction.Crafted))
				{
					return false;
				}
			}
			return true;
		}
	}
}
