using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using TMF;
using TMF.Enums;
using TMF.Structs.EntityStructs;
using TMF.Utils;
using TMF.XMLTools;
using TMF_Tools.Forms;

namespace TMF_Tools
{
	// Token: 0x0200000A RID: 10
	public partial class Main : Form
	{
		// Token: 0x0600003C RID: 60
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		internal static extern IntPtr GetFocus();

		// Token: 0x0600003D RID: 61
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string sClassName, string sAppName);

		// Token: 0x0600003E RID: 62 RVA: 0x000026F8 File Offset: 0x000008F8
		public Main()
		{
			this.InitializeComponent();
			this.gamertagDataGamertags.SelectedIndex = 0;
			this.gameModeBox.SelectedIndex = 0;
			this.playerDatListBox.SelectedIndex = 0;
			this.unlockPage1.Location = new Point(1, 23);
			this.gamertagDataGamertags.SelectedIndexChanged += this.gamertagDataGamertags_SelectedIndexChanged;
			this.playerDatListBox.SelectedIndexChanged += this.playerDatListBox_SelectedIndexChanged;
			foreach (object obj in this.playerDatPanel.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(PictureBox) && control.Name.StartsWith("itemHolder"))
				{
					control.AllowDrop = true;
					control.Tag = new object[]
					{
						null,
						null,
						0,
						-1,
						0,
						0
					};
					((PictureBox)control).SizeMode = PictureBoxSizeMode.StretchImage;
					((PictureBox)control).DragLeave += this.itemHolder_DragLeave;
					((PictureBox)control).DragEnter += this.itemHolder_DragEnter;
					((PictureBox)control).DragDrop += this.itemHolder_DragDrop;
					((PictureBox)control).Paint += this.itemHolder_Paint;
					((PictureBox)control).MouseEnter += this.itemHolder_MouseEnter;
					((PictureBox)control).MouseLeave += this.itemHolder_MouseLeave;
					((PictureBox)control).MouseWheel += this.itemHolder_MouseWheel;
					((PictureBox)control).MouseDown += this.itemHolder_ItemDrag;
				}
			}
			foreach (object obj2 in this.headerDatPanel.Controls)
			{
				Control control2 = (Control)obj2;
				if (control2.GetType() == typeof(PictureBox) && control2.Name.StartsWith("itemHolder"))
				{
					control2.AllowDrop = true;
					control2.Tag = new object[]
					{
						null,
						null,
						0,
						-1,
						0,
						0
					};
					((PictureBox)control2).SizeMode = PictureBoxSizeMode.StretchImage;
					((PictureBox)control2).DragLeave += this.itemHolder_DragLeave;
					((PictureBox)control2).DragEnter += this.itemHolder_DragEnter;
					((PictureBox)control2).DragDrop += this.itemHolder_DragDrop;
					((PictureBox)control2).Paint += this.itemHolder_Paint;
					((PictureBox)control2).MouseEnter += this.itemHolder_MouseEnter;
					((PictureBox)control2).MouseLeave += this.itemHolder_MouseLeave;
					((PictureBox)control2).MouseWheel += this.itemHolder_MouseWheel;
					((PictureBox)control2).MouseDown += this.itemHolder_ItemDrag;
				}
			}
			Globals.ItemData = ItemData.ReadItemData("ItemData.xml", "itemidindexes.txt");
			Globals.BlueprintData = BlueprintData.ReadBlueprintData("BlueprintData.xml", "itemblueprintids.txt");
			this.LoadPlayerDatTabInventoryItems(this.inventoryVisualItems);
			this.LoadGmaertagDataSkillsList();
			this.SaveData = new TMF();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002B74 File Offset: 0x00000D74
		private void playerDatOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Open Player.DAT...";
			openFileDialog.Filter = "DAT Files|*.dat|All Files|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.PlayerDatStream = File.Open(openFileDialog.FileName, FileMode.Open);
					this.SaveData.OpenPlayerDAT(this.PlayerDatStream);
					this.LoadPlayerDatTab();
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("Could not open file: \n{0}", ex.Message), "Error - Could not open", MessageBoxButtons.OK);
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002C00 File Offset: 0x00000E00
		private void playerDatSaveNew_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "DAT File|*.dat|All Files|*.*";
			saveFileDialog.Title = "Choose output file... (player.dat)";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.SaveCurrentPlayer();
				Stream stream = File.Create(saveFileDialog.FileName);
				this.SaveData.PlayerData.WriteData(stream);
				stream.Close();
				MessageBox.Show("File created and saved!", "File Save - Success", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002C6C File Offset: 0x00000E6C
		private void playerDatClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close the current file?", "Close File - Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			this.CurrentPlayerDATPlayerSaveState = null;
			this.SaveData.PlayerData = null;
			this.PlayerDatSave.Enabled = false;
			this.playerDatClose.Enabled = false;
			this.playerDatPanel.Enabled = false;
			this.playerDatVariables.Enabled = false;
			this.playerDatListBox.Items.Clear();
			this.playerDatListBox.Items.Add("None");
			this.playerDatListBox.SelectedIndex = 0;
			this.PlayerDatStream.Close();
			foreach (object obj in this.playerDatPanel.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(PictureBox) && control.Name.StartsWith("itemHolder"))
				{
					control.Tag = new object[]
					{
						null,
						null,
						-1,
						-1,
						0,
						0
					};
					((PictureBox)control).Image = null;
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002DBC File Offset: 0x00000FBC
		private void playerDatSaveCurrent_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to overwrite your save file?", "Overwrite - Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			this.PlayerDatStream.SetLength(0L);
			this.SaveCurrentPlayer();
			this.SaveData.PlayerData.WriteData(this.PlayerDatStream);
			MessageBox.Show("File Over-Written!", "File Save - Success", MessageBoxButtons.OK);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002E18 File Offset: 0x00001018
		private void playerDatVariables_Click(object sender, EventArgs e)
		{
			PlayerDatVariables playerDatVariables = new PlayerDatVariables(this.CurrentPlayerDATPlayerSaveState);
			playerDatVariables.Location = Cursor.Position;
			playerDatVariables.ShowDialog();
			this.CurrentPlayerDATPlayerSaveState = playerDatVariables.toMod;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002E50 File Offset: 0x00001050
		private void LoadPlayerDatTabInventoryItems(BetterListView lv)
		{
			for (int i = 0; i < Globals.ItemData.ArrayOfItemDataXML.Length; i++)
			{
				ItemDataXML itemDataXML = Globals.ItemData.ArrayOfItemDataXML[i];
				if (itemDataXML.IsValid && itemDataXML.ItemID != "None")
				{
					BetterListViewItem betterListViewItem = new BetterListViewItem();
					if (!itemDataXML.ItemID.EndsWith("Icon"))
					{
						betterListViewItem.Text = StringUtils.InsertSpacesBeforeCapitals(itemDataXML.ItemID);
						betterListViewItem.ImageIndex = Globals.ItemData.GetImageIndexFromItemID(itemDataXML.ItemID);
						betterListViewItem.Tag = new object[]
						{
							itemDataXML.ItemID,
							itemDataXML.StackSize
						};
						lv.Items.Add(betterListViewItem);
					}
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002F14 File Offset: 0x00001114
		private void LoadPlayerDatTab()
		{
			this.LoadPlayerDatPlayerNameList();
			this.playerDatPanel.Enabled = true;
			this.PlayerDatSave.Enabled = true;
			this.playerDatClose.Enabled = true;
			this.playerDatVariables.Enabled = true;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002F4C File Offset: 0x0000114C
		private void LoadNewPlayerState()
		{
			if (this.CurrentPlayerDATPlayerSaveState == null)
			{
				throw new Exception("CurrentPlayerDATPlayerSaveState was null.  Please report this error.");
			}
			foreach (SaveInventoryItem saveInventoryItem in this.CurrentPlayerDATPlayerSaveState.Inventory.Items)
			{
				PictureBox pictureBox = (PictureBox)base.Controls.Find(string.Format("itemHolder{0}", saveInventoryItem.SlotID), true)[0];
				string text = ((Item)saveInventoryItem.ItemID).ToString();
				int imageIndexFromItemID = Globals.ItemData.GetImageIndexFromItemID(text);
				int num = 1;
				foreach (ItemDataXML itemDataXML in Globals.ItemData.ArrayOfItemDataXML)
				{
					if (itemDataXML.ItemID == text)
					{
						num = itemDataXML.StackSize;
						break;
					}
				}
				ushort itemMaxDurability = this.GetItemMaxDurability(text);
				pictureBox.Tag = new object[]
				{
					text,
					imageIndexFromItemID,
					saveInventoryItem.Count,
					num,
					saveInventoryItem.Durability,
					itemMaxDurability
				};
				pictureBox.Image = this.itemImages.Images[(int)((object[])pictureBox.Tag)[1]];
				pictureBox.ContextMenuStrip = this.context_itemHolderOptions;
				pictureBox.Refresh();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030EC File Offset: 0x000012EC
		private void LoadPlayerDatPlayerNameList()
		{
			this.playerDatListBox.Items.Clear();
			this.playerDatListBox.BeginUpdate();
			for (int i = 0; i < this.SaveData.PlayerData.Players.Count; i++)
			{
				this.playerDatListBox.Items.Add(this.SaveData.PlayerData.Players[i].Gamertag);
			}
			this.playerDatListBox.SelectedIndex = 0;
			this.playerDatListBox.EndUpdate();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003178 File Offset: 0x00001378
		private void SaveCurrentPlayer()
		{
			if (this.CurrentPlayerDATPlayerSaveState == null)
			{
				return;
			}
			this.CurrentPlayerDATPlayerSaveState.Inventory.Items.Clear();
			this.gameModeBox.SelectedIndex = 0;
			foreach (object obj in this.playerDatPanel.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(PictureBox) && control.Name.StartsWith("itemHolder"))
				{
					ushort slotID = ushort.Parse(control.Name.Substring(10));
					string text = (string)((object[])control.Tag)[0];
					if (text != null)
					{
						ushort itemID = (ushort)Enum.Parse(typeof(Item), text);
						int count = (int)((object[])control.Tag)[2];
						int num = (int)((object[])control.Tag)[3];
						ushort durability = (ushort)((object[])control.Tag)[4];
						SaveInventoryItem item = default(SaveInventoryItem);
						item.SlotID = slotID;
						item.Count = count;
						item.ItemID = itemID;
						item.Durability = durability;
						this.CurrentPlayerDATPlayerSaveState.Inventory.Items.Add(item);
					}
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000032FC File Offset: 0x000014FC
		private SavePlayerState GetPlayerStateFromGamertag(string gamertag)
		{
			for (int i = 0; i < this.SaveData.PlayerData.Players.Count; i++)
			{
				if (this.SaveData.PlayerData.Players[i].Gamertag == gamertag)
				{
					return this.SaveData.PlayerData.Players[i];
				}
			}
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003364 File Offset: 0x00001564
		private void playerDatListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.SaveData == null || this.SaveData.PlayerData == null)
			{
				return;
			}
			this.SaveCurrentPlayer();
			this.CurrentPlayerDATPlayerSaveState = this.GetPlayerStateFromGamertag(this.playerDatListBox.SelectedItem.ToString().Trim());
			this.LoadNewPlayerState();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000033B4 File Offset: 0x000015B4
		private void inventoryVisualItems_ItemDrag(object sender, BetterListViewItemDragEventArgs e)
		{
			base.DoDragDrop(e.ItemDragData.Items[0], DragDropEffects.Move);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000033D0 File Offset: 0x000015D0
		private void itemHolder_ItemDrag(object sender, MouseEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (e.Button == MouseButtons.Right)
			{
				if (pictureBox.Image != null)
				{
					pictureBox.ContextMenuStrip.Show(Cursor.Position);
				}
				return;
			}
			if (pictureBox.Image == null)
			{
				return;
			}
			base.DoDragDrop(pictureBox, DragDropEffects.Move);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003420 File Offset: 0x00001620
		private void itemHolder_DragEnter(object sender, DragEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (e.Data.GetDataPresent(typeof(BetterListViewItem)))
			{
				e.Effect = DragDropEffects.Move;
				BetterListViewItem betterListViewItem = (BetterListViewItem)e.Data.GetData(typeof(BetterListViewItem));
				if (pictureBox.Image != this.itemImages.Images[betterListViewItem.ImageIndex] || ((object[])pictureBox.Tag)[0] != ((object[])betterListViewItem.Tag)[0])
				{
					pictureBox.Image = this.itemImages.Images[betterListViewItem.ImageIndex];
					return;
				}
			}
			else if (e.Data.GetDataPresent(typeof(PictureBox)))
			{
				e.Effect = DragDropEffects.Move;
				PictureBox pictureBox2 = (PictureBox)e.Data.GetData(typeof(PictureBox));
				pictureBox.Image = this.itemImages.Images[(int)((object[])pictureBox2.Tag)[1]];
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003528 File Offset: 0x00001728
		private void itemHolder_DragDrop(object sender, DragEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (e.Data.GetDataPresent(typeof(BetterListViewItem)))
			{
				BetterListViewItem betterListViewItem = (BetterListViewItem)e.Data.GetData(typeof(BetterListViewItem));
				if ((string)((object[])pictureBox.Tag)[0] == (string)((object[])betterListViewItem.Tag)[0])
				{
					((object[])pictureBox.Tag)[3] = ((object[])betterListViewItem.Tag)[1];
					int num = (int)((object[])pictureBox.Tag)[2];
					if (num + 1 <= (int)((object[])betterListViewItem.Tag)[1])
					{
						((object[])pictureBox.Tag)[2] = num + 1;
					}
					pictureBox.ContextMenuStrip = this.context_itemHolderOptions;
				}
				else
				{
					((object[])pictureBox.Tag)[1] = betterListViewItem.ImageIndex;
					((object[])pictureBox.Tag)[0] = ((object[])betterListViewItem.Tag)[0];
					((object[])pictureBox.Tag)[2] = 1;
					((object[])pictureBox.Tag)[3] = ((object[])betterListViewItem.Tag)[1];
					ushort itemMaxDurability = this.GetItemMaxDurability((string)((object[])betterListViewItem.Tag)[0]);
					((object[])pictureBox.Tag)[4] = itemMaxDurability;
					((object[])pictureBox.Tag)[5] = itemMaxDurability;
					pictureBox.ContextMenuStrip = this.context_itemHolderOptions;
					new ToolTip().SetToolTip(pictureBox, (string)((object[])betterListViewItem.Tag)[0]);
				}
			}
			if (e.Data.GetDataPresent(typeof(PictureBox)))
			{
				PictureBox pictureBox2 = (PictureBox)e.Data.GetData(typeof(PictureBox));
				if (pictureBox == pictureBox2)
				{
					pictureBox.Tag = pictureBox2.Tag;
					pictureBox.Image = this.itemImages.Images[(int)((object[])pictureBox.Tag)[1]];
					pictureBox.ContextMenuStrip = this.context_itemHolderOptions;
				}
				else
				{
					pictureBox.Tag = pictureBox2.Tag;
					pictureBox.Image = this.itemImages.Images[(int)((object[])pictureBox.Tag)[1]];
					pictureBox.ContextMenuStrip = this.context_itemHolderOptions;
					pictureBox2.Image = null;
					pictureBox2.Tag = new object[]
					{
						null,
						null,
						-1,
						-1,
						0,
						0
					};
				}
			}
			pictureBox.Refresh();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000037D8 File Offset: 0x000019D8
		private void itemHolder_DragLeave(object sender, EventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			pictureBox.Image = ((((object[])pictureBox.Tag)[1] == null) ? null : this.itemImages.Images[(int)((object[])pictureBox.Tag)[1]]);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003828 File Offset: 0x00001A28
		private void itemHolder_Paint(object sender, PaintEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			int num = (int)((object[])pictureBox.Tag)[2];
			int num2 = (int)((object[])pictureBox.Tag)[3];
			if (num > 0 || num2 == 0)
			{
				e.Graphics.DrawString(num.ToString(), new Font("Arial", 10f), ((int)((object[])pictureBox.Tag)[2] < (int)((object[])pictureBox.Tag)[3]) ? Brushes.Blue : Brushes.Red, new Point(-2, 0));
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000038CC File Offset: 0x00001ACC
		private void itemHolder_MouseEnter(object sender, EventArgs e)
		{
			((PictureBox)sender).Focus();
			PictureBox pictureBox = sender as PictureBox;
			if (int.Parse(pictureBox.Name.Substring(10)) >= 37 && int.Parse(pictureBox.Name.Substring(10)) <= 66)
			{
				if (((object[])pictureBox.Tag)[0] != null)
				{
					this.headerDatCurrentItem.Text = string.Format("Item: {0}", StringUtils.InsertSpacesBeforeCapitals((string)((object[])pictureBox.Tag)[0]));
					return;
				}
				this.headerDatCurrentItem.Text = "Item: None";
				return;
			}
			else
			{
				if (((object[])pictureBox.Tag)[0] != null)
				{
					this.currentHoverItem.Text = string.Format("Item: {0}", StringUtils.InsertSpacesBeforeCapitals((string)((object[])pictureBox.Tag)[0]));
					return;
				}
				this.currentHoverItem.Text = "Item: None";
				return;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000039B4 File Offset: 0x00001BB4
		private void itemHolder_MouseLeave(object sender, EventArgs e)
		{
			base.Focus();
			int num = int.Parse(((Control)sender).Name.Substring(10));
			if (num >= 0 && num <= 36)
			{
				this.currentHoverItem.Text = "Item: None";
				return;
			}
			if (num >= 37 && num <= 66)
			{
				this.headerDatCurrentItem.Text = "Item: None";
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003A14 File Offset: 0x00001C14
		private void itemHolder_MouseWheel(object sender, MouseEventArgs e)
		{
			PictureBox pictureBox = (PictureBox)sender;
			if (((object[])pictureBox.Tag)[0] == null)
			{
				return;
			}
			int num = (int)((object[])pictureBox.Tag)[2];
			int num2 = (int)((object[])pictureBox.Tag)[3];
			int num3 = (int)((object[])pictureBox.Tag)[2] + e.Delta / 120;
			num3 = ((num3 <= 1) ? 1 : ((num3 > num2) ? num2 : num3));
			((object[])pictureBox.Tag)[2] = num3;
			pictureBox.Refresh();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003AA4 File Offset: 0x00001CA4
		private void inventoryVisualItemSearchBox_KeyDown(object sender, KeyEventArgs e)
		{
			BetterListView betterListView = this.inventoryVisualItems;
			TextBox textBox = sender as TextBox;
			if (e.KeyCode == Keys.Return && textBox.Text != "")
			{
				betterListView.BeginUpdate();
				if (this.playerDatSelectedItems != null && this.playerDatSelectedItems.Count > 0)
				{
					this.playerDatselectedItemIndex = ((this.playerDatselectedItemIndex == this.playerDatSelectedItems.Count - 1) ? 0 : (this.playerDatselectedItemIndex + 1));
					this.playerDatSelectedItems[this.playerDatselectedItemIndex].Focused = true;
					this.playerDatSelectedItems[this.playerDatselectedItemIndex].EnsureVisible();
					this.playerDatSelectedItems[this.playerDatselectedItemIndex].Selected = true;
				}
				betterListView.EndUpdate();
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003B70 File Offset: 0x00001D70
		private void inventoryVisualItemSearchBox_TextChanged(object sender, EventArgs e)
		{
			BetterListView betterListView = this.inventoryVisualItems;
			betterListView.BeginUpdate();
			if (((TextBox)sender).Text == "")
			{
				using (IEnumerator<BetterListViewItem> enumerator = betterListView.Items.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						BetterListViewItem betterListViewItem = enumerator.Current;
						betterListViewItem.BackColor = SystemColors.Control;
						betterListViewItem.SearchHighlight = BetterListViewSearchHighlight.Empty;
					}
					goto IL_167;
				}
			}
			this.playerDatSelectedItems.Clear();
			this.playerDatselectedItemIndex = 0;
			foreach (BetterListViewItem betterListViewItem2 in betterListView.Items)
			{
				bool flag = betterListViewItem2.Text.ToLower().Contains(((TextBox)sender).Text.ToLower());
				if (flag)
				{
					betterListViewItem2.BackColor = Color.Red;
					betterListViewItem2.SearchHighlight = new BetterListViewSearchHighlight(0, betterListViewItem2.Text.ToLower().IndexOf(((TextBox)sender).Text.ToLower(), StringComparison.Ordinal), ((TextBox)sender).Text.ToLower().Length);
					betterListViewItem2.EnsureVisible();
					this.playerDatSelectedItems.Add(betterListViewItem2);
				}
				else
				{
					betterListViewItem2.BackColor = SystemColors.Control;
					betterListViewItem2.SearchHighlight = BetterListViewSearchHighlight.Empty;
					if (this.playerDatSelectedItems.Contains(betterListViewItem2))
					{
						this.playerDatSelectedItems.Remove(betterListViewItem2);
					}
				}
			}
			IL_167:
			betterListView.EndUpdate();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003D08 File Offset: 0x00001F08
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			this.HandleHotKey(keyData);
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003D1C File Offset: 0x00001F1C
		private void HandleHotKey(Keys key)
		{
			if (key == Keys.Delete)
			{
				if (Form.ActiveForm != this)
				{
					return;
				}
				Control focusedControl = this.GetFocusedControl();
				if (focusedControl == null)
				{
					return;
				}
				if (focusedControl.Name.StartsWith("itemHolder") && focusedControl.GetType() == typeof(PictureBox))
				{
					PictureBox pictureBox = (PictureBox)focusedControl;
					pictureBox.Tag = new object[]
					{
						null,
						null,
						-1,
						-1,
						0,
						0
					};
					pictureBox.Image = null;
					pictureBox.ContextMenuStrip = null;
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003DB0 File Offset: 0x00001FB0
		private ushort GetItemMaxDurability(string itemid)
		{
			for (int i = 0; i < Globals.ItemData.ArrayOfItemDataXML.Length; i++)
			{
				if (Globals.ItemData.ArrayOfItemDataXML[i].ItemID == itemid)
				{
					return Globals.ItemData.ArrayOfItemDataXML[i].Durability;
				}
			}
			return 0;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003E00 File Offset: 0x00002000
		private Control GetFocusedControl()
		{
			Control result = null;
			IntPtr focus = Main.GetFocus();
			if (focus != IntPtr.Zero)
			{
				result = Control.FromHandle(focus);
			}
			return result;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003E2C File Offset: 0x0000202C
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
				if (contextMenuStrip != null)
				{
					PictureBox pictureBox = contextMenuStrip.SourceControl as PictureBox;
					if (pictureBox.Name.StartsWith("itemHolder"))
					{
						pictureBox.Tag = new object[]
						{
							null,
							null,
							0,
							-1,
							0,
							0
						};
						pictureBox.Image = null;
						pictureBox.ContextMenuStrip = null;
					}
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003EB0 File Offset: 0x000020B0
		private void editAmountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
				if (contextMenuStrip != null)
				{
					PictureBox pictureBox = contextMenuStrip.SourceControl as PictureBox;
					if (pictureBox.Name.StartsWith("itemHolder"))
					{
						QuickValueEditor quickValueEditor = new QuickValueEditor(StringUtils.InsertSpacesBeforeCapitals((string)((object[])pictureBox.Tag)[0]), BitConverter.GetBytes((int)((object[])pictureBox.Tag)[2]), QuickValueEditor.DataType.Int);
						quickValueEditor.Location = Cursor.Position;
						quickValueEditor.ShowDialog();
						if (!quickValueEditor.ChangedValue)
						{
							return;
						}
						int num = (int)quickValueEditor.returnValue.Value;
						int num2 = (int)((object[])pictureBox.Tag)[3];
						if (num > num2)
						{
							num = num2;
						}
						else if (num <= 0)
						{
							num = 1;
						}
						((object[])pictureBox.Tag)[2] = num;
						pictureBox.Refresh();
					}
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003FA4 File Offset: 0x000021A4
		private void editDurabilityToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
			if (toolStripMenuItem != null)
			{
				ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
				if (contextMenuStrip != null)
				{
					PictureBox pictureBox = contextMenuStrip.SourceControl as PictureBox;
					if (pictureBox.Name.StartsWith("itemHolder"))
					{
						ushort itemMaxDurability = this.GetItemMaxDurability((string)((object[])pictureBox.Tag)[0]);
						if (itemMaxDurability == 0)
						{
							MessageBox.Show(string.Format("This item has no durability. \nItem: {0}", (string)((object[])pictureBox.Tag)[0]), "Error - Cannot Edit", MessageBoxButtons.OK);
							return;
						}
						QuickValueEditor quickValueEditor = new QuickValueEditor(string.Format("{0} (durability)", StringUtils.InsertSpacesBeforeCapitals((string)((object[])pictureBox.Tag)[0])), BitConverter.GetBytes((ushort)((object[])pictureBox.Tag)[4]), (int)this.GetItemMaxDurability((string)((object[])pictureBox.Tag)[0]), 0);
						quickValueEditor.Location = Cursor.Position;
						quickValueEditor.ShowDialog();
						if (!quickValueEditor.ChangedValue)
						{
							return;
						}
						ushort num = (ushort)quickValueEditor.returnValue.Value;
						if (num > itemMaxDurability)
						{
							num = itemMaxDurability;
						}
						else if (num <= 0)
						{
							num = 0;
						}
						((object[])pictureBox.Tag)[4] = num;
						pictureBox.Refresh();
					}
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000040EB File Offset: 0x000022EB
		private void label9_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.se7ensins.com/members/xbltoothpik.432363/");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000040F8 File Offset: 0x000022F8
		private void nextPage_Click(object sender, EventArgs e)
		{
			this.unlockPage1.Visible = false;
			this.unlockPage2.Visible = true;
			this.lastPage.Visible = true;
			this.nextPage.Visible = false;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000412A File Offset: 0x0000232A
		private void lastPage_Click(object sender, EventArgs e)
		{
			this.unlockPage1.Visible = true;
			this.unlockPage2.Visible = false;
			this.nextPage.Visible = true;
			this.lastPage.Visible = false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000415C File Offset: 0x0000235C
		private void unlockAllButton_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.unlockPage1.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(CheckBox) && control.Name.EndsWith("Check"))
				{
					((CheckBox)control).Checked = true;
				}
			}
			foreach (object obj2 in this.unlockPage2.Controls)
			{
				Control control2 = (Control)obj2;
				if (control2.GetType() == typeof(CheckBox) && control2.Name.EndsWith("Check"))
				{
					((CheckBox)control2).Checked = true;
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004260 File Offset: 0x00002460
		private void gamertagdataOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "|*.db|All Files|*.*";
			openFileDialog.Title = "Open GamertagData.db...";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.GamertagDataStream = File.Open(openFileDialog.FileName, FileMode.Open);
				this.SaveData.OpenGamertagData(this.GamertagDataStream);
				this.LoadGamertagDataTab();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000042BC File Offset: 0x000024BC
		private void gamertagDataNewFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Choose output file...";
			saveFileDialog.Filter = "|*.db|All Files|*.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Stream stream = File.Create(saveFileDialog.FileName);
				this.SaveCurrentGamertagState();
				this.SaveData.GamertagData.WriteData(stream);
				stream.Close();
				MessageBox.Show("File created and saved!", "File Save - Success", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004328 File Offset: 0x00002528
		private void gamertagDataCurrentFile_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to overwrite your save file?", "Overwrite - Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			this.GamertagDataStream.SetLength(0L);
			this.SaveCurrentGamertagState();
			this.SaveData.GamertagData.WriteData(this.GamertagDataStream);
			MessageBox.Show("File Over-Written!", "File Save - Success", MessageBoxButtons.OK);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004384 File Offset: 0x00002584
		private void gamertagDataCloseButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close the current file?", "Close File - Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			this.SaveData.GamertagData = null;
			this.gamertagDataCloseButton.Enabled = false;
			this.gamertagDataSaveButton.Enabled = false;
			this.gamertagDataPanel.Enabled = false;
			foreach (object obj in this.unlockPage1.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(CheckBox) && control.Name.EndsWith("Check"))
				{
					((CheckBox)control).Checked = false;
				}
			}
			foreach (object obj2 in this.unlockPage2.Controls)
			{
				Control control2 = (Control)obj2;
				if (control2.GetType() == typeof(CheckBox) && control2.Name.EndsWith("Check"))
				{
					((CheckBox)control2).Checked = false;
				}
			}
			this.gamertagDataGamertags.Items.Clear();
			this.gamertagDataGamertags.Items.Add("None");
			this.gamertagDataGamertags.SelectedIndex = 0;
			this.gamertagDataSkillsBox.BeginUpdate();
			for (int i = 0; i < this.gamertagDataSkillsBox.Items.Count; i++)
			{
				this.gamertagDataSkillsBox.Items[i].SubItems.Clear();
			}
			this.GamertagDataStream.Close();
			this.gamertagDataSkillsBox.EndUpdate();
			this.nextPage.Visible = true;
			this.lastPage.Visible = false;
			this.unlockPage1.Visible = true;
			this.unlockPage2.Visible = false;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004588 File Offset: 0x00002788
		private void treeHuggerCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.treeHuggerCheck.Checked)
			{
				if (this.CurrentGamertagData.UnlockData.TreesChopped < 2)
				{
					this.CurrentGamertagData.UnlockData.TreesChopped = 2;
					return;
				}
			}
			else
			{
				if (this.lumberjackCheck.Checked)
				{
					this.lumberjackCheck.Checked = false;
				}
				this.CurrentGamertagData.UnlockData.TreesChopped = 0;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000045F4 File Offset: 0x000027F4
		private void carpenterCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.carpenterCheck.Checked)
			{
				if (!this.CurrentGamertagData.UnlockData.HasDoneAction(Item.Workbench, ItemAction.Crafted))
				{
					this.CurrentGamertagData.UnlockData.ActionLog.AddAction(Item.Workbench, ItemAction.Crafted);
					return;
				}
			}
			else if (this.CurrentGamertagData.UnlockData.HasDoneAction(Item.Workbench, ItemAction.Crafted))
			{
				this.CurrentGamertagData.UnlockData.ActionLog.RemoveAction(Item.Workbench, ItemAction.Crafted);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004669 File Offset: 0x00002869
		private void pupilCheck_CheckedChanged(object sender, EventArgs e)
		{
			this.CurrentGamertagData.UnlockData.SetPupilUnlocked(this.pupilCheck.Checked);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004688 File Offset: 0x00002888
		private void lumberjackCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.lumberjackCheck.Checked)
			{
				if (this.CurrentGamertagData.UnlockData.SaplingsPlanted < 20)
				{
					this.CurrentGamertagData.UnlockData.SaplingsPlanted = 20;
				}
				if (this.CurrentGamertagData.UnlockData.TreesChopped < 20)
				{
					this.CurrentGamertagData.UnlockData.TreesChopped = 20;
				}
				if (this.CurrentGamertagData.UnlockData.WoodPlanksCrafted < 80)
				{
					this.CurrentGamertagData.UnlockData.WoodPlanksCrafted = 80;
				}
				this.treeHuggerCheck.Checked = true;
				return;
			}
			this.CurrentGamertagData.UnlockData.SaplingsPlanted = 0;
			if (this.treeHuggerCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.TreesChopped = 2;
			}
			else
			{
				this.CurrentGamertagData.UnlockData.TreesChopped = 0;
			}
			this.CurrentGamertagData.UnlockData.TreesChopped = 0;
			this.CurrentGamertagData.UnlockData.WoodPlanksCrafted = 0;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004785 File Offset: 0x00002985
		private void chefCheck_CheckedChanged(object sender, EventArgs e)
		{
			this.CurrentGamertagData.UnlockData.SetChefUnlocked(this.chefCheck.Checked);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000047A2 File Offset: 0x000029A2
		private void LoadGamertagDataTab()
		{
			this.LoadGamertagDataTags();
			this.gamertagDataPanel.Enabled = true;
			this.gamertagDataSaveButton.Enabled = true;
			this.gamertagDataCloseButton.Enabled = true;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000047D0 File Offset: 0x000029D0
		private void LoadNewGamertagDataState()
		{
			if (this.SaveData == null || this.SaveData.GamertagData == null)
			{
				return;
			}
			this.gamertagDataSkillsBox.BeginUpdate();
			for (int i = 0; i < this.CurrentGamertagData.SkillData.skilldata.Length; i++)
			{
				this.gamertagDataSkillsBox.Items[i].SubItems.Clear();
			}
			for (int j = 0; j < this.CurrentGamertagData.SkillData.skilldata.Length; j++)
			{
				this.gamertagDataSkillsBox.Items[j].SubItems.Add(TMF.Structs.EntityStructs.SkillData.GetLevelForXP(this.CurrentGamertagData.SkillData[j].CurrentXP).ToString());
			}
			this.gamertagDataSkillsBox.EndUpdate();
			this.explorerCheck.Checked = this.CurrentGamertagData.UnlockData.ExplorerUnlocked;
			this.treeHuggerCheck.Checked = (this.CurrentGamertagData.UnlockData.TreesChopped >= 2);
			this.carpenterCheck.Checked = this.CurrentGamertagData.UnlockData.HasDoneAction(Item.Workbench, ItemAction.Crafted);
			this.prisonerCheck.Checked = this.CurrentGamertagData.UnlockData.EscapedToSurface;
			this.pupilCheck.Checked = this.CurrentGamertagData.UnlockData.IsPupilUnlocked();
			this.jamaicanCheck.Checked = this.CurrentGamertagData.UnlockData.RastaFill;
			this.lumberjackCheck.Checked = (this.CurrentGamertagData.UnlockData.TreesChopped >= 20 && this.CurrentGamertagData.UnlockData.SaplingsPlanted >= 20 && this.CurrentGamertagData.UnlockData.WoodPlanksCrafted >= 80);
			this.pirateCheck.Checked = (this.CurrentGamertagData.UnlockData.TreasureChestsOpened >= 30);
			this.refugeeCheck.Checked = (this.CurrentGamertagData.UnlockData.RemotePlayersKilled >= 1);
			this.kingCheck.Checked = this.CurrentGamertagData.UnlockData.KingUnlocked;
			this.astronautCheck.Checked = (this.CurrentGamertagData.UnlockData.WorldsVisited.Count >= 10);
			this.ninjaCheck.Checked = (this.CurrentGamertagData.UnlockData.KillStreamGamerID.Count >= 20);
			this.cavemanCheck.Checked = (this.CurrentGamertagData.UnlockData.BlocksClearedWithWoodPick >= 500);
			this.chefCheck.Checked = this.CurrentGamertagData.UnlockData.IsChefUnlocked();
			this.invadermanCheck.Checked = (this.CurrentGamertagData.UnlockData.InvadersScore >= 20000);
			this.hippieCheck.Checked = (this.CurrentGamertagData.UnlockData.FlowersThrownAtEnemy >= 30);
			this.madmanCheck.Checked = (this.CurrentGamertagData.UnlockData.DetonationCount >= 500);
			this.medicCheck.Checked = (this.CurrentGamertagData.UnlockData.HealedOther >= 50 && this.CurrentGamertagData.UnlockData.HealedSelf >= 50);
			this.diabloCheck.Checked = this.CurrentGamertagData.UnlockData.KilledDiablo;
			this.angelCheck.Checked = (this.CurrentGamertagData.UnlockData.PlayersSavedFromDeath >= 15);
			this.cowboyCheck.Checked = (this.CurrentGamertagData.UnlockData.EnemiesKilledWhileHangingFromRope >= 50);
			this.entrepreneurCheck.Checked = (this.CurrentGamertagData.UnlockData.EntrepreneurUnlocked || this.CurrentGamertagData.UnlockData.GoldEarned >= 1000000);
			this.goldenknightCheck.Checked = this.CurrentGamertagData.UnlockData.GoldenKnightUnlocked;
			this.handymanCheck.Checked = this.CurrentGamertagData.UnlockData.IsHandymanUnlocked();
			this.indianCheck.Checked = (this.CurrentGamertagData.UnlockData.HasDoneAction(Item.WoodBow, ItemAction.Crafted) && this.CurrentGamertagData.UnlockData.ArrowsCrafted >= 200 && this.CurrentGamertagData.UnlockData.EnemiesKilledWithArrow >= 50);
			this.sageCheck.Checked = (this.CurrentGamertagData.UnlockData.SageUnlocked || this.CurrentGamertagData.UnlockData.WisdomFound >= 49);
			this.knightCheck.Checked = (this.CurrentGamertagData.UnlockData.KnightUnlocked || (this.CurrentGamertagData.UnlockData.BedrockReached && this.CurrentGamertagData.UnlockData.EnemiesKilledBeforeReachingBedrock >= 50));
			this.soldierCheck.Checked = (this.CurrentGamertagData.UnlockData.HasDoneAction(Item.GrenadeLauncher, ItemAction.Crafted) && this.CurrentGamertagData.UnlockData.GrenadesCrafted >= 50 && this.CurrentGamertagData.UnlockData.GrenadesLaunched >= 50);
			this.terminatorCheck.Checked = (this.CurrentGamertagData.UnlockData.EnemiesKilledWithGrenadeLauncher >= 200);
			this.zombieCheck.Checked = (this.CurrentGamertagData.UnlockData.SurvivalDaysSurvived >= 5);
			this.demigodCheck.Checked = (this.CurrentGamertagData.UnlockData.ZuesPlaced && this.CurrentGamertagData.UnlockData.BadBoy == BadBoyType.None);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004D98 File Offset: 0x00002F98
		private void SaveCurrentGamertagState()
		{
			if (this.CurrentGamertagData == null)
			{
				return;
			}
			for (int i = 0; i < this.CurrentGamertagData.SkillData.skilldata.Length; i++)
			{
				int num = int.Parse(this.gamertagDataSkillsBox.Items[i].SubItems[1].Text);
				int xpforLevel = TMF.Structs.EntityStructs.SkillData.GetXPForLevel(num + 1);
				this.CurrentGamertagData.SkillData[i].CurrentXP = (double)xpforLevel;
			}
			this.CurrentGamertagData.UnlockData.ExplorerUnlocked = this.explorerCheck.Checked;
			this.CurrentGamertagData.UnlockData.EscapedToSurface = this.prisonerCheck.Checked;
			this.CurrentGamertagData.UnlockData.RastaFill = this.jamaicanCheck.Checked;
			if (this.CurrentGamertagData.UnlockData.TreasureChestsOpened < 30 && this.pirateCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.TreasureChestsOpened = 30;
			}
			else if (!this.pirateCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.TreasureChestsOpened = 0;
			}
			if (this.CurrentGamertagData.UnlockData.RemotePlayersKilled < 1 && this.refugeeCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.RemotePlayersKilled = 1;
			}
			else if (!this.refugeeCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.RemotePlayersKilled = 0;
			}
			this.CurrentGamertagData.UnlockData.KingUnlocked = this.kingCheck.Checked;
			if (this.astronautCheck.Checked)
			{
				if (this.CurrentGamertagData.UnlockData.WorldsVisited.Count < 10)
				{
					this.CurrentGamertagData.UnlockData.WorldsVisited.AddRange(new int[10 - this.CurrentGamertagData.UnlockData.WorldsVisited.Count]);
				}
			}
			else
			{
				this.CurrentGamertagData.UnlockData.WorldsVisited = new List<int>();
			}
			if (this.ninjaCheck.Checked)
			{
				if (this.CurrentGamertagData.UnlockData.KillStreamGamerID.Count < 20)
				{
					this.CurrentGamertagData.UnlockData.KillStreamGamerID.AddRange(new int[20 - this.CurrentGamertagData.UnlockData.KillStreamGamerID.Count]);
				}
			}
			else
			{
				this.CurrentGamertagData.UnlockData.KillStreamGamerID = new List<int>();
			}
			this.CurrentGamertagData.UnlockData.BlocksClearedWithWoodPick = (this.cavemanCheck.Checked ? 500 : 0);
			this.CurrentGamertagData.UnlockData.InvadersScore = (this.invadermanCheck.Checked ? 20000 : 0);
			this.CurrentGamertagData.UnlockData.FlowersThrownAtEnemy = (this.hippieCheck.Checked ? 30 : 0);
			this.CurrentGamertagData.UnlockData.DetonationCount = (this.madmanCheck.Checked ? 500 : 0);
			this.CurrentGamertagData.UnlockData.HealedSelf = (this.CurrentGamertagData.UnlockData.HealedOther = (this.medicCheck.Checked ? 50 : 0));
			this.CurrentGamertagData.UnlockData.KilledDiablo = this.diabloCheck.Checked;
			this.CurrentGamertagData.UnlockData.PlayersSavedFromDeath = (this.angelCheck.Checked ? 15 : 0);
			this.CurrentGamertagData.UnlockData.EnemiesKilledWhileHangingFromRope = (this.cowboyCheck.Checked ? 50 : 0);
			this.CurrentGamertagData.UnlockData.GoldEarned = (this.entrepreneurCheck.Checked ? 1000000 : 0);
			this.CurrentGamertagData.UnlockData.EntrepreneurUnlocked = this.entrepreneurCheck.Checked;
			this.CurrentGamertagData.UnlockData.GoldenKnightUnlocked = this.goldenknightCheck.Checked;
			this.CurrentGamertagData.UnlockData.SetHandymanUnlocked(this.handymanCheck.Checked);
			if (this.indianCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.ArrowsCrafted = 200;
				this.CurrentGamertagData.UnlockData.EnemiesKilledWithArrow = 50;
				this.CurrentGamertagData.UnlockData.ActionLog.AddAction(Item.WoodBow, ItemAction.Crafted);
			}
			else
			{
				this.CurrentGamertagData.UnlockData.ArrowsCrafted = 0;
				this.CurrentGamertagData.UnlockData.EnemiesKilledWithArrow = 0;
				if (this.CurrentGamertagData.UnlockData.HasDoneAction(Item.WoodBow, ItemAction.Crafted))
				{
					this.CurrentGamertagData.UnlockData.ActionLog.RemoveAction(Item.WoodBow, ItemAction.Crafted);
				}
			}
			this.CurrentGamertagData.UnlockData.SageUnlocked = this.sageCheck.Checked;
			if (this.knightCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.KnightUnlocked = true;
				this.CurrentGamertagData.UnlockData.BedrockReached = true;
				this.CurrentGamertagData.UnlockData.EnemiesKilledBeforeReachingBedrock = 50;
			}
			else
			{
				this.CurrentGamertagData.UnlockData.KnightUnlocked = false;
				this.CurrentGamertagData.UnlockData.BedrockReached = false;
				this.CurrentGamertagData.UnlockData.EnemiesKilledBeforeReachingBedrock = 0;
			}
			this.CurrentGamertagData.UnlockData.WisdomFound = (this.sageCheck.Checked ? 49 : 0);
			if (this.soldierCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.GrenadesLaunched = 50;
				this.CurrentGamertagData.UnlockData.GrenadesCrafted = 50;
				if (!this.CurrentGamertagData.UnlockData.HasDoneAction(Item.GrenadeLauncher, ItemAction.Crafted))
				{
					this.CurrentGamertagData.UnlockData.ActionLog.AddAction(Item.GrenadeLauncher, ItemAction.Crafted);
				}
			}
			else
			{
				this.CurrentGamertagData.UnlockData.GrenadesCrafted = 0;
				this.CurrentGamertagData.UnlockData.GrenadesLaunched = 0;
				if (this.CurrentGamertagData.UnlockData.HasDoneAction(Item.GrenadeLauncher, ItemAction.Crafted))
				{
					this.CurrentGamertagData.UnlockData.ActionLog.RemoveAction(Item.GrenadeLauncher, ItemAction.Crafted);
				}
			}
			this.CurrentGamertagData.UnlockData.EnemiesKilledWithGrenadeLauncher = (this.terminatorCheck.Checked ? 200 : 0);
			this.CurrentGamertagData.UnlockData.SurvivalDaysSurvived = (this.zombieCheck.Checked ? 5 : 0);
			if (this.demigodCheck.Checked)
			{
				this.CurrentGamertagData.UnlockData.ZuesPlaced = true;
				this.CurrentGamertagData.UnlockData.BadBoy = BadBoyType.None;
				return;
			}
			this.CurrentGamertagData.UnlockData.ZuesPlaced = false;
			this.CurrentGamertagData.UnlockData.BadBoy = BadBoyType.NoDemi;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005448 File Offset: 0x00003648
		private void LoadGmaertagDataSkillsList()
		{
			for (int i = 0; i < 16; i++)
			{
				this.gamertagDataSkillsBox.Items.Add(this.SkillNames[i]);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000547C File Offset: 0x0000367C
		private void LoadGamertagDataTags()
		{
			this.gamertagDataGamertags.Items.Clear();
			this.gamertagDataGamertags.BeginUpdate();
			for (int i = 0; i < this.SaveData.GamertagData.Gamertags.Count; i++)
			{
				this.gamertagDataGamertags.Items.Add(this.SaveData.GamertagData.Gamertags[i].Gamertag);
			}
			this.gamertagDataGamertags.SelectedIndex = 0;
			this.gamertagDataGamertags.EndUpdate();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005508 File Offset: 0x00003708
		private GamertagData GetGamertagDataFromGamertag(string gamertag)
		{
			if (this.SaveData == null || this.SaveData.GamertagData == null)
			{
				return null;
			}
			foreach (GamertagData gamertagData in this.SaveData.GamertagData.Gamertags)
			{
				if (gamertagData.Gamertag == gamertag)
				{
					return gamertagData;
				}
			}
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000558C File Offset: 0x0000378C
		private void gamertagDataGamertags_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SaveCurrentGamertagState();
			this.CurrentGamertagData = this.GetGamertagDataFromGamertag(this.gamertagDataGamertags.SelectedItem.ToString());
			this.LoadNewGamertagDataState();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000055B8 File Offset: 0x000037B8
		private void gamertagDataSkillsBox_AfterLabelEdit(object sender, BetterListViewLabelEditEventArgs eventArgs)
		{
			int num;
			bool flag = int.TryParse(eventArgs.Label, out num);
			if (!flag || num > 99 || num <= 0)
			{
				eventArgs.SubItem.Text = ((num > 99) ? "99" : "1");
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000055FC File Offset: 0x000037FC
		private void maxLabel_Click(object sender, EventArgs e)
		{
			this.gamertagDataSkillsBox.BeginUpdate();
			for (int i = 0; i < this.gamertagDataSkillsBox.Items.Count; i++)
			{
				this.gamertagDataSkillsBox.Items[i].SubItems[1].Text = "99";
			}
			this.gamertagDataSkillsBox.EndUpdate();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005660 File Offset: 0x00003860
		private void headerDatOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Open Header.dat file...";
			openFileDialog.Filter = "|*.dat|All files|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.HeaderDatStream = File.Open(openFileDialog.FileName, FileMode.Open);
				this.SaveData.OpenHeaderDAT(this.HeaderDatStream);
				this.LoadHeaderDatTab();
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000056BC File Offset: 0x000038BC
		private void headerDatSaveNew_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "|*.dat";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Stream stream = File.Create(saveFileDialog.FileName);
				this.SaveHeaderDAT();
				this.SaveData.Header.WriteData(stream);
				stream.Close();
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000570C File Offset: 0x0000390C
		private void headerDatSaveCurrent_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to overwrite your save file?", "Overwrite - Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			this.HeaderDatStream.SetLength(0L);
			this.SaveHeaderDAT();
			this.SaveData.Header.WriteData(this.HeaderDatStream);
			MessageBox.Show("File Over-Written!", "File Save - Success", MessageBoxButtons.OK);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005768 File Offset: 0x00003968
		private void bluePrintsButton_Click(object sender, EventArgs e)
		{
			HeaderDatBlueprints headerDatBlueprints = new HeaderDatBlueprints(this.SaveData.Header.GameState.Blueprints, this.itemImages);
			headerDatBlueprints.Location = Cursor.Position;
			headerDatBlueprints.ShowDialog();
			this.SaveData.Header.GameState.Blueprints = headerDatBlueprints.BlueprintStates;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000057C4 File Offset: 0x000039C4
		private void headerDatClose_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to close the current file?", "Close File - Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}
			this.SaveData.Header = null;
			this.headerDatPanel.Enabled = false;
			this.headerDatSave.Enabled = false;
			this.headerDatClose.Enabled = false;
			this.mapOwnerTextBox.Text = "";
			this.gameModeBox.SelectedIndex = 0;
			this.HeaderDatStream.Close();
			foreach (object obj in this.headerDatPanel.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(PictureBox) && control.Name.StartsWith("itemHolder"))
				{
					control.Tag = new object[]
					{
						null,
						null,
						-1,
						-1,
						0,
						0
					};
					((PictureBox)control).Image = null;
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000058E8 File Offset: 0x00003AE8
		private void LoadHeaderDatTab()
		{
			this.headerDatSave.Enabled = true;
			this.headerDatClose.Enabled = true;
			this.headerDatPanel.Enabled = true;
			foreach (SaveInventoryItem saveInventoryItem in this.SaveData.Header.GameState.SpawnInventory.Items)
			{
				PictureBox pictureBox = (PictureBox)base.Controls.Find(string.Format("itemHolder{0}", (int)(saveInventoryItem.SlotID + 37)), true)[0];
				string text = ((Item)saveInventoryItem.ItemID).ToString();
				int imageIndexFromItemID = Globals.ItemData.GetImageIndexFromItemID(text);
				int num = 1;
				foreach (ItemDataXML itemDataXML in Globals.ItemData.ArrayOfItemDataXML)
				{
					if (itemDataXML.ItemID == text)
					{
						num = itemDataXML.StackSize;
						break;
					}
				}
				ushort itemMaxDurability = this.GetItemMaxDurability(text);
				pictureBox.Tag = new object[]
				{
					text,
					imageIndexFromItemID,
					saveInventoryItem.Count,
					num,
					saveInventoryItem.Durability,
					itemMaxDurability
				};
				pictureBox.Image = this.itemImages.Images[(int)((object[])pictureBox.Tag)[1]];
				pictureBox.ContextMenuStrip = this.context_itemHolderOptions;
				pictureBox.Refresh();
			}
			this.gameModeBox.SelectedIndex = (int)this.SaveData.Header.GameMode;
			this.mapOwnerTextBox.Text = this.SaveData.Header.OwnerGamerTag;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005ADC File Offset: 0x00003CDC
		private void SaveHeaderDAT()
		{
			this.SaveData.Header.GameState.SpawnInventory.Items.Clear();
			foreach (object obj in this.headerDatPanel.Controls)
			{
				Control control = (Control)obj;
				if (control.GetType() == typeof(PictureBox) && control.Name.StartsWith("itemHolder"))
				{
					ushort num = ushort.Parse(control.Name.Substring(10));
					num -= 37;
					string text = (string)((object[])control.Tag)[0];
					if (text != null)
					{
						ushort itemID = (ushort)Enum.Parse(typeof(Item), text);
						int count = (int)((object[])control.Tag)[2];
						int num2 = (int)((object[])control.Tag)[3];
						ushort durability = (ushort)((object[])control.Tag)[4];
						SaveInventoryItem item = default(SaveInventoryItem);
						item.SlotID = num;
						item.Count = count;
						item.ItemID = itemID;
						item.Durability = durability;
						this.SaveData.Header.GameState.SpawnInventory.Items.Add(item);
					}
				}
			}
			this.SaveData.Header.GameMode = (GameMode)this.gameModeBox.SelectedIndex;
			this.SaveData.Header.OwnerGamerTag = this.mapOwnerTextBox.Text;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005C9C File Offset: 0x00003E9C
		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			switch (this.tabControl1.SelectedIndex)
			{
			case 0:
				if (this.inventoryVisualItems.Parent != this.playerDatPanel)
				{
					this.inventoryVisualItems.Parent = this.playerDatPanel;
					this.inventoryVisualItemSearchBox.Parent = this.playerDatPanel;
					this.label13.Parent = this.playerDatPanel;
					return;
				}
				break;
			case 1:
				break;
			case 2:
				if (this.inventoryVisualItems.Parent != this.headerDatPanel)
				{
					this.inventoryVisualItems.Parent = this.headerDatPanel;
					this.inventoryVisualItemSearchBox.Parent = this.headerDatPanel;
					this.label13.Parent = this.headerDatPanel;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x04000021 RID: 33
		private TMF SaveData;

		// Token: 0x04000022 RID: 34
		private SavePlayerState CurrentPlayerDATPlayerSaveState;

		// Token: 0x04000023 RID: 35
		private GamertagData CurrentGamertagData;

		// Token: 0x04000024 RID: 36
		private string[] SkillNames = new string[]
		{
			"Combat",
			"Health",
			"Strength",
			"Attack",
			"Defence",
			"Ranged",
			"Mining",
			"Digging",
			"Chopping",
			"Building",
			"Crafting",
			"Smelting",
			"Smithing",
			"Farming",
			"Cooking",
			"Looting"
		};

		// Token: 0x04000025 RID: 37
		private Stream PlayerDatStream;

		// Token: 0x04000026 RID: 38
		private Stream GamertagDataStream;

		// Token: 0x04000027 RID: 39
		private Stream HeaderDatStream;

		// Token: 0x04000028 RID: 40
		private List<BetterListViewItem> playerDatSelectedItems = new List<BetterListViewItem>();

		// Token: 0x04000029 RID: 41
		private int playerDatselectedItemIndex;
	}
}
