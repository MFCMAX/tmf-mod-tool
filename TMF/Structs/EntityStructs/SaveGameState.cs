using System;
using System.Collections.Generic;
using System.IO;
using TMF.Enums;
using TMF.Structs.MapStructs;
using TMF.Structs.OtherStructs;
using TMF.Utils;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x0200004F RID: 79
	public class SaveGameState
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0001297B File Offset: 0x00010B7B
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00012983 File Offset: 0x00010B83
		public float SoundVolume { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0001298C File Offset: 0x00010B8C
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00012994 File Offset: 0x00010B94
		public float MusicVolume { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0001299D File Offset: 0x00010B9D
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x000129A5 File Offset: 0x00010BA5
		public float ViewDistance { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x000129AE File Offset: 0x00010BAE
		// (set) Token: 0x060002BA RID: 698 RVA: 0x000129B6 File Offset: 0x00010BB6
		public ShaderDetail ShaderDetail { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002BB RID: 699 RVA: 0x000129BF File Offset: 0x00010BBF
		// (set) Token: 0x060002BC RID: 700 RVA: 0x000129C7 File Offset: 0x00010BC7
		public bool UseMipMaps { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002BD RID: 701 RVA: 0x000129D0 File Offset: 0x00010BD0
		// (set) Token: 0x060002BE RID: 702 RVA: 0x000129D8 File Offset: 0x00010BD8
		public float TextureSmoothing { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002BF RID: 703 RVA: 0x000129E1 File Offset: 0x00010BE1
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x000129E9 File Offset: 0x00010BE9
		public AutoSaveSetting AutoSave { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000129F2 File Offset: 0x00010BF2
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000129FA File Offset: 0x00010BFA
		public NotificationType Notifications { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00012A03 File Offset: 0x00010C03
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00012A0B File Offset: 0x00010C0B
		public byte MaxConcurrentPlayerCount { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00012A14 File Offset: 0x00010C14
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00012A1C File Offset: 0x00010C1C
		public double TotalGameTime { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00012A25 File Offset: 0x00010C25
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00012A2D File Offset: 0x00010C2D
		public float SunRotation { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00012A36 File Offset: 0x00010C36
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00012A3E File Offset: 0x00010C3E
		public int PlayerCount { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00012A47 File Offset: 0x00010C47
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00012A4F File Offset: 0x00010C4F
		public int LastTransmitterFrequency { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00012A58 File Offset: 0x00010C58
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00012A60 File Offset: 0x00010C60
		public BlueprintState[] Blueprints { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00012A69 File Offset: 0x00010C69
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00012A71 File Offset: 0x00010C71
		public WisdomScrollState[] Scrolls { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00012A7A File Offset: 0x00010C7A
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00012A82 File Offset: 0x00010C82
		public List<SaveZoneState> Zones { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00012A8B File Offset: 0x00010C8B
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00012A93 File Offset: 0x00010C93
		public List<SaveBookState> Books { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00012A9C File Offset: 0x00010C9C
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00012AA4 File Offset: 0x00010CA4
		public bool[] LockedTable { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00012AAD File Offset: 0x00010CAD
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00012AB5 File Offset: 0x00010CB5
		public List<SaveItemParticle> Particles { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00012ABE File Offset: 0x00010CBE
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00012AC6 File Offset: 0x00010CC6
		public FloodData[] FloodUpdates { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00012ACF File Offset: 0x00010CCF
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00012AD7 File Offset: 0x00010CD7
		public Block[,] BlockTextures { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00012AE0 File Offset: 0x00010CE0
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00012AE8 File Offset: 0x00010CE8
		public MapMarker[] MapMarkers { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00012AF1 File Offset: 0x00010CF1
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00012AF9 File Offset: 0x00010CF9
		public SaveInventoryState SpawnInventory { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00012B02 File Offset: 0x00010D02
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00012B0A File Offset: 0x00010D0A
		public List<Script> Scripts { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00012B13 File Offset: 0x00010D13
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00012B1B File Offset: 0x00010D1B
		public List<SaveTeleportState> Teleports { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00012B24 File Offset: 0x00010D24
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00012B2C File Offset: 0x00010D2C
		public History History { get; set; }

		// Token: 0x060002E7 RID: 743 RVA: 0x00012B38 File Offset: 0x00010D38
		public static SaveGameState ReadSaveGameState(BinaryReader reader)
		{
			SaveGameState saveGameState = new SaveGameState();
			saveGameState.SoundVolume = reader.ReadSingle();
			saveGameState.MusicVolume = reader.ReadSingle();
			saveGameState.ViewDistance = reader.ReadSingle();
			saveGameState.ShaderDetail = (ShaderDetail)reader.ReadByte();
			saveGameState.UseMipMaps = reader.ReadBoolean();
			saveGameState.TextureSmoothing = reader.ReadSingle();
			saveGameState.AutoSave = (AutoSaveSetting)reader.ReadByte();
			saveGameState.Notifications = (NotificationType)reader.ReadByte();
			saveGameState.MaxConcurrentPlayerCount = reader.ReadByte();
			ReadingUtils.ReadRandBuffer(reader);
			saveGameState.TotalGameTime = reader.ReadDouble();
			saveGameState.SunRotation = reader.ReadSingle();
			saveGameState.PlayerCount = reader.ReadInt32();
			saveGameState.LastTransmitterFrequency = reader.ReadInt32();
			saveGameState.Blueprints = SaveGameState.ReadBlueprintData(reader);
			saveGameState.Scrolls = SaveGameState.ReadWisdomScrollData(reader);
			saveGameState.Zones = SaveGameState.ReadZoneData(reader);
			saveGameState.Books = SaveGameState.ReadBookData(reader);
			saveGameState.LockedTable = SaveGameState.ReadLockedTableData(reader);
			saveGameState.Particles = SaveGameState.ReadParticleData(reader);
			saveGameState.FloodUpdates = SaveGameState.ReadFloodDataArray(reader);
			saveGameState.BlockTextures = SaveGameState.ReadBlockTextures(reader);
			saveGameState.MapMarkers = SaveGameState.ReadMapMarkers(reader);
			saveGameState.SpawnInventory = SaveInventoryState.ReadInventory(reader);
			saveGameState.Scripts = SaveGameState.ReadScripts(reader);
			saveGameState.Teleports = SaveGameState.ReadTeleportData(reader);
			saveGameState.History = SaveGameState.ReadHistoryData(reader);
			return saveGameState;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00012C8C File Offset: 0x00010E8C
		public void WriteState(BinaryWriter writer)
		{
			writer.Write(this.SoundVolume);
			writer.Write(this.MusicVolume);
			writer.Write(this.ViewDistance);
			writer.Write((byte)this.ShaderDetail);
			writer.Write(this.UseMipMaps);
			writer.Write(this.TextureSmoothing);
			writer.Write((byte)this.AutoSave);
			writer.Write((byte)this.Notifications);
			writer.Write(this.MaxConcurrentPlayerCount);
			ReadingUtils.WriteRandBuffer(writer, 8);
			writer.Write(this.TotalGameTime);
			writer.Write(this.SunRotation);
			writer.Write(this.PlayerCount);
			writer.Write(this.LastTransmitterFrequency);
			writer.Write(this.Blueprints.Length);
			for (int i = 0; i < this.Blueprints.Length; i++)
			{
				BlueprintState blueprintState = this.Blueprints[i];
				blueprintState.IsUnearthed = blueprintState.IsEnabled;
				writer.Write(blueprintState.IsUnearthed);
				writer.Write(blueprintState.IsUnearthed);
				writer.Write(blueprintState.IsGenerated);
				writer.Write(blueprintState.Point.X);
				writer.Write(blueprintState.Point.Y);
				writer.Write(blueprintState.Point.Z);
			}
			writer.Write(this.Scrolls.Length);
			for (int j = 0; j < this.Scrolls.Length; j++)
			{
				writer.Write(this.Scrolls[j].IsEnabled);
			}
			writer.Write(this.Zones.Count);
			foreach (SaveZoneState state in this.Zones)
			{
				SaveGameState.WriteZoneData(writer, state);
			}
			writer.Write(this.Books.Count);
			foreach (SaveBookState state2 in this.Books)
			{
				SaveGameState.WriteBookData(writer, state2);
			}
			writer.Write(this.LockedTable.Length);
			for (int k = 0; k < this.LockedTable.Length; k++)
			{
				writer.Write(this.LockedTable[k]);
			}
			writer.Write(this.Particles.Count);
			foreach (SaveItemParticle saveItemParticle in this.Particles)
			{
				writer.Write(saveItemParticle.Item.ItemID);
				writer.Write(saveItemParticle.Item.Count);
				writer.Write(saveItemParticle.Item.Durability);
				writer.Write(saveItemParticle.Position.X);
				writer.Write(saveItemParticle.Position.Y);
				writer.Write(saveItemParticle.Position.Z);
			}
			writer.Write(0);
			writer.Write(this.BlockTextures.GetLength(0));
			writer.Write(this.BlockTextures.GetLength(1));
			for (int l = 0; l < this.BlockTextures.GetLength(0); l++)
			{
				for (int m = 0; m < this.BlockTextures.GetLength(1); m++)
				{
					writer.Write((byte)this.BlockTextures[l, m]);
				}
			}
			writer.Write(this.MapMarkers.Length);
			List<MapMarker> list = new List<MapMarker>();
			list.AddRange(this.MapMarkers);
			foreach (MapMarker mapMarker in list)
			{
				writer.Write(mapMarker.Point.X);
				writer.Write(mapMarker.Point.Y);
				writer.Write(mapMarker.Point.Z);
				writer.Write((byte)mapMarker.Type);
				writer.Write((mapMarker.Label != null) ? mapMarker.Label : "");
			}
			this.SpawnInventory.Write(writer);
			writer.Write(this.Scripts.Count);
			for (int n = 0; n < this.Scripts.Count; n++)
			{
				writer.Write(this.Scripts[n].Name);
				ReadingUtils.WriteStringList(writer, this.Scripts[n].Commands);
			}
			writer.Write(this.Teleports.Count);
			foreach (SaveTeleportState saveTeleportState in this.Teleports)
			{
				writer.Write((short)saveTeleportState.Point.X);
				writer.Write((short)saveTeleportState.Point.Y);
				writer.Write((short)saveTeleportState.Point.Z);
				writer.Write(saveTeleportState.Channel);
			}
			writer.Write(this.History.Table.Count);
			foreach (KeyValuePair<string, int> keyValuePair in this.History.Table)
			{
				writer.Write(keyValuePair.Key);
				writer.Write(keyValuePair.Value);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001324C File Offset: 0x0001144C
		private static void WriteBookData(BinaryWriter writer, SaveBookState state)
		{
			writer.Write(state.ID);
			writer.Write((state.Title == null) ? "" : state.Title);
			writer.Write((state.Text == null) ? 0 : state.Text.Length);
			for (int i = 0; i < state.Text.Length; i++)
			{
				writer.Write((state.Text[i] == null) ? "" : state.Text[i]);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000132CC File Offset: 0x000114CC
		private static void WriteZoneData(BinaryWriter writer, SaveZoneState state)
		{
			writer.Write(state.Label);
			writer.Write((byte)state.Type);
			writer.Write(state.Min.X);
			writer.Write(state.Min.Y);
			writer.Write(state.Min.Z);
			writer.Write(state.Max.X);
			writer.Write(state.Max.Y);
			writer.Write(state.Max.Z);
			ReadingUtils.WriteGamertag(writer, (state.Builder == null) ? "" : state.Builder);
			writer.Write((state.OnEntryScript == null) ? "" : state.OnEntryScript);
			writer.Write((state.OnExitScript == null) ? "" : state.OnExitScript);
			writer.Write(state.CombatLevelDifference);
			writer.Write(state.SpeedMultiplier);
			writer.Write(state.GravityMultiplier);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000133CC File Offset: 0x000115CC
		private static List<SaveTeleportState> ReadTeleportData(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			List<SaveTeleportState> list = new List<SaveTeleportState>();
			for (int i = 0; i < num; i++)
			{
				list.Add(new SaveTeleportState
				{
					Point = new GlobalPoint3D
					{
						X = (int)reader.ReadInt16(),
						Y = (int)reader.ReadInt16(),
						Z = (int)reader.ReadInt16()
					},
					Channel = reader.ReadByte()
				});
			}
			return list;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00013444 File Offset: 0x00011644
		private static History ReadHistoryData(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			History history = new History();
			for (int i = 0; i < num; i++)
			{
				history.Table.Add(reader.ReadString(), reader.ReadInt32());
			}
			return history;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00013484 File Offset: 0x00011684
		private static List<Script> ReadScripts(BinaryReader reader)
		{
			List<Script> list = new List<Script>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(new Script
				{
					Name = reader.ReadString(),
					Commands = ReadingUtils.ReadStringList(reader)
				});
			}
			return list;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000134D0 File Offset: 0x000116D0
		private static MapMarker[] ReadMapMarkers(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			MapMarker[] array = new MapMarker[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new MapMarker
				{
					Point = new GlobalPoint3D
					{
						X = reader.ReadInt32(),
						Y = reader.ReadInt32(),
						Z = reader.ReadInt32()
					},
					Type = (MapMarkerType)reader.ReadByte(),
					Label = reader.ReadString()
				};
			}
			return array;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00013550 File Offset: 0x00011750
		private static Block[,] ReadBlockTextures(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			int num2 = reader.ReadInt32();
			Block[,] array = new Block[num, num2];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					array[i, j] = (Block)reader.ReadByte();
				}
			}
			array[8, 0] = Block.None;
			array[9, 0] = Block.None;
			array[11, 0] = Block.None;
			return array;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000135BC File Offset: 0x000117BC
		private static FloodData[] ReadFloodDataArray(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			FloodData[] result = new FloodData[num];
			for (int i = 0; i < num; i++)
			{
				FloodData floodData = new FloodData();
				floodData.BlockID = (Block)reader.ReadByte();
				floodData.Method = (UpdateBlockMethod)reader.ReadByte();
				floodData.Gamertag = reader.ReadString();
				floodData.FloodPoints = new GlobalPoint3D[reader.ReadInt32()];
				byte[] array = new byte[floodData.FloodPoints.Length * 6];
				reader.Read(array, 0, array.Length);
				int num2 = 0;
				for (int j = 0; j < floodData.FloodPoints.Length; j++)
				{
					GlobalPoint3D globalPoint3D = new GlobalPoint3D();
					globalPoint3D.X = (int)((ushort)((int)array[num2++] + (int)array[num2++] * 256));
					globalPoint3D.Y = (int)((ushort)((int)array[num2++] + (int)array[num2++] * 256));
					globalPoint3D.Z = (int)((ushort)((int)array[num2++] + (int)array[num2++] * 256));
					floodData.FloodPoints[j] = globalPoint3D;
				}
			}
			return result;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000136E0 File Offset: 0x000118E0
		private static List<SaveItemParticle> ReadParticleData(BinaryReader reader)
		{
			List<SaveItemParticle> list = new List<SaveItemParticle>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(new SaveItemParticle
				{
					Item = new SaveInventoryItem
					{
						ItemID = reader.ReadUInt16(),
						Count = reader.ReadInt32(),
						Durability = reader.ReadUInt16()
					},
					Position = new Vector3
					{
						X = reader.ReadSingle(),
						Y = reader.ReadSingle(),
						Z = reader.ReadSingle()
					}
				});
			}
			return list;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00013784 File Offset: 0x00011984
		private static bool[] ReadLockedTableData(BinaryReader reader)
		{
			bool[] array = new bool[Globals.ItemData.ArrayOfItemDataXML.Length];
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				bool flag = reader.ReadBoolean();
				if (i < array.Length)
				{
					array[i] = flag;
				}
			}
			return array;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000137C8 File Offset: 0x000119C8
		private static List<SaveBookState> ReadBookData(BinaryReader reader)
		{
			int num = reader.ReadInt32();
			List<SaveBookState> list = new List<SaveBookState>();
			for (int i = 0; i < num; i++)
			{
				list.Add(SaveGameState.ReadBookState(reader));
			}
			return list;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000137FC File Offset: 0x000119FC
		private static SaveBookState ReadBookState(BinaryReader reader)
		{
			SaveBookState saveBookState = new SaveBookState();
			saveBookState.ID = reader.ReadUInt16();
			saveBookState.Title = reader.ReadString();
			int num = reader.ReadInt32();
			saveBookState.Text = new string[num];
			for (int i = 0; i < num; i++)
			{
				saveBookState.Text[i] = reader.ReadString();
			}
			return saveBookState;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00013858 File Offset: 0x00011A58
		private static WisdomScrollState[] ReadWisdomScrollData(BinaryReader reader)
		{
			WisdomScrollState[] array = new WisdomScrollState[reader.ReadInt32()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new WisdomScrollState
				{
					IsEnabled = reader.ReadBoolean()
				};
			}
			return array;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00013898 File Offset: 0x00011A98
		private static List<SaveZoneState> ReadZoneData(BinaryReader reader)
		{
			List<SaveZoneState> list = new List<SaveZoneState>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				list.Add(new SaveZoneState
				{
					Label = reader.ReadString(),
					Type = (ZoneType)reader.ReadByte(),
					Min = new GlobalPoint3D
					{
						X = reader.ReadInt32(),
						Y = reader.ReadInt32(),
						Z = reader.ReadInt32()
					},
					Max = new GlobalPoint3D
					{
						X = reader.ReadInt32(),
						Y = reader.ReadInt32(),
						Z = reader.ReadInt32()
					},
					Builder = ReadingUtils.ReadGamertag(reader),
					OnEntryScript = reader.ReadString(),
					OnExitScript = reader.ReadString(),
					CombatLevelDifference = reader.ReadInt16(),
					SpeedMultiplier = reader.ReadSingle(),
					GravityMultiplier = reader.ReadSingle()
				});
			}
			return list;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000139A0 File Offset: 0x00011BA0
		private static BlueprintState[] ReadBlueprintData(BinaryReader reader)
		{
			BlueprintState[] array = new BlueprintState[reader.ReadInt32()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new BlueprintState
				{
					IsEnabled = reader.ReadBoolean(),
					IsUnearthed = reader.ReadBoolean(),
					IsGenerated = reader.ReadBoolean(),
					Point = 
					{
						X = reader.ReadInt32(),
						Y = reader.ReadInt32(),
						Z = reader.ReadInt32()
					}
				};
			}
			return array;
		}
	}
}
