using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TMF_Tools.Forms
{
	// Token: 0x02000008 RID: 8
	public partial class QuickValueEditor : Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002314 File Offset: 0x00000514
		public QuickValueEditor(string valueName, byte[] existingValue, QuickValueEditor.DataType Type)
		{
			this.InitializeComponent();
			this.Text = string.Format("Edit Value - {0}", valueName);
			this.valueLabel.Text = string.Format("{0}:", valueName);
			switch (Type)
			{
			case QuickValueEditor.DataType.uInt:
				this.returnValue.Maximum = 4294967295m;
				this.returnValue.Minimum = 0m;
				this.returnValue.Value = BitConverter.ToUInt32(existingValue, 0);
				return;
			case QuickValueEditor.DataType.uShort:
				this.returnValue.Maximum = 65535m;
				this.returnValue.Minimum = 0m;
				this.returnValue.Value = BitConverter.ToUInt16(existingValue, 0);
				return;
			case QuickValueEditor.DataType.Short:
				this.returnValue.Maximum = 32767m;
				this.returnValue.Minimum = -32768m;
				this.returnValue.Value = BitConverter.ToInt16(existingValue, 0);
				return;
			case QuickValueEditor.DataType.Int:
				this.returnValue.Maximum = 2147483647m;
				this.returnValue.Minimum = -2147483648m;
				this.returnValue.Value = BitConverter.ToInt32(existingValue, 0);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000246C File Offset: 0x0000066C
		public QuickValueEditor(string valueName, byte[] existingValue, int max, int min)
		{
			this.InitializeComponent();
			this.Text = string.Format("Edit Value - {0}", valueName);
			this.valueLabel.Text = string.Format("{0}:", valueName);
			this.returnValue.Maximum = max;
			this.returnValue.Minimum = min;
			if (existingValue.Length == 2)
			{
				this.returnValue.Value = BitConverter.ToUInt16(existingValue, 0);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024EC File Offset: 0x000006EC
		private void returnValue_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.ChangedValue = true;
				base.Close();
			}
		}

		// Token: 0x04000018 RID: 24
		public bool ChangedValue;

		// Token: 0x02000009 RID: 9
		public enum DataType
		{
			// Token: 0x0400001D RID: 29
			uInt,
			// Token: 0x0400001E RID: 30
			uShort,
			// Token: 0x0400001F RID: 31
			Short,
			// Token: 0x04000020 RID: 32
			Int
		}
	}
}
