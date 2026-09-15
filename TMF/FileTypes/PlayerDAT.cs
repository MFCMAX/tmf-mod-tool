using System;
using System.Collections.Generic;
using System.IO;
using TMF.Enums;
using TMF.Structs;
using TMF.Structs.EntityStructs;
using TMF.Structs.OtherStructs;
using TMF.Utils;

namespace TMF.FileTypes
{
	// Token: 0x02000051 RID: 81
	public class PlayerDAT
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00013A31 File Offset: 0x00011C31
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00013A39 File Offset: 0x00011C39
		public List<SavePlayerState> Players { get; set; }

		// Token: 0x060002FB RID: 763 RVA: 0x00013A44 File Offset: 0x00011C44
		public void WriteData(Stream xOut)
		{
			BinaryWriter binaryWriter = new BinaryWriter(xOut);
			binaryWriter.Write(this.Players.Count);
			int i = 0;
			while (i < this.Players.Count)
			{
				SavePlayerState savePlayerState = this.Players[i];
				savePlayerState.WriteBaseState(binaryWriter);
				binaryWriter.Write(savePlayerState.ViewAngle.X);
				binaryWriter.Write(savePlayerState.ViewAngle.Y);
				binaryWriter.Write(savePlayerState.Oxygen);
				binaryWriter.Write((ushort)savePlayerState.Permission);
				ReadingUtils.WriteGamertag(binaryWriter, savePlayerState.Gamertag);
				binaryWriter.Write(savePlayerState.IsNewPlayer);
				binaryWriter.Write(savePlayerState.JetPackActive);
				binaryWriter.Write(savePlayerState.CraftInstructionMessageShown);
				binaryWriter.Write(savePlayerState.NewComPackMessageShown);
				binaryWriter.Write(savePlayerState.Message4);
				binaryWriter.Write(savePlayerState.LastTransmitterFrequency);
				binaryWriter.Write(savePlayerState.RatingStars);
				binaryWriter.Write(savePlayerState.GoldEarned);
				binaryWriter.Write(savePlayerState.ScrollsFound);
				binaryWriter.Write(savePlayerState.BedRockProspected);
				binaryWriter.Write(savePlayerState.EnemiesKilledBeforeBedRock);
				binaryWriter.Write(savePlayerState.ItemsCrafted.Length);
				int j = 0;
				while (j < savePlayerState.ItemsCrafted.Length)
				{
					binaryWriter.Write(savePlayerState.ItemsCrafted[j]);
					i++;
				}
				binaryWriter.Write(savePlayerState.Settings.GamePadSensitivity);
				binaryWriter.Write(savePlayerState.Settings.FOVNormalized);
				binaryWriter.Write(savePlayerState.Settings.HudVisible);
				binaryWriter.Write(savePlayerState.Settings.MapVisible);
				binaryWriter.Write(savePlayerState.Settings.RumbleOn);
				binaryWriter.Write((byte)savePlayerState.Settings.NamePlateSetting);
				binaryWriter.Write(savePlayerState.Settings.InvertY);
				binaryWriter.Write(savePlayerState.Settings.BlueprintFinderVisible);
				binaryWriter.Write(savePlayerState.Settings.AutoplaceTime);
				binaryWriter.Write(savePlayerState.Settings.HotBarToTransparentTime);
				binaryWriter.Write(savePlayerState.Settings.DisplayXPGains);
				binaryWriter.Write(false);
				binaryWriter.Write(0f);
				binaryWriter.Write(savePlayerState.Settings.MobNameplates);
				binaryWriter.Write((byte)savePlayerState.Settings.CameraType);
				binaryWriter.Write((byte)savePlayerState.Settings.UserControlSetting);
				binaryWriter.Write(savePlayerState.Stats.SecondsPlayed);
				binaryWriter.Write(savePlayerState.Stats.DistanceWalked);
				binaryWriter.Write(savePlayerState.Stats.DistanceFlown);
				binaryWriter.Write(savePlayerState.Stats.BlocksCleared);
				binaryWriter.Write(savePlayerState.Stats.BlocksPlaced);
				binaryWriter.Write(savePlayerState.Stats.BlocksPickedUp);
				binaryWriter.Write(savePlayerState.Stats.ItemsPickedUp);
				binaryWriter.Write(savePlayerState.Stats.DamageDealt);
				binaryWriter.Write(savePlayerState.Stats.DamageTaken);
				binaryWriter.Write(savePlayerState.Stats.TotalKills);
				binaryWriter.Write(savePlayerState.Stats.TotalDeaths);
				binaryWriter.Write(savePlayerState.Stats.PlayerKills);
				binaryWriter.Write(savePlayerState.Stats.NPCKills);
				binaryWriter.Write(savePlayerState.Stats.LootValue);
				binaryWriter.Write(savePlayerState.Stats.GrenadesLaunched);
				binaryWriter.Write(savePlayerState.Stats.FillerInt1);
				binaryWriter.Write(savePlayerState.Stats.FillerInt2);
				binaryWriter.Write(savePlayerState.Stats.FillerInt3);
				binaryWriter.Write(savePlayerState.Stats.FillerInt4);
				binaryWriter.Write(savePlayerState.Stats.FillerInt5);
				binaryWriter.Write(savePlayerState.Stats.FillerInt6);
				binaryWriter.Write(savePlayerState.Stats.FillerInt7);
				binaryWriter.Write(savePlayerState.Stats.FillerInt8);
				binaryWriter.Write(savePlayerState.Stats.FillerInt9);
				binaryWriter.Write(savePlayerState.Stats.FillerInt10);
				binaryWriter.Write(savePlayerState.Stats.FillerFloat1);
				binaryWriter.Write(savePlayerState.Stats.FillerFloat2);
				binaryWriter.Write(savePlayerState.Stats.FillerFloat3);
				binaryWriter.Write(savePlayerState.Stats.FillerFloat4);
				binaryWriter.Write(savePlayerState.Stats.FillerFloat5);
				if (savePlayerState.WayPoint != null)
				{
					binaryWriter.Write(savePlayerState.WayPoint.X);
					binaryWriter.Write(savePlayerState.WayPoint.Z);
				}
				else
				{
					binaryWriter.Write(-1);
				}
				if (savePlayerState.DefaultPriceList == null)
				{
					binaryWriter.Write(0);
				}
				else
				{
					binaryWriter.Write(savePlayerState.DefaultPriceList.Prices.Length);
					for (int k = 0; k < savePlayerState.DefaultPriceList.Prices.Length; k++)
					{
						binaryWriter.Write(savePlayerState.DefaultPriceList.Prices[k].Buy);
						binaryWriter.Write(savePlayerState.DefaultPriceList.Prices[k].Sell);
						binaryWriter.Write(savePlayerState.DefaultPriceList.Prices[k].Perc);
						binaryWriter.Write(savePlayerState.DefaultPriceList.Prices[k].UsePerc);
						binaryWriter.Write(savePlayerState.DefaultPriceList.Prices[k].ForSale);
					}
				}
				if (savePlayerState.History != null && savePlayerState.History.Table != null)
				{
					binaryWriter.Write(savePlayerState.History.Table.Count);
					using (Dictionary<string, int>.Enumerator enumerator = savePlayerState.History.Table.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, int> keyValuePair = enumerator.Current;
							binaryWriter.Write(keyValuePair.Key);
							binaryWriter.Write(keyValuePair.Value);
						}
						goto IL_5BC;
					}
					goto IL_5B5;
				}
				goto IL_5B5;
				IL_5BC:
				savePlayerState.ActionLog.WriteState(binaryWriter);
				i++;
				continue;
				IL_5B5:
				binaryWriter.Write(0);
				goto IL_5BC;
			}
			Encryption.WriteHashToStream(xOut);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00014044 File Offset: 0x00012244
		public static PlayerDAT ReadPlayerData(Stream xIn)
		{
			PlayerDAT playerDAT = new PlayerDAT();
			BinaryReader binaryReader = new BinaryReader(xIn);
			int num = binaryReader.ReadInt32();
			playerDAT.Players = new List<SavePlayerState>();
			for (int i = 0; i < num; i++)
			{
				SavePlayerState savePlayerState = new SavePlayerState();
				savePlayerState.ReadBaseState(binaryReader);
				savePlayerState.ViewAngle = new Vector2
				{
					X = binaryReader.ReadSingle(),
					Y = binaryReader.ReadSingle()
				};
				savePlayerState.Oxygen = binaryReader.ReadSingle();
				savePlayerState.Permission = (Permissions)binaryReader.ReadUInt16();
				savePlayerState.Gamertag = ReadingUtils.ReadGamertag(binaryReader);
				savePlayerState.IsNewPlayer = binaryReader.ReadBoolean();
				savePlayerState.JetPackActive = binaryReader.ReadBoolean();
				savePlayerState.CraftInstructionMessageShown = binaryReader.ReadBoolean();
				savePlayerState.NewComPackMessageShown = binaryReader.ReadBoolean();
				savePlayerState.Message4 = binaryReader.ReadBoolean();
				savePlayerState.LastTransmitterFrequency = binaryReader.ReadInt32();
				savePlayerState.RatingStars = binaryReader.ReadByte();
				savePlayerState.GoldEarned = binaryReader.ReadInt32();
				savePlayerState.ScrollsFound = binaryReader.ReadInt32();
				savePlayerState.BedRockProspected = binaryReader.ReadBoolean();
				savePlayerState.EnemiesKilledBeforeBedRock = binaryReader.ReadInt32();
				savePlayerState.ItemsCrafted = new ushort[binaryReader.ReadInt32()];
				for (int j = 0; j < savePlayerState.ItemsCrafted.Length; j++)
				{
					savePlayerState.ItemsCrafted[i] = binaryReader.ReadUInt16();
				}
				savePlayerState.Settings = new PlayerSettings();
				savePlayerState.Settings.GamePadSensitivity = binaryReader.ReadSingle();
				savePlayerState.Settings.FOVNormalized = binaryReader.ReadSingle();
				savePlayerState.Settings.HudVisible = binaryReader.ReadBoolean();
				savePlayerState.Settings.MapVisible = binaryReader.ReadBoolean();
				savePlayerState.Settings.RumbleOn = binaryReader.ReadBoolean();
				savePlayerState.Settings.NamePlateSetting = (NamePlateSetting)binaryReader.ReadByte();
				savePlayerState.Settings.InvertY = binaryReader.ReadBoolean();
				savePlayerState.Settings.BlueprintFinderVisible = binaryReader.ReadBoolean();
				savePlayerState.Settings.AutoplaceTime = binaryReader.ReadSingle();
				savePlayerState.Settings.HotBarToTransparentTime = binaryReader.ReadByte();
				savePlayerState.Settings.DisplayXPGains = binaryReader.ReadBoolean();
				binaryReader.ReadBoolean();
				binaryReader.ReadSingle();
				savePlayerState.Settings.MobNameplates = binaryReader.ReadBoolean();
				savePlayerState.Settings.CameraType = (CameraType)binaryReader.ReadByte();
				savePlayerState.Settings.UserControlSetting = (UserControlSetting)binaryReader.ReadByte();
				savePlayerState.Stats = new PlayerStats
				{
					SecondsPlayed = binaryReader.ReadDouble(),
					DistanceWalked = binaryReader.ReadSingle(),
					DistanceFlown = binaryReader.ReadSingle(),
					BlocksCleared = binaryReader.ReadInt32(),
					BlocksPlaced = binaryReader.ReadInt32(),
					BlocksPickedUp = binaryReader.ReadInt32(),
					ItemsPickedUp = binaryReader.ReadInt32(),
					DamageDealt = (float)binaryReader.ReadInt32(),
					DamageTaken = (float)binaryReader.ReadInt32(),
					TotalKills = binaryReader.ReadInt32(),
					TotalDeaths = binaryReader.ReadInt32(),
					PlayerKills = binaryReader.ReadInt32(),
					NPCKills = binaryReader.ReadInt32(),
					LootValue = binaryReader.ReadInt32(),
					GrenadesLaunched = binaryReader.ReadInt32(),
					FillerInt1 = binaryReader.ReadInt32(),
					FillerInt2 = binaryReader.ReadInt32(),
					FillerInt3 = binaryReader.ReadInt32(),
					FillerInt4 = binaryReader.ReadInt32(),
					FillerInt5 = binaryReader.ReadInt32(),
					FillerInt6 = binaryReader.ReadInt32(),
					FillerInt7 = binaryReader.ReadInt32(),
					FillerInt8 = binaryReader.ReadInt32(),
					FillerInt9 = binaryReader.ReadInt32(),
					FillerInt10 = binaryReader.ReadInt32(),
					FillerFloat1 = binaryReader.ReadSingle(),
					FillerFloat2 = binaryReader.ReadSingle(),
					FillerFloat3 = binaryReader.ReadSingle(),
					FillerFloat4 = binaryReader.ReadSingle(),
					FillerFloat5 = binaryReader.ReadSingle()
				};
				int num2 = binaryReader.ReadInt32();
				if (num2 >= 0)
				{
					savePlayerState.WayPoint = new GlobalPoint3D
					{
						X = num2,
						Z = binaryReader.ReadInt32()
					};
				}
				else
				{
					savePlayerState.WayPoint = null;
				}
				savePlayerState.DefaultPriceList = PriceList.ReadPriceList(binaryReader);
				num2 = binaryReader.ReadInt32();
				savePlayerState.History = new History();
				for (int k = 0; k < num2; k++)
				{
					string key = binaryReader.ReadString();
					int value = binaryReader.ReadInt32();
					savePlayerState.History.Table.Add(key, value);
				}
				savePlayerState.ActionLog = new ActionLog();
				savePlayerState.ActionLog.ReadState(binaryReader);
				playerDAT.Players.Add(savePlayerState);
			}
			return playerDAT;
		}
	}
}
