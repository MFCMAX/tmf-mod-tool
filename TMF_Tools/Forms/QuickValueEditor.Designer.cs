namespace TMF_Tools.Forms
{
	// Token: 0x02000008 RID: 8
	public partial class QuickValueEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002505 File Offset: 0x00000705
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002524 File Offset: 0x00000724
		private void InitializeComponent()
		{
			this.valueLabel = new global::System.Windows.Forms.Label();
			this.returnValue = new global::System.Windows.Forms.NumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.returnValue).BeginInit();
			base.SuspendLayout();
			this.valueLabel.AutoSize = true;
			this.valueLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 13f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.valueLabel.Location = new global::System.Drawing.Point(12, 9);
			this.valueLabel.Name = "valueLabel";
			this.valueLabel.Size = new global::System.Drawing.Size(61, 22);
			this.valueLabel.TabIndex = 0;
			this.valueLabel.Text = "Value:";
			this.returnValue.Location = new global::System.Drawing.Point(16, 34);
			this.returnValue.Name = "returnValue";
			this.returnValue.Size = new global::System.Drawing.Size(237, 23);
			this.returnValue.TabIndex = 1;
			this.returnValue.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.returnValue_KeyDown);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(265, 71);
			base.Controls.Add(this.returnValue);
			base.Controls.Add(this.valueLabel);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "QuickValueEditor";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Edit Value - N/A";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.returnValue).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label valueLabel;

		// Token: 0x0400001B RID: 27
		public global::System.Windows.Forms.NumericUpDown returnValue;
	}
}
