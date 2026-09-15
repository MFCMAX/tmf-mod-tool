namespace TMF_Tools.Forms
{
	// Token: 0x0200002A RID: 42
	public partial class PlayerDatVariables : global::System.Windows.Forms.Form
	{
		// Token: 0x06000169 RID: 361 RVA: 0x000101AB File Offset: 0x0000E3AB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000101F0 File Offset: 0x0000E3F0
		private void InitializeComponent()
		{
			this.titleLabel = new global::System.Windows.Forms.Label();
			this.playerHealth = new global::System.Windows.Forms.NumericUpDown();
			this.mPanel = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.playerHealth).BeginInit();
			this.mPanel.SuspendLayout();
			base.SuspendLayout();
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.titleLabel.Location = new global::System.Drawing.Point(6, 9);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new global::System.Drawing.Size(146, 20);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Edit Variables - N/A";
			this.playerHealth.Location = new global::System.Drawing.Point(61, 6);
			this.playerHealth.Maximum = new decimal(new int[]
			{
				-402653185,
				-1613725636,
				54210108,
				0
			});
			this.playerHealth.Minimum = new decimal(new int[]
			{
				-402653185,
				-1613725636,
				54210108,
				int.MinValue
			});
			this.playerHealth.Name = "playerHealth";
			this.playerHealth.Size = new global::System.Drawing.Size(206, 23);
			this.playerHealth.TabIndex = 1;
			this.playerHealth.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.playerHealth_KeyDown);
			this.mPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.mPanel.Controls.Add(this.label2);
			this.mPanel.Controls.Add(this.playerHealth);
			this.mPanel.Location = new global::System.Drawing.Point(12, 32);
			this.mPanel.Name = "mPanel";
			this.mPanel.Size = new global::System.Drawing.Size(272, 193);
			this.mPanel.TabIndex = 2;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 6);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(49, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Health";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(296, 237);
			base.Controls.Add(this.mPanel);
			base.Controls.Add(this.titleLabel);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "PlayerDatVariables";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Player.DAT Variables - N/A";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PlayerDatVariables_FormClosing);
			((global::System.ComponentModel.ISupportInitialize)this.playerHealth).EndInit();
			this.mPanel.ResumeLayout(false);
			this.mPanel.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003A3 RID: 931
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003A4 RID: 932
		private global::System.Windows.Forms.Label titleLabel;

		// Token: 0x040003A5 RID: 933
		private global::System.Windows.Forms.NumericUpDown playerHealth;

		// Token: 0x040003A6 RID: 934
		private global::System.Windows.Forms.Panel mPanel;

		// Token: 0x040003A7 RID: 935
		private global::System.Windows.Forms.Label label2;
	}
}
