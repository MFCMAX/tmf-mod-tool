namespace TMF_Tools.Forms
{
	// Token: 0x0200005C RID: 92
	public partial class HeaderDatBlueprints : global::System.Windows.Forms.Form
	{
		// Token: 0x06000390 RID: 912 RVA: 0x00014F2C File Offset: 0x0001312C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00014F4C File Offset: 0x0001314C
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.bluePrintList = new global::ComponentOwl.BetterListView.BetterListView();
			this.unlockAllButton = new global::System.Windows.Forms.Button();
			this.bluePrintList.BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(133, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Blueprint Unlocks";
			this.bluePrintList.AllowDrag = true;
			this.bluePrintList.AllowDrop = true;
			this.bluePrintList.FontColumns = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bluePrintList.FontItems = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bluePrintList.GridLines = 1;
			this.bluePrintList.Location = new global::System.Drawing.Point(7, 32);
			this.bluePrintList.MultiSelect = false;
			this.bluePrintList.Name = "bluePrintList";
			this.bluePrintList.Size = new global::System.Drawing.Size(259, 207);
			this.bluePrintList.TabIndex = 47;
			this.bluePrintList.View = 2;
			this.bluePrintList.DoubleClick += new global::System.EventHandler(this.bluePrintList_DoubleClick);
			this.unlockAllButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.unlockAllButton.Location = new global::System.Drawing.Point(163, 2);
			this.unlockAllButton.Name = "unlockAllButton";
			this.unlockAllButton.Size = new global::System.Drawing.Size(103, 29);
			this.unlockAllButton.TabIndex = 48;
			this.unlockAllButton.Text = "Unlock All";
			this.unlockAllButton.UseVisualStyleBackColor = true;
			this.unlockAllButton.Click += new global::System.EventHandler(this.unlockAllButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(276, 246);
			base.Controls.Add(this.unlockAllButton);
			base.Controls.Add(this.bluePrintList);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "HeaderDatBlueprints";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Edit Blueprint Data";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.HeaderDatBlueprints_FormClosing);
			this.bluePrintList.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400061D RID: 1565
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400061E RID: 1566
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400061F RID: 1567
		private global::ComponentOwl.BetterListView.BetterListView bluePrintList;

		// Token: 0x04000620 RID: 1568
		private global::System.Windows.Forms.Button unlockAllButton;
	}
}
