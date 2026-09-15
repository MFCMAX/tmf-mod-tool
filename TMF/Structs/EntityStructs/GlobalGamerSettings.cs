using System;
using System.IO;
using TMF.Enums;

namespace TMF.Structs.EntityStructs
{
	// Token: 0x02000041 RID: 65
	public class GlobalGamerSettings
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		public bool GlobalOverwrite { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00011BF1 File Offset: 0x0000FDF1
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00011BF9 File Offset: 0x0000FDF9
		public PlayerSettings PlayerSettings { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00011C02 File Offset: 0x0000FE02
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00011C0A File Offset: 0x0000FE0A
		public GameSettings GameSettings { get; set; }

		// Token: 0x0600024C RID: 588 RVA: 0x00011C13 File Offset: 0x0000FE13
		public GlobalGamerSettings()
		{
			this.PlayerSettings = new PlayerSettings();
			this.GameSettings = new GameSettings();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00011C34 File Offset: 0x0000FE34
		public static GlobalGamerSettings ReadSettings(BinaryReader reader)
		{
			return new GlobalGamerSettings
			{
				GlobalOverwrite = reader.ReadBoolean(),
				PlayerSettings = 
				{
					GamePadSensitivity = reader.ReadSingle(),
					FOVNormalized = reader.ReadSingle(),
					RumbleOn = reader.ReadBoolean(),
					DisplayXPGains = reader.ReadBoolean(),
					InvertY = reader.ReadBoolean(),
					AutoplaceTime = reader.ReadSingle(),
					HotBarToTransparentTime = reader.ReadByte(),
					CameraType = (CameraType)reader.ReadByte(),
					UserControlSetting = (UserControlSetting)reader.ReadByte(),
					CompassTop = reader.ReadBoolean(),
					MobType = (MobType)reader.ReadByte()
				},
				GameSettings = 
				{
					AutoSave = (AutoSaveSetting)reader.ReadByte(),
					ShaderDetail = (ShaderDetail)reader.ReadByte(),
					SoundVolume = reader.ReadSingle(),
					MusicVolume = reader.ReadSingle(),
					ViewClouds = reader.ReadBoolean(),
					UseMipMaps = reader.ReadBoolean(),
					OldSkoolLight = reader.ReadBoolean(),
					Notifications = (NotificationType)reader.ReadByte(),
					SplitScreenVertical = reader.ReadBoolean(),
					TextureSmoothing = reader.ReadSingle(),
					ViewDistance = reader.ReadSingle(),
					TexturePack = reader.ReadString(),
					WindowBorder = reader.ReadString()
				}
			};
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00011DEC File Offset: 0x0000FFEC
		public void WriteData(BinaryWriter writer)
		{
			writer.Write(this.GlobalOverwrite);
			writer.Write(this.PlayerSettings.GamePadSensitivity);
			writer.Write(this.PlayerSettings.FOVNormalized);
			writer.Write(this.PlayerSettings.RumbleOn);
			writer.Write(this.PlayerSettings.DisplayXPGains);
			writer.Write(this.PlayerSettings.InvertY);
			writer.Write(this.PlayerSettings.AutoplaceTime);
			writer.Write(this.PlayerSettings.HotBarToTransparentTime);
			writer.Write((byte)this.PlayerSettings.CameraType);
			writer.Write((byte)this.PlayerSettings.UserControlSetting);
			writer.Write(this.PlayerSettings.CompassTop);
			writer.Write((byte)this.PlayerSettings.MobType);
			writer.Write((byte)this.GameSettings.AutoSave);
			writer.Write((byte)this.GameSettings.ShaderDetail);
			writer.Write(this.GameSettings.SoundVolume);
			writer.Write(this.GameSettings.MusicVolume);
			writer.Write(this.GameSettings.ViewClouds);
			writer.Write(this.GameSettings.UseMipMaps);
			writer.Write(this.GameSettings.OldSkoolLight);
			writer.Write((byte)this.GameSettings.Notifications);
			writer.Write(this.GameSettings.SplitScreenVertical);
			writer.Write(this.GameSettings.TextureSmoothing);
			writer.Write(this.GameSettings.ViewDistance);
			writer.Write(this.GameSettings.TexturePack);
			writer.Write(this.GameSettings.WindowBorder);
		}
	}
}
