using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TMF.Structs.EntityStructs;

namespace TMF_Tools.Forms
{
	// Token: 0x0200002A RID: 42
	public partial class PlayerDatVariables : Form
	{
		// Token: 0x0600016B RID: 363 RVA: 0x0001052D File Offset: 0x0000E72D
		public PlayerDatVariables(SavePlayerState playerState)
		{
			this.InitializeComponent();
			this.toMod = playerState;
			this.LoadValues();
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00010548 File Offset: 0x0000E748
		private void LoadValues()
		{
			this.Text = string.Format("Player.DAT Variables - {0}", this.toMod.Gamertag);
			this.titleLabel.Text = string.Format("Edit Variables - {0}", this.toMod.Gamertag);
			this.playerHealth.Value = (decimal)this.toMod.Health;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000105AC File Offset: 0x0000E7AC
		private void SaveValues()
		{
			this.toMod.Health = (float)this.playerHealth.Value;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000105CA File Offset: 0x0000E7CA
		private void playerHealth_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				base.Close();
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000105DC File Offset: 0x0000E7DC
		private void PlayerDatVariables_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveValues();
		}

		// Token: 0x040003A8 RID: 936
		public SavePlayerState toMod;
	}
}
