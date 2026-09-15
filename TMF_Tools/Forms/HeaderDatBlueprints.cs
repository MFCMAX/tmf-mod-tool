using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using TMF.Structs.OtherStructs;
using TMF.Utils;

namespace TMF_Tools.Forms
{
	// Token: 0x0200005C RID: 92
	public partial class HeaderDatBlueprints : Form
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00014D02 File Offset: 0x00012F02
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00014D0A File Offset: 0x00012F0A
		public BlueprintState[] BlueprintStates { get; set; }

		// Token: 0x0600038A RID: 906 RVA: 0x00014D13 File Offset: 0x00012F13
		public HeaderDatBlueprints(BlueprintState[] states, ImageList itemImages)
		{
			this.InitializeComponent();
			this.BlueprintStates = states;
			this.Images = itemImages;
			this.LoadListView();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00014D38 File Offset: 0x00012F38
		private void LoadListView()
		{
			this.bluePrintList.ImageList = this.Images;
			this.bluePrintList.BeginUpdate();
			for (int i = 0; i < this.BlueprintStates.Length; i++)
			{
				string blueprintItemNameFromIndex = Globals.BlueprintData.GetBlueprintItemNameFromIndex(i);
				int imageIndexFromItemID = Globals.ItemData.GetImageIndexFromItemID(blueprintItemNameFromIndex);
				BetterListViewItem betterListViewItem = new BetterListViewItem();
				betterListViewItem.ImageIndex = imageIndexFromItemID;
				betterListViewItem.Text = StringUtils.InsertSpacesBeforeCapitals(blueprintItemNameFromIndex);
				betterListViewItem.BackColor = (this.BlueprintStates[i].IsEnabled ? Color.LightGreen : Color.PaleVioletRed);
				this.bluePrintList.Items.Add(betterListViewItem);
			}
			this.bluePrintList.EndUpdate();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00014DE4 File Offset: 0x00012FE4
		private void SaveListView()
		{
			int num = 0;
			foreach (BetterListViewItem betterListViewItem in this.bluePrintList.Items)
			{
				this.BlueprintStates[num].IsEnabled = (betterListViewItem.BackColor == Color.LightGreen);
				num++;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00014E54 File Offset: 0x00013054
		private void unlockAllButton_Click(object sender, EventArgs e)
		{
			this.bluePrintList.BeginUpdate();
			foreach (BetterListViewItem betterListViewItem in this.bluePrintList.Items)
			{
				betterListViewItem.BackColor = Color.LightGreen;
			}
			this.bluePrintList.EndUpdate();
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00014EC0 File Offset: 0x000130C0
		private void bluePrintList_DoubleClick(object sender, EventArgs e)
		{
			if (this.bluePrintList.SelectedItems.Count == 1)
			{
				this.bluePrintList.SelectedItems[0].BackColor = ((this.bluePrintList.SelectedItems[0].BackColor == Color.PaleVioletRed) ? Color.LightGreen : Color.PaleVioletRed);
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00014F24 File Offset: 0x00013124
		private void HeaderDatBlueprints_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveListView();
		}

		// Token: 0x0400061C RID: 1564
		private ImageList Images;
	}
}
