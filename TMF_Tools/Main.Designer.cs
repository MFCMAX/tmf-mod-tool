namespace TMF_Tools
{
	// Token: 0x0200000A RID: 10
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00005D55 File Offset: 0x00003F55
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005D74 File Offset: 0x00003F74
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::TMF_Tools.Main));
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.playerDatPanel = new global::System.Windows.Forms.Panel();
			this.label13 = new global::System.Windows.Forms.Label();
			this.inventoryVisualItems = new global::ComponentOwl.BetterListView.BetterListView();
			this.itemImages = new global::System.Windows.Forms.ImageList(this.components);
			this.inventoryVisualItemSearchBox = new global::System.Windows.Forms.TextBox();
			this.itemHolder30 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder31 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder34 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder33 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder36 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder32 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder35 = new global::System.Windows.Forms.PictureBox();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.currentHoverItem = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.itemHolder29 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder28 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder27 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder26 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder25 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder24 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder22 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder23 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder21 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder20 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.itemHolder19 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder18 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder17 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder16 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder15 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder14 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder12 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder13 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder11 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder10 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder9 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder8 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder7 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder6 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder5 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder4 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder2 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder3 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder1 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder0 = new global::System.Windows.Forms.PictureBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.playerDatListBox = new global::System.Windows.Forms.ComboBox();
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.playerDatOpen = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PlayerDatSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.playerDatSaveCurrent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.playerDatSaveNew = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.playerDatClose = new global::System.Windows.Forms.ToolStripMenuItem();
			this.playerDatVariables = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.gamertagDataPanel = new global::System.Windows.Forms.Panel();
			this.gamertagDataUnlocksPanel = new global::System.Windows.Forms.Panel();
			this.lastPage = new global::System.Windows.Forms.Label();
			this.unlockPage1 = new global::System.Windows.Forms.Panel();
			this.explorerCheck = new global::System.Windows.Forms.CheckBox();
			this.zombieCheck = new global::System.Windows.Forms.CheckBox();
			this.treeHuggerCheck = new global::System.Windows.Forms.CheckBox();
			this.terminatorCheck = new global::System.Windows.Forms.CheckBox();
			this.carpenterCheck = new global::System.Windows.Forms.CheckBox();
			this.soldierCheck = new global::System.Windows.Forms.CheckBox();
			this.prisonerCheck = new global::System.Windows.Forms.CheckBox();
			this.knightCheck = new global::System.Windows.Forms.CheckBox();
			this.pupilCheck = new global::System.Windows.Forms.CheckBox();
			this.sageCheck = new global::System.Windows.Forms.CheckBox();
			this.jamaicanCheck = new global::System.Windows.Forms.CheckBox();
			this.indianCheck = new global::System.Windows.Forms.CheckBox();
			this.lumberjackCheck = new global::System.Windows.Forms.CheckBox();
			this.handymanCheck = new global::System.Windows.Forms.CheckBox();
			this.pirateCheck = new global::System.Windows.Forms.CheckBox();
			this.goldenknightCheck = new global::System.Windows.Forms.CheckBox();
			this.refugeeCheck = new global::System.Windows.Forms.CheckBox();
			this.entrepreneurCheck = new global::System.Windows.Forms.CheckBox();
			this.kingCheck = new global::System.Windows.Forms.CheckBox();
			this.angelCheck = new global::System.Windows.Forms.CheckBox();
			this.astronautCheck = new global::System.Windows.Forms.CheckBox();
			this.cowboyCheck = new global::System.Windows.Forms.CheckBox();
			this.ninjaCheck = new global::System.Windows.Forms.CheckBox();
			this.diabloCheck = new global::System.Windows.Forms.CheckBox();
			this.cavemanCheck = new global::System.Windows.Forms.CheckBox();
			this.medicCheck = new global::System.Windows.Forms.CheckBox();
			this.chefCheck = new global::System.Windows.Forms.CheckBox();
			this.invadermanCheck = new global::System.Windows.Forms.CheckBox();
			this.madmanCheck = new global::System.Windows.Forms.CheckBox();
			this.hippieCheck = new global::System.Windows.Forms.CheckBox();
			this.nextPage = new global::System.Windows.Forms.Label();
			this.unlockPage2 = new global::System.Windows.Forms.Panel();
			this.demigodCheck = new global::System.Windows.Forms.CheckBox();
			this.unlockAllButton = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.maxLabel = new global::System.Windows.Forms.Label();
			this.gamertagDataSkillsBox = new global::ComponentOwl.BetterListView.BetterListView();
			this.betterListViewColumnHeader1 = new global::ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.betterListViewColumnHeader2 = new global::ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.label11 = new global::System.Windows.Forms.Label();
			this.gamertagDataGamertags = new global::System.Windows.Forms.ComboBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.menuStrip2 = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gamertagdataOpen = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gamertagDataSaveButton = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gamertagDataCurrentFile = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gamertagDataNewFile = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.gamertagDataCloseButton = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.headerDatPanel = new global::System.Windows.Forms.Panel();
			this.bluePrintsButton = new global::System.Windows.Forms.Button();
			this.statusStrip2 = new global::System.Windows.Forms.StatusStrip();
			this.headerDatCurrentItem = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.itemHolder66 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder65 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder64 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder63 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder62 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder61 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder59 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder60 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder58 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder57 = new global::System.Windows.Forms.PictureBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.itemHolder56 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder55 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder54 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder53 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder52 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder51 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder49 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder50 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder48 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder47 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder46 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder45 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder44 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder43 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder42 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder41 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder39 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder40 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder38 = new global::System.Windows.Forms.PictureBox();
			this.itemHolder37 = new global::System.Windows.Forms.PictureBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.menuStrip3 = new global::System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.headerDatOpen = new global::System.Windows.Forms.ToolStripMenuItem();
			this.headerDatSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.headerDatSaveCurrent = new global::System.Windows.Forms.ToolStripMenuItem();
			this.headerDatSaveNew = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.headerDatClose = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.context_itemHolderOptions = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.editAmountToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.editDurabilityToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.skillIcons = new global::System.Windows.Forms.ImageList(this.components);
			this.label16 = new global::System.Windows.Forms.Label();
			this.mapOwnerTextBox = new global::System.Windows.Forms.TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.gameModeBox = new global::System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.playerDatPanel.SuspendLayout();
			this.inventoryVisualItems.BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder30).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder31).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder34).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder33).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder36).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder32).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder35).BeginInit();
			this.statusStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder29).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder28).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder27).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder26).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder25).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder24).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder22).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder23).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder21).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder20).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder19).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder18).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder17).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder16).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder15).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder14).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder12).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder13).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder11).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder10).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder9).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder8).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder6).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder0).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.gamertagDataPanel.SuspendLayout();
			this.gamertagDataUnlocksPanel.SuspendLayout();
			this.unlockPage1.SuspendLayout();
			this.unlockPage2.SuspendLayout();
			this.gamertagDataSkillsBox.BeginInit();
			this.menuStrip2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.headerDatPanel.SuspendLayout();
			this.statusStrip2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder66).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder65).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder64).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder63).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder62).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder61).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder59).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder60).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder58).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder57).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder56).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder55).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder54).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder53).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder52).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder51).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder49).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder50).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder48).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder47).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder46).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder45).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder44).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder43).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder42).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder41).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder39).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder40).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder38).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder37).BeginInit();
			this.menuStrip3.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.context_itemHolderOptions.SuspendLayout();
			base.SuspendLayout();
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(979, 381);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Selected += new global::System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			this.tabPage1.Controls.Add(this.playerDatPanel);
			this.tabPage1.Controls.Add(this.menuStrip1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(971, 350);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Player.DAT";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.playerDatPanel.Controls.Add(this.label13);
			this.playerDatPanel.Controls.Add(this.inventoryVisualItems);
			this.playerDatPanel.Controls.Add(this.inventoryVisualItemSearchBox);
			this.playerDatPanel.Controls.Add(this.itemHolder30);
			this.playerDatPanel.Controls.Add(this.itemHolder31);
			this.playerDatPanel.Controls.Add(this.itemHolder34);
			this.playerDatPanel.Controls.Add(this.itemHolder33);
			this.playerDatPanel.Controls.Add(this.itemHolder36);
			this.playerDatPanel.Controls.Add(this.itemHolder32);
			this.playerDatPanel.Controls.Add(this.itemHolder35);
			this.playerDatPanel.Controls.Add(this.statusStrip1);
			this.playerDatPanel.Controls.Add(this.itemHolder29);
			this.playerDatPanel.Controls.Add(this.itemHolder28);
			this.playerDatPanel.Controls.Add(this.itemHolder27);
			this.playerDatPanel.Controls.Add(this.itemHolder26);
			this.playerDatPanel.Controls.Add(this.itemHolder25);
			this.playerDatPanel.Controls.Add(this.itemHolder24);
			this.playerDatPanel.Controls.Add(this.itemHolder22);
			this.playerDatPanel.Controls.Add(this.itemHolder23);
			this.playerDatPanel.Controls.Add(this.itemHolder21);
			this.playerDatPanel.Controls.Add(this.itemHolder20);
			this.playerDatPanel.Controls.Add(this.label3);
			this.playerDatPanel.Controls.Add(this.itemHolder19);
			this.playerDatPanel.Controls.Add(this.itemHolder18);
			this.playerDatPanel.Controls.Add(this.itemHolder17);
			this.playerDatPanel.Controls.Add(this.itemHolder16);
			this.playerDatPanel.Controls.Add(this.itemHolder15);
			this.playerDatPanel.Controls.Add(this.itemHolder14);
			this.playerDatPanel.Controls.Add(this.itemHolder12);
			this.playerDatPanel.Controls.Add(this.itemHolder13);
			this.playerDatPanel.Controls.Add(this.itemHolder11);
			this.playerDatPanel.Controls.Add(this.itemHolder10);
			this.playerDatPanel.Controls.Add(this.itemHolder9);
			this.playerDatPanel.Controls.Add(this.itemHolder8);
			this.playerDatPanel.Controls.Add(this.itemHolder7);
			this.playerDatPanel.Controls.Add(this.itemHolder6);
			this.playerDatPanel.Controls.Add(this.itemHolder5);
			this.playerDatPanel.Controls.Add(this.itemHolder4);
			this.playerDatPanel.Controls.Add(this.itemHolder2);
			this.playerDatPanel.Controls.Add(this.itemHolder3);
			this.playerDatPanel.Controls.Add(this.itemHolder1);
			this.playerDatPanel.Controls.Add(this.itemHolder0);
			this.playerDatPanel.Controls.Add(this.label2);
			this.playerDatPanel.Controls.Add(this.label1);
			this.playerDatPanel.Controls.Add(this.playerDatListBox);
			this.playerDatPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.playerDatPanel.Enabled = false;
			this.playerDatPanel.Location = new global::System.Drawing.Point(3, 30);
			this.playerDatPanel.Name = "playerDatPanel";
			this.playerDatPanel.Size = new global::System.Drawing.Size(965, 317);
			this.playerDatPanel.TabIndex = 3;
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.Location = new global::System.Drawing.Point(666, 9);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(49, 15);
			this.label13.TabIndex = 47;
			this.label13.Text = "Search:";
			this.inventoryVisualItems.AllowDrag = true;
			this.inventoryVisualItems.AllowDrop = true;
			this.inventoryVisualItems.GridLines = 1;
			this.inventoryVisualItems.ImageList = this.itemImages;
			this.inventoryVisualItems.ImageListColumns = this.itemImages;
			this.inventoryVisualItems.Location = new global::System.Drawing.Point(716, 30);
			this.inventoryVisualItems.MultiSelect = false;
			this.inventoryVisualItems.Name = "inventoryVisualItems";
			this.inventoryVisualItems.Size = new global::System.Drawing.Size(241, 256);
			this.inventoryVisualItems.TabIndex = 46;
			this.inventoryVisualItems.ItemDrag += new global::ComponentOwl.BetterListView.BetterListViewItemDragEventHandler(this.inventoryVisualItems_ItemDrag);
			this.itemImages.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("itemImages.ImageStream");
			this.itemImages.TransparentColor = global::System.Drawing.Color.Transparent;
			this.itemImages.Images.SetKeyName(0, "InvalidItem.png");
			this.itemImages.Images.SetKeyName(1, "0.png");
			this.itemImages.Images.SetKeyName(2, "1.png");
			this.itemImages.Images.SetKeyName(3, "2.png");
			this.itemImages.Images.SetKeyName(4, "3.png");
			this.itemImages.Images.SetKeyName(5, "4.png");
			this.itemImages.Images.SetKeyName(6, "5.png");
			this.itemImages.Images.SetKeyName(7, "6.png");
			this.itemImages.Images.SetKeyName(8, "7.png");
			this.itemImages.Images.SetKeyName(9, "8.png");
			this.itemImages.Images.SetKeyName(10, "9.png");
			this.itemImages.Images.SetKeyName(11, "10.png");
			this.itemImages.Images.SetKeyName(12, "11.png");
			this.itemImages.Images.SetKeyName(13, "12.png");
			this.itemImages.Images.SetKeyName(14, "13.png");
			this.itemImages.Images.SetKeyName(15, "14.png");
			this.itemImages.Images.SetKeyName(16, "15.png");
			this.itemImages.Images.SetKeyName(17, "16.png");
			this.itemImages.Images.SetKeyName(18, "17.png");
			this.itemImages.Images.SetKeyName(19, "18.png");
			this.itemImages.Images.SetKeyName(20, "19.png");
			this.itemImages.Images.SetKeyName(21, "20.png");
			this.itemImages.Images.SetKeyName(22, "21.png");
			this.itemImages.Images.SetKeyName(23, "22.png");
			this.itemImages.Images.SetKeyName(24, "23.png");
			this.itemImages.Images.SetKeyName(25, "24.png");
			this.itemImages.Images.SetKeyName(26, "25.png");
			this.itemImages.Images.SetKeyName(27, "26.png");
			this.itemImages.Images.SetKeyName(28, "27.png");
			this.itemImages.Images.SetKeyName(29, "28.png");
			this.itemImages.Images.SetKeyName(30, "29.png");
			this.itemImages.Images.SetKeyName(31, "30.png");
			this.itemImages.Images.SetKeyName(32, "31.png");
			this.itemImages.Images.SetKeyName(33, "32.png");
			this.itemImages.Images.SetKeyName(34, "33.png");
			this.itemImages.Images.SetKeyName(35, "34.png");
			this.itemImages.Images.SetKeyName(36, "35.png");
			this.itemImages.Images.SetKeyName(37, "36.png");
			this.itemImages.Images.SetKeyName(38, "37.png");
			this.itemImages.Images.SetKeyName(39, "38.png");
			this.itemImages.Images.SetKeyName(40, "39.png");
			this.itemImages.Images.SetKeyName(41, "40.png");
			this.itemImages.Images.SetKeyName(42, "41.png");
			this.itemImages.Images.SetKeyName(43, "42.png");
			this.itemImages.Images.SetKeyName(44, "43.png");
			this.itemImages.Images.SetKeyName(45, "44.png");
			this.itemImages.Images.SetKeyName(46, "45.png");
			this.itemImages.Images.SetKeyName(47, "46.png");
			this.itemImages.Images.SetKeyName(48, "47.png");
			this.itemImages.Images.SetKeyName(49, "48.png");
			this.itemImages.Images.SetKeyName(50, "49.png");
			this.itemImages.Images.SetKeyName(51, "50.png");
			this.itemImages.Images.SetKeyName(52, "51.png");
			this.itemImages.Images.SetKeyName(53, "52.png");
			this.itemImages.Images.SetKeyName(54, "53.png");
			this.itemImages.Images.SetKeyName(55, "54.png");
			this.itemImages.Images.SetKeyName(56, "55.png");
			this.itemImages.Images.SetKeyName(57, "56.png");
			this.itemImages.Images.SetKeyName(58, "57.png");
			this.itemImages.Images.SetKeyName(59, "58.png");
			this.itemImages.Images.SetKeyName(60, "59.png");
			this.itemImages.Images.SetKeyName(61, "60.png");
			this.itemImages.Images.SetKeyName(62, "61.png");
			this.itemImages.Images.SetKeyName(63, "62.png");
			this.itemImages.Images.SetKeyName(64, "63.png");
			this.itemImages.Images.SetKeyName(65, "64.png");
			this.itemImages.Images.SetKeyName(66, "65.png");
			this.itemImages.Images.SetKeyName(67, "66.png");
			this.itemImages.Images.SetKeyName(68, "67.png");
			this.itemImages.Images.SetKeyName(69, "68.png");
			this.itemImages.Images.SetKeyName(70, "69.png");
			this.itemImages.Images.SetKeyName(71, "70.png");
			this.itemImages.Images.SetKeyName(72, "71.png");
			this.itemImages.Images.SetKeyName(73, "72.png");
			this.itemImages.Images.SetKeyName(74, "73.png");
			this.itemImages.Images.SetKeyName(75, "74.png");
			this.itemImages.Images.SetKeyName(76, "75.png");
			this.itemImages.Images.SetKeyName(77, "76.png");
			this.itemImages.Images.SetKeyName(78, "77.png");
			this.itemImages.Images.SetKeyName(79, "78.png");
			this.itemImages.Images.SetKeyName(80, "79.png");
			this.itemImages.Images.SetKeyName(81, "80.png");
			this.itemImages.Images.SetKeyName(82, "81.png");
			this.itemImages.Images.SetKeyName(83, "82.png");
			this.itemImages.Images.SetKeyName(84, "83.png");
			this.itemImages.Images.SetKeyName(85, "84.png");
			this.itemImages.Images.SetKeyName(86, "85.png");
			this.itemImages.Images.SetKeyName(87, "86.png");
			this.itemImages.Images.SetKeyName(88, "87.png");
			this.itemImages.Images.SetKeyName(89, "88.png");
			this.itemImages.Images.SetKeyName(90, "89.png");
			this.itemImages.Images.SetKeyName(91, "90.png");
			this.itemImages.Images.SetKeyName(92, "91.png");
			this.itemImages.Images.SetKeyName(93, "92.png");
			this.itemImages.Images.SetKeyName(94, "93.png");
			this.itemImages.Images.SetKeyName(95, "94.png");
			this.itemImages.Images.SetKeyName(96, "95.png");
			this.itemImages.Images.SetKeyName(97, "96.png");
			this.itemImages.Images.SetKeyName(98, "97.png");
			this.itemImages.Images.SetKeyName(99, "98.png");
			this.itemImages.Images.SetKeyName(100, "99.png");
			this.itemImages.Images.SetKeyName(101, "100.png");
			this.itemImages.Images.SetKeyName(102, "101.png");
			this.itemImages.Images.SetKeyName(103, "102.png");
			this.itemImages.Images.SetKeyName(104, "103.png");
			this.itemImages.Images.SetKeyName(105, "104.png");
			this.itemImages.Images.SetKeyName(106, "105.png");
			this.itemImages.Images.SetKeyName(107, "106.png");
			this.itemImages.Images.SetKeyName(108, "107.png");
			this.itemImages.Images.SetKeyName(109, "108.png");
			this.itemImages.Images.SetKeyName(110, "109.png");
			this.itemImages.Images.SetKeyName(111, "110.png");
			this.itemImages.Images.SetKeyName(112, "111.png");
			this.itemImages.Images.SetKeyName(113, "112.png");
			this.itemImages.Images.SetKeyName(114, "113.png");
			this.itemImages.Images.SetKeyName(115, "114.png");
			this.itemImages.Images.SetKeyName(116, "115.png");
			this.itemImages.Images.SetKeyName(117, "116.png");
			this.itemImages.Images.SetKeyName(118, "117.png");
			this.itemImages.Images.SetKeyName(119, "118.png");
			this.itemImages.Images.SetKeyName(120, "119.png");
			this.itemImages.Images.SetKeyName(121, "120.png");
			this.itemImages.Images.SetKeyName(122, "121.png");
			this.itemImages.Images.SetKeyName(123, "122.png");
			this.itemImages.Images.SetKeyName(124, "123.png");
			this.itemImages.Images.SetKeyName(125, "124.png");
			this.itemImages.Images.SetKeyName(126, "125.png");
			this.itemImages.Images.SetKeyName(127, "126.png");
			this.itemImages.Images.SetKeyName(128, "127.png");
			this.itemImages.Images.SetKeyName(129, "128.png");
			this.itemImages.Images.SetKeyName(130, "129.png");
			this.itemImages.Images.SetKeyName(131, "130.png");
			this.itemImages.Images.SetKeyName(132, "131.png");
			this.itemImages.Images.SetKeyName(133, "132.png");
			this.itemImages.Images.SetKeyName(134, "133.png");
			this.itemImages.Images.SetKeyName(135, "134.png");
			this.itemImages.Images.SetKeyName(136, "135.png");
			this.itemImages.Images.SetKeyName(137, "136.png");
			this.itemImages.Images.SetKeyName(138, "137.png");
			this.itemImages.Images.SetKeyName(139, "138.png");
			this.itemImages.Images.SetKeyName(140, "139.png");
			this.itemImages.Images.SetKeyName(141, "140.png");
			this.itemImages.Images.SetKeyName(142, "141.png");
			this.itemImages.Images.SetKeyName(143, "142.png");
			this.itemImages.Images.SetKeyName(144, "143.png");
			this.itemImages.Images.SetKeyName(145, "144.png");
			this.itemImages.Images.SetKeyName(146, "145.png");
			this.itemImages.Images.SetKeyName(147, "146.png");
			this.itemImages.Images.SetKeyName(148, "147.png");
			this.itemImages.Images.SetKeyName(149, "148.png");
			this.itemImages.Images.SetKeyName(150, "149.png");
			this.itemImages.Images.SetKeyName(151, "150.png");
			this.itemImages.Images.SetKeyName(152, "151.png");
			this.itemImages.Images.SetKeyName(153, "152.png");
			this.itemImages.Images.SetKeyName(154, "153.png");
			this.itemImages.Images.SetKeyName(155, "154.png");
			this.itemImages.Images.SetKeyName(156, "155.png");
			this.itemImages.Images.SetKeyName(157, "156.png");
			this.itemImages.Images.SetKeyName(158, "157.png");
			this.itemImages.Images.SetKeyName(159, "158.png");
			this.itemImages.Images.SetKeyName(160, "159.png");
			this.itemImages.Images.SetKeyName(161, "160.png");
			this.itemImages.Images.SetKeyName(162, "161.png");
			this.itemImages.Images.SetKeyName(163, "162.png");
			this.itemImages.Images.SetKeyName(164, "163.png");
			this.itemImages.Images.SetKeyName(165, "164.png");
			this.itemImages.Images.SetKeyName(166, "165.png");
			this.itemImages.Images.SetKeyName(167, "166.png");
			this.itemImages.Images.SetKeyName(168, "167.png");
			this.itemImages.Images.SetKeyName(169, "168.png");
			this.itemImages.Images.SetKeyName(170, "169.png");
			this.itemImages.Images.SetKeyName(171, "170.png");
			this.itemImages.Images.SetKeyName(172, "171.png");
			this.itemImages.Images.SetKeyName(173, "172.png");
			this.itemImages.Images.SetKeyName(174, "173.png");
			this.itemImages.Images.SetKeyName(175, "174.png");
			this.itemImages.Images.SetKeyName(176, "175.png");
			this.itemImages.Images.SetKeyName(177, "176.png");
			this.itemImages.Images.SetKeyName(178, "177.png");
			this.itemImages.Images.SetKeyName(179, "178.png");
			this.itemImages.Images.SetKeyName(180, "179.png");
			this.itemImages.Images.SetKeyName(181, "180.png");
			this.itemImages.Images.SetKeyName(182, "181.png");
			this.itemImages.Images.SetKeyName(183, "182.png");
			this.itemImages.Images.SetKeyName(184, "183.png");
			this.itemImages.Images.SetKeyName(185, "184.png");
			this.itemImages.Images.SetKeyName(186, "185.png");
			this.itemImages.Images.SetKeyName(187, "186.png");
			this.itemImages.Images.SetKeyName(188, "187.png");
			this.itemImages.Images.SetKeyName(189, "188.png");
			this.itemImages.Images.SetKeyName(190, "189.png");
			this.itemImages.Images.SetKeyName(191, "190.png");
			this.itemImages.Images.SetKeyName(192, "191.png");
			this.itemImages.Images.SetKeyName(193, "192.png");
			this.itemImages.Images.SetKeyName(194, "193.png");
			this.itemImages.Images.SetKeyName(195, "194.png");
			this.itemImages.Images.SetKeyName(196, "195.png");
			this.itemImages.Images.SetKeyName(197, "196.png");
			this.itemImages.Images.SetKeyName(198, "197.png");
			this.itemImages.Images.SetKeyName(199, "198.png");
			this.itemImages.Images.SetKeyName(200, "199.png");
			this.itemImages.Images.SetKeyName(201, "200.png");
			this.itemImages.Images.SetKeyName(202, "201.png");
			this.itemImages.Images.SetKeyName(203, "202.png");
			this.itemImages.Images.SetKeyName(204, "203.png");
			this.itemImages.Images.SetKeyName(205, "204.png");
			this.itemImages.Images.SetKeyName(206, "205.png");
			this.itemImages.Images.SetKeyName(207, "206.png");
			this.itemImages.Images.SetKeyName(208, "207.png");
			this.itemImages.Images.SetKeyName(209, "208.png");
			this.itemImages.Images.SetKeyName(210, "209.png");
			this.itemImages.Images.SetKeyName(211, "210.png");
			this.itemImages.Images.SetKeyName(212, "211.png");
			this.itemImages.Images.SetKeyName(213, "212.png");
			this.itemImages.Images.SetKeyName(214, "213.png");
			this.itemImages.Images.SetKeyName(215, "214.png");
			this.itemImages.Images.SetKeyName(216, "215.png");
			this.itemImages.Images.SetKeyName(217, "216.png");
			this.itemImages.Images.SetKeyName(218, "217.png");
			this.itemImages.Images.SetKeyName(219, "218.png");
			this.itemImages.Images.SetKeyName(220, "219.png");
			this.itemImages.Images.SetKeyName(221, "220.png");
			this.itemImages.Images.SetKeyName(222, "221.png");
			this.itemImages.Images.SetKeyName(223, "222.png");
			this.itemImages.Images.SetKeyName(224, "223.png");
			this.itemImages.Images.SetKeyName(225, "224.png");
			this.itemImages.Images.SetKeyName(226, "225.png");
			this.itemImages.Images.SetKeyName(227, "226.png");
			this.itemImages.Images.SetKeyName(228, "227.png");
			this.itemImages.Images.SetKeyName(229, "228.png");
			this.itemImages.Images.SetKeyName(230, "229.png");
			this.itemImages.Images.SetKeyName(231, "230.png");
			this.itemImages.Images.SetKeyName(232, "231.png");
			this.itemImages.Images.SetKeyName(233, "232.png");
			this.itemImages.Images.SetKeyName(234, "233.png");
			this.itemImages.Images.SetKeyName(235, "234.png");
			this.itemImages.Images.SetKeyName(236, "235.png");
			this.itemImages.Images.SetKeyName(237, "236.png");
			this.itemImages.Images.SetKeyName(238, "237.png");
			this.itemImages.Images.SetKeyName(239, "238.png");
			this.itemImages.Images.SetKeyName(240, "239.png");
			this.itemImages.Images.SetKeyName(241, "240.png");
			this.itemImages.Images.SetKeyName(242, "241.png");
			this.itemImages.Images.SetKeyName(243, "242.png");
			this.itemImages.Images.SetKeyName(244, "243.png");
			this.itemImages.Images.SetKeyName(245, "244.png");
			this.itemImages.Images.SetKeyName(246, "245.png");
			this.itemImages.Images.SetKeyName(247, "246.png");
			this.itemImages.Images.SetKeyName(248, "247.png");
			this.itemImages.Images.SetKeyName(249, "248.png");
			this.itemImages.Images.SetKeyName(250, "249.png");
			this.itemImages.Images.SetKeyName(251, "250.png");
			this.itemImages.Images.SetKeyName(252, "251.png");
			this.itemImages.Images.SetKeyName(253, "252.png");
			this.itemImages.Images.SetKeyName(254, "253.png");
			this.itemImages.Images.SetKeyName(255, "254.png");
			this.itemImages.Images.SetKeyName(256, "255.png");
			this.itemImages.Images.SetKeyName(257, "256.png");
			this.itemImages.Images.SetKeyName(258, "257.png");
			this.itemImages.Images.SetKeyName(259, "258.png");
			this.itemImages.Images.SetKeyName(260, "259.png");
			this.itemImages.Images.SetKeyName(261, "260.png");
			this.itemImages.Images.SetKeyName(262, "261.png");
			this.itemImages.Images.SetKeyName(263, "262.png");
			this.itemImages.Images.SetKeyName(264, "263.png");
			this.itemImages.Images.SetKeyName(265, "264.png");
			this.itemImages.Images.SetKeyName(266, "265.png");
			this.itemImages.Images.SetKeyName(267, "266.png");
			this.itemImages.Images.SetKeyName(268, "267.png");
			this.itemImages.Images.SetKeyName(269, "268.png");
			this.itemImages.Images.SetKeyName(270, "269.png");
			this.itemImages.Images.SetKeyName(271, "270.png");
			this.itemImages.Images.SetKeyName(272, "271.png");
			this.itemImages.Images.SetKeyName(273, "272.png");
			this.itemImages.Images.SetKeyName(274, "273.png");
			this.itemImages.Images.SetKeyName(275, "274.png");
			this.itemImages.Images.SetKeyName(276, "275.png");
			this.itemImages.Images.SetKeyName(277, "276.png");
			this.itemImages.Images.SetKeyName(278, "277.png");
			this.itemImages.Images.SetKeyName(279, "278.png");
			this.itemImages.Images.SetKeyName(280, "279.png");
			this.itemImages.Images.SetKeyName(281, "280.png");
			this.itemImages.Images.SetKeyName(282, "281.png");
			this.itemImages.Images.SetKeyName(283, "282.png");
			this.itemImages.Images.SetKeyName(284, "283.png");
			this.itemImages.Images.SetKeyName(285, "284.png");
			this.itemImages.Images.SetKeyName(286, "285.png");
			this.itemImages.Images.SetKeyName(287, "286.png");
			this.itemImages.Images.SetKeyName(288, "287.png");
			this.itemImages.Images.SetKeyName(289, "288.png");
			this.itemImages.Images.SetKeyName(290, "289.png");
			this.itemImages.Images.SetKeyName(291, "290.png");
			this.itemImages.Images.SetKeyName(292, "291.png");
			this.itemImages.Images.SetKeyName(293, "292.png");
			this.itemImages.Images.SetKeyName(294, "293.png");
			this.itemImages.Images.SetKeyName(295, "294.png");
			this.itemImages.Images.SetKeyName(296, "295.png");
			this.itemImages.Images.SetKeyName(297, "296.png");
			this.itemImages.Images.SetKeyName(298, "297.png");
			this.itemImages.Images.SetKeyName(299, "298.png");
			this.itemImages.Images.SetKeyName(300, "299.png");
			this.itemImages.Images.SetKeyName(301, "300.png");
			this.itemImages.Images.SetKeyName(302, "301.png");
			this.itemImages.Images.SetKeyName(303, "302.png");
			this.itemImages.Images.SetKeyName(304, "303.png");
			this.itemImages.Images.SetKeyName(305, "304.png");
			this.itemImages.Images.SetKeyName(306, "305.png");
			this.itemImages.Images.SetKeyName(307, "306.png");
			this.itemImages.Images.SetKeyName(308, "307.png");
			this.itemImages.Images.SetKeyName(309, "308.png");
			this.itemImages.Images.SetKeyName(310, "309.png");
			this.itemImages.Images.SetKeyName(311, "310.png");
			this.itemImages.Images.SetKeyName(312, "311.png");
			this.itemImages.Images.SetKeyName(313, "312.png");
			this.itemImages.Images.SetKeyName(314, "313.png");
			this.itemImages.Images.SetKeyName(315, "314.png");
			this.itemImages.Images.SetKeyName(316, "315.png");
			this.itemImages.Images.SetKeyName(317, "316.png");
			this.itemImages.Images.SetKeyName(318, "317.png");
			this.itemImages.Images.SetKeyName(319, "318.png");
			this.itemImages.Images.SetKeyName(320, "319.png");
			this.itemImages.Images.SetKeyName(321, "320.png");
			this.itemImages.Images.SetKeyName(322, "321.png");
			this.itemImages.Images.SetKeyName(323, "322.png");
			this.itemImages.Images.SetKeyName(324, "323.png");
			this.itemImages.Images.SetKeyName(325, "324.png");
			this.itemImages.Images.SetKeyName(326, "325.png");
			this.itemImages.Images.SetKeyName(327, "326.png");
			this.itemImages.Images.SetKeyName(328, "327.png");
			this.itemImages.Images.SetKeyName(329, "328.png");
			this.itemImages.Images.SetKeyName(330, "329.png");
			this.itemImages.Images.SetKeyName(331, "330.png");
			this.itemImages.Images.SetKeyName(332, "331.png");
			this.itemImages.Images.SetKeyName(333, "332.png");
			this.itemImages.Images.SetKeyName(334, "333.png");
			this.itemImages.Images.SetKeyName(335, "334.png");
			this.itemImages.Images.SetKeyName(336, "335.png");
			this.itemImages.Images.SetKeyName(337, "336.png");
			this.itemImages.Images.SetKeyName(338, "337.png");
			this.itemImages.Images.SetKeyName(339, "338.png");
			this.itemImages.Images.SetKeyName(340, "339.png");
			this.itemImages.Images.SetKeyName(341, "340.png");
			this.itemImages.Images.SetKeyName(342, "341.png");
			this.itemImages.Images.SetKeyName(343, "342.png");
			this.itemImages.Images.SetKeyName(344, "343.png");
			this.itemImages.Images.SetKeyName(345, "344.png");
			this.itemImages.Images.SetKeyName(346, "345.png");
			this.itemImages.Images.SetKeyName(347, "346.png");
			this.itemImages.Images.SetKeyName(348, "347.png");
			this.itemImages.Images.SetKeyName(349, "348.png");
			this.itemImages.Images.SetKeyName(350, "349.png");
			this.itemImages.Images.SetKeyName(351, "350.png");
			this.itemImages.Images.SetKeyName(352, "351.png");
			this.itemImages.Images.SetKeyName(353, "352.png");
			this.itemImages.Images.SetKeyName(354, "353.png");
			this.itemImages.Images.SetKeyName(355, "354.png");
			this.itemImages.Images.SetKeyName(356, "355.png");
			this.itemImages.Images.SetKeyName(357, "356.png");
			this.itemImages.Images.SetKeyName(358, "357.png");
			this.itemImages.Images.SetKeyName(359, "358.png");
			this.itemImages.Images.SetKeyName(360, "359.png");
			this.itemImages.Images.SetKeyName(361, "360.png");
			this.itemImages.Images.SetKeyName(362, "361.png");
			this.itemImages.Images.SetKeyName(363, "362.png");
			this.itemImages.Images.SetKeyName(364, "363.png");
			this.itemImages.Images.SetKeyName(365, "364.png");
			this.itemImages.Images.SetKeyName(366, "365.png");
			this.itemImages.Images.SetKeyName(367, "366.png");
			this.itemImages.Images.SetKeyName(368, "367.png");
			this.itemImages.Images.SetKeyName(369, "368.png");
			this.inventoryVisualItemSearchBox.Location = new global::System.Drawing.Point(716, 5);
			this.inventoryVisualItemSearchBox.Name = "inventoryVisualItemSearchBox";
			this.inventoryVisualItemSearchBox.Size = new global::System.Drawing.Size(241, 24);
			this.inventoryVisualItemSearchBox.TabIndex = 45;
			this.inventoryVisualItemSearchBox.TextChanged += new global::System.EventHandler(this.inventoryVisualItemSearchBox_TextChanged);
			this.inventoryVisualItemSearchBox.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.inventoryVisualItemSearchBox_KeyDown);
			this.itemHolder30.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder30.Location = new global::System.Drawing.Point(606, 15);
			this.itemHolder30.Name = "itemHolder30";
			this.itemHolder30.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder30.TabIndex = 44;
			this.itemHolder30.TabStop = false;
			this.itemHolder31.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder31.Location = new global::System.Drawing.Point(606, 69);
			this.itemHolder31.Name = "itemHolder31";
			this.itemHolder31.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder31.TabIndex = 43;
			this.itemHolder31.TabStop = false;
			this.itemHolder34.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder34.Location = new global::System.Drawing.Point(606, 231);
			this.itemHolder34.Name = "itemHolder34";
			this.itemHolder34.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder34.TabIndex = 42;
			this.itemHolder34.TabStop = false;
			this.itemHolder33.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder33.Location = new global::System.Drawing.Point(606, 177);
			this.itemHolder33.Name = "itemHolder33";
			this.itemHolder33.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder33.TabIndex = 41;
			this.itemHolder33.TabStop = false;
			this.itemHolder36.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder36.Location = new global::System.Drawing.Point(552, 123);
			this.itemHolder36.Name = "itemHolder36";
			this.itemHolder36.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder36.TabIndex = 40;
			this.itemHolder36.TabStop = false;
			this.itemHolder32.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder32.Location = new global::System.Drawing.Point(606, 123);
			this.itemHolder32.Name = "itemHolder32";
			this.itemHolder32.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder32.TabIndex = 39;
			this.itemHolder32.TabStop = false;
			this.itemHolder35.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder35.Location = new global::System.Drawing.Point(660, 123);
			this.itemHolder35.Name = "itemHolder35";
			this.itemHolder35.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder35.TabIndex = 38;
			this.itemHolder35.TabStop = false;
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.currentHoverItem
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 293);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(965, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 37;
			this.statusStrip1.Text = "statusStrip1";
			this.currentHoverItem.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.currentHoverItem.Name = "currentHoverItem";
			this.currentHoverItem.Size = new global::System.Drawing.Size(77, 19);
			this.currentHoverItem.Text = "Item: None";
			this.itemHolder29.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder29.Location = new global::System.Drawing.Point(496, 80);
			this.itemHolder29.Name = "itemHolder29";
			this.itemHolder29.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder29.TabIndex = 36;
			this.itemHolder29.TabStop = false;
			this.itemHolder28.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder28.Location = new global::System.Drawing.Point(442, 80);
			this.itemHolder28.Name = "itemHolder28";
			this.itemHolder28.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder28.TabIndex = 35;
			this.itemHolder28.TabStop = false;
			this.itemHolder27.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder27.Location = new global::System.Drawing.Point(388, 80);
			this.itemHolder27.Name = "itemHolder27";
			this.itemHolder27.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder27.TabIndex = 34;
			this.itemHolder27.TabStop = false;
			this.itemHolder26.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder26.Location = new global::System.Drawing.Point(334, 80);
			this.itemHolder26.Name = "itemHolder26";
			this.itemHolder26.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder26.TabIndex = 33;
			this.itemHolder26.TabStop = false;
			this.itemHolder25.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder25.Location = new global::System.Drawing.Point(280, 80);
			this.itemHolder25.Name = "itemHolder25";
			this.itemHolder25.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder25.TabIndex = 32;
			this.itemHolder25.TabStop = false;
			this.itemHolder24.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder24.Location = new global::System.Drawing.Point(226, 80);
			this.itemHolder24.Name = "itemHolder24";
			this.itemHolder24.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder24.TabIndex = 31;
			this.itemHolder24.TabStop = false;
			this.itemHolder22.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder22.Location = new global::System.Drawing.Point(118, 80);
			this.itemHolder22.Name = "itemHolder22";
			this.itemHolder22.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder22.TabIndex = 29;
			this.itemHolder22.TabStop = false;
			this.itemHolder23.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder23.Location = new global::System.Drawing.Point(172, 80);
			this.itemHolder23.Name = "itemHolder23";
			this.itemHolder23.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder23.TabIndex = 30;
			this.itemHolder23.TabStop = false;
			this.itemHolder21.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder21.Location = new global::System.Drawing.Point(64, 80);
			this.itemHolder21.Name = "itemHolder21";
			this.itemHolder21.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder21.TabIndex = 28;
			this.itemHolder21.TabStop = false;
			this.itemHolder20.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder20.Location = new global::System.Drawing.Point(10, 80);
			this.itemHolder20.Name = "itemHolder20";
			this.itemHolder20.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder20.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder20.TabIndex = 27;
			this.itemHolder20.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(5, 208);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(79, 25);
			this.label3.TabIndex = 26;
			this.label3.Text = "Hot-Bar";
			this.itemHolder19.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder19.Location = new global::System.Drawing.Point(495, 141);
			this.itemHolder19.Name = "itemHolder19";
			this.itemHolder19.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder19.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder19.TabIndex = 25;
			this.itemHolder19.TabStop = false;
			this.itemHolder18.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder18.Location = new global::System.Drawing.Point(441, 141);
			this.itemHolder18.Name = "itemHolder18";
			this.itemHolder18.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder18.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder18.TabIndex = 24;
			this.itemHolder18.TabStop = false;
			this.itemHolder17.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder17.Location = new global::System.Drawing.Point(387, 141);
			this.itemHolder17.Name = "itemHolder17";
			this.itemHolder17.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder17.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder17.TabIndex = 23;
			this.itemHolder17.TabStop = false;
			this.itemHolder16.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder16.Location = new global::System.Drawing.Point(333, 141);
			this.itemHolder16.Name = "itemHolder16";
			this.itemHolder16.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder16.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder16.TabIndex = 22;
			this.itemHolder16.TabStop = false;
			this.itemHolder15.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder15.Location = new global::System.Drawing.Point(279, 141);
			this.itemHolder15.Name = "itemHolder15";
			this.itemHolder15.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder15.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder15.TabIndex = 21;
			this.itemHolder15.TabStop = false;
			this.itemHolder14.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder14.Location = new global::System.Drawing.Point(225, 141);
			this.itemHolder14.Name = "itemHolder14";
			this.itemHolder14.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder14.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder14.TabIndex = 20;
			this.itemHolder14.TabStop = false;
			this.itemHolder12.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder12.Location = new global::System.Drawing.Point(117, 141);
			this.itemHolder12.Name = "itemHolder12";
			this.itemHolder12.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder12.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder12.TabIndex = 18;
			this.itemHolder12.TabStop = false;
			this.itemHolder13.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder13.Location = new global::System.Drawing.Point(171, 141);
			this.itemHolder13.Name = "itemHolder13";
			this.itemHolder13.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder13.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder13.TabIndex = 19;
			this.itemHolder13.TabStop = false;
			this.itemHolder11.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder11.Location = new global::System.Drawing.Point(63, 141);
			this.itemHolder11.Name = "itemHolder11";
			this.itemHolder11.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder11.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder11.TabIndex = 17;
			this.itemHolder11.TabStop = false;
			this.itemHolder10.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder10.Location = new global::System.Drawing.Point(9, 141);
			this.itemHolder10.Name = "itemHolder10";
			this.itemHolder10.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder10.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder10.TabIndex = 16;
			this.itemHolder10.TabStop = false;
			this.itemHolder9.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder9.Location = new global::System.Drawing.Point(495, 238);
			this.itemHolder9.Name = "itemHolder9";
			this.itemHolder9.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder9.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder9.TabIndex = 14;
			this.itemHolder9.TabStop = false;
			this.itemHolder8.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder8.Location = new global::System.Drawing.Point(441, 238);
			this.itemHolder8.Name = "itemHolder8";
			this.itemHolder8.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder8.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder8.TabIndex = 13;
			this.itemHolder8.TabStop = false;
			this.itemHolder7.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder7.Location = new global::System.Drawing.Point(387, 238);
			this.itemHolder7.Name = "itemHolder7";
			this.itemHolder7.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder7.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder7.TabIndex = 12;
			this.itemHolder7.TabStop = false;
			this.itemHolder6.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder6.Location = new global::System.Drawing.Point(333, 238);
			this.itemHolder6.Name = "itemHolder6";
			this.itemHolder6.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder6.TabIndex = 11;
			this.itemHolder6.TabStop = false;
			this.itemHolder5.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder5.Location = new global::System.Drawing.Point(279, 238);
			this.itemHolder5.Name = "itemHolder5";
			this.itemHolder5.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder5.TabIndex = 10;
			this.itemHolder5.TabStop = false;
			this.itemHolder4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder4.Location = new global::System.Drawing.Point(225, 238);
			this.itemHolder4.Name = "itemHolder4";
			this.itemHolder4.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder4.TabIndex = 9;
			this.itemHolder4.TabStop = false;
			this.itemHolder2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder2.Location = new global::System.Drawing.Point(117, 238);
			this.itemHolder2.Name = "itemHolder2";
			this.itemHolder2.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder2.TabIndex = 8;
			this.itemHolder2.TabStop = false;
			this.itemHolder3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder3.Location = new global::System.Drawing.Point(171, 238);
			this.itemHolder3.Name = "itemHolder3";
			this.itemHolder3.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder3.TabIndex = 8;
			this.itemHolder3.TabStop = false;
			this.itemHolder1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder1.Location = new global::System.Drawing.Point(63, 238);
			this.itemHolder1.Name = "itemHolder1";
			this.itemHolder1.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder1.TabIndex = 7;
			this.itemHolder1.TabStop = false;
			this.itemHolder0.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder0.Location = new global::System.Drawing.Point(9, 238);
			this.itemHolder0.Name = "itemHolder0";
			this.itemHolder0.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder0.TabIndex = 6;
			this.itemHolder0.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(5, 52);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Inventory";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Player:";
			this.playerDatListBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.playerDatListBox.FormattingEnabled = true;
			this.playerDatListBox.Items.AddRange(new object[]
			{
				"None"
			});
			this.playerDatListBox.Location = new global::System.Drawing.Point(5, 23);
			this.playerDatListBox.Name = "playerDatListBox";
			this.playerDatListBox.Size = new global::System.Drawing.Size(538, 26);
			this.playerDatListBox.TabIndex = 1;
			this.playerDatListBox.SelectedIndexChanged += new global::System.EventHandler(this.playerDatListBox_SelectedIndexChanged);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.playerDatVariables
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(3, 3);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(965, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.playerDatOpen,
				this.PlayerDatSave,
				this.toolStripSeparator1,
				this.playerDatClose
			});
			this.fileToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 10.5f);
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(41, 23);
			this.fileToolStripMenuItem.Text = "File";
			this.playerDatOpen.Name = "playerDatOpen";
			this.playerDatOpen.Size = new global::System.Drawing.Size(152, 24);
			this.playerDatOpen.Text = "Open";
			this.playerDatOpen.Click += new global::System.EventHandler(this.playerDatOpen_Click);
			this.PlayerDatSave.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.playerDatSaveCurrent,
				this.playerDatSaveNew
			});
			this.PlayerDatSave.Enabled = false;
			this.PlayerDatSave.Name = "PlayerDatSave";
			this.PlayerDatSave.Size = new global::System.Drawing.Size(152, 24);
			this.PlayerDatSave.Text = "Save";
			this.playerDatSaveCurrent.Name = "playerDatSaveCurrent";
			this.playerDatSaveCurrent.Size = new global::System.Drawing.Size(149, 24);
			this.playerDatSaveCurrent.Text = "Current File";
			this.playerDatSaveCurrent.Click += new global::System.EventHandler(this.playerDatSaveCurrent_Click);
			this.playerDatSaveNew.Name = "playerDatSaveNew";
			this.playerDatSaveNew.Size = new global::System.Drawing.Size(149, 24);
			this.playerDatSaveNew.Text = "As New...";
			this.playerDatSaveNew.Click += new global::System.EventHandler(this.playerDatSaveNew_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(149, 6);
			this.playerDatClose.Enabled = false;
			this.playerDatClose.Name = "playerDatClose";
			this.playerDatClose.Size = new global::System.Drawing.Size(152, 24);
			this.playerDatClose.Text = "Close";
			this.playerDatClose.Click += new global::System.EventHandler(this.playerDatClose_Click);
			this.playerDatVariables.Enabled = false;
			this.playerDatVariables.Name = "playerDatVariables";
			this.playerDatVariables.Size = new global::System.Drawing.Size(66, 23);
			this.playerDatVariables.Text = "Variables";
			this.playerDatVariables.Click += new global::System.EventHandler(this.playerDatVariables_Click);
			this.tabPage2.Controls.Add(this.gamertagDataPanel);
			this.tabPage2.Controls.Add(this.menuStrip2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new global::System.Drawing.Size(971, 350);
			this.tabPage2.TabIndex = 2;
			this.tabPage2.Text = "GamertagData.db";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.gamertagDataPanel.Controls.Add(this.gamertagDataUnlocksPanel);
			this.gamertagDataPanel.Controls.Add(this.label12);
			this.gamertagDataPanel.Controls.Add(this.maxLabel);
			this.gamertagDataPanel.Controls.Add(this.gamertagDataSkillsBox);
			this.gamertagDataPanel.Controls.Add(this.label11);
			this.gamertagDataPanel.Controls.Add(this.gamertagDataGamertags);
			this.gamertagDataPanel.Controls.Add(this.label10);
			this.gamertagDataPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.gamertagDataPanel.Enabled = false;
			this.gamertagDataPanel.Location = new global::System.Drawing.Point(0, 27);
			this.gamertagDataPanel.Name = "gamertagDataPanel";
			this.gamertagDataPanel.Size = new global::System.Drawing.Size(971, 323);
			this.gamertagDataPanel.TabIndex = 2;
			this.gamertagDataUnlocksPanel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.gamertagDataUnlocksPanel.Controls.Add(this.lastPage);
			this.gamertagDataUnlocksPanel.Controls.Add(this.unlockPage1);
			this.gamertagDataUnlocksPanel.Controls.Add(this.nextPage);
			this.gamertagDataUnlocksPanel.Controls.Add(this.unlockPage2);
			this.gamertagDataUnlocksPanel.Controls.Add(this.unlockAllButton);
			this.gamertagDataUnlocksPanel.Location = new global::System.Drawing.Point(293, 112);
			this.gamertagDataUnlocksPanel.Name = "gamertagDataUnlocksPanel";
			this.gamertagDataUnlocksPanel.Size = new global::System.Drawing.Size(670, 203);
			this.gamertagDataUnlocksPanel.TabIndex = 8;
			this.lastPage.AutoSize = true;
			this.lastPage.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lastPage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lastPage.Location = new global::System.Drawing.Point(485, 1);
			this.lastPage.Name = "lastPage";
			this.lastPage.Size = new global::System.Drawing.Size(89, 20);
			this.lastPage.TabIndex = 12;
			this.lastPage.Text = "< Last Page";
			this.lastPage.Visible = false;
			this.lastPage.Click += new global::System.EventHandler(this.lastPage_Click);
			this.unlockPage1.Controls.Add(this.explorerCheck);
			this.unlockPage1.Controls.Add(this.zombieCheck);
			this.unlockPage1.Controls.Add(this.treeHuggerCheck);
			this.unlockPage1.Controls.Add(this.terminatorCheck);
			this.unlockPage1.Controls.Add(this.carpenterCheck);
			this.unlockPage1.Controls.Add(this.soldierCheck);
			this.unlockPage1.Controls.Add(this.prisonerCheck);
			this.unlockPage1.Controls.Add(this.knightCheck);
			this.unlockPage1.Controls.Add(this.pupilCheck);
			this.unlockPage1.Controls.Add(this.sageCheck);
			this.unlockPage1.Controls.Add(this.jamaicanCheck);
			this.unlockPage1.Controls.Add(this.indianCheck);
			this.unlockPage1.Controls.Add(this.lumberjackCheck);
			this.unlockPage1.Controls.Add(this.handymanCheck);
			this.unlockPage1.Controls.Add(this.pirateCheck);
			this.unlockPage1.Controls.Add(this.goldenknightCheck);
			this.unlockPage1.Controls.Add(this.refugeeCheck);
			this.unlockPage1.Controls.Add(this.entrepreneurCheck);
			this.unlockPage1.Controls.Add(this.kingCheck);
			this.unlockPage1.Controls.Add(this.angelCheck);
			this.unlockPage1.Controls.Add(this.astronautCheck);
			this.unlockPage1.Controls.Add(this.cowboyCheck);
			this.unlockPage1.Controls.Add(this.ninjaCheck);
			this.unlockPage1.Controls.Add(this.diabloCheck);
			this.unlockPage1.Controls.Add(this.cavemanCheck);
			this.unlockPage1.Controls.Add(this.medicCheck);
			this.unlockPage1.Controls.Add(this.chefCheck);
			this.unlockPage1.Controls.Add(this.invadermanCheck);
			this.unlockPage1.Controls.Add(this.madmanCheck);
			this.unlockPage1.Controls.Add(this.hippieCheck);
			this.unlockPage1.Location = new global::System.Drawing.Point(660, 20);
			this.unlockPage1.Name = "unlockPage1";
			this.unlockPage1.Size = new global::System.Drawing.Size(666, 177);
			this.unlockPage1.TabIndex = 3;
			this.explorerCheck.AutoSize = true;
			this.explorerCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.explorerCheck.Location = new global::System.Drawing.Point(9, 2);
			this.explorerCheck.Name = "explorerCheck";
			this.explorerCheck.Size = new global::System.Drawing.Size(86, 24);
			this.explorerCheck.TabIndex = 0;
			this.explorerCheck.Text = "Explorer";
			this.explorerCheck.UseVisualStyleBackColor = true;
			this.zombieCheck.AutoSize = true;
			this.zombieCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.zombieCheck.Location = new global::System.Drawing.Point(500, 152);
			this.zombieCheck.Name = "zombieCheck";
			this.zombieCheck.Size = new global::System.Drawing.Size(81, 24);
			this.zombieCheck.TabIndex = 29;
			this.zombieCheck.Text = "Zombie";
			this.zombieCheck.UseVisualStyleBackColor = true;
			this.treeHuggerCheck.AutoSize = true;
			this.treeHuggerCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.treeHuggerCheck.Location = new global::System.Drawing.Point(9, 32);
			this.treeHuggerCheck.Name = "treeHuggerCheck";
			this.treeHuggerCheck.Size = new global::System.Drawing.Size(117, 24);
			this.treeHuggerCheck.TabIndex = 1;
			this.treeHuggerCheck.Text = "Tree Hugger";
			this.treeHuggerCheck.UseVisualStyleBackColor = true;
			this.treeHuggerCheck.CheckedChanged += new global::System.EventHandler(this.treeHuggerCheck_CheckedChanged);
			this.terminatorCheck.AutoSize = true;
			this.terminatorCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.terminatorCheck.Location = new global::System.Drawing.Point(500, 122);
			this.terminatorCheck.Name = "terminatorCheck";
			this.terminatorCheck.Size = new global::System.Drawing.Size(104, 24);
			this.terminatorCheck.TabIndex = 28;
			this.terminatorCheck.Text = "Terminator";
			this.terminatorCheck.UseVisualStyleBackColor = true;
			this.carpenterCheck.AutoSize = true;
			this.carpenterCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.carpenterCheck.Location = new global::System.Drawing.Point(9, 62);
			this.carpenterCheck.Name = "carpenterCheck";
			this.carpenterCheck.Size = new global::System.Drawing.Size(99, 24);
			this.carpenterCheck.TabIndex = 2;
			this.carpenterCheck.Text = "Carpenter";
			this.carpenterCheck.UseVisualStyleBackColor = true;
			this.carpenterCheck.CheckedChanged += new global::System.EventHandler(this.carpenterCheck_CheckedChanged);
			this.soldierCheck.AutoSize = true;
			this.soldierCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.soldierCheck.Location = new global::System.Drawing.Point(500, 92);
			this.soldierCheck.Name = "soldierCheck";
			this.soldierCheck.Size = new global::System.Drawing.Size(77, 24);
			this.soldierCheck.TabIndex = 27;
			this.soldierCheck.Text = "Soldier";
			this.soldierCheck.UseVisualStyleBackColor = true;
			this.prisonerCheck.AutoSize = true;
			this.prisonerCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.prisonerCheck.Location = new global::System.Drawing.Point(9, 92);
			this.prisonerCheck.Name = "prisonerCheck";
			this.prisonerCheck.Size = new global::System.Drawing.Size(86, 24);
			this.prisonerCheck.TabIndex = 3;
			this.prisonerCheck.Text = "Prisoner";
			this.prisonerCheck.UseVisualStyleBackColor = true;
			this.knightCheck.AutoSize = true;
			this.knightCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.knightCheck.Location = new global::System.Drawing.Point(500, 62);
			this.knightCheck.Name = "knightCheck";
			this.knightCheck.Size = new global::System.Drawing.Size(73, 24);
			this.knightCheck.TabIndex = 26;
			this.knightCheck.Text = "Knight";
			this.knightCheck.UseVisualStyleBackColor = true;
			this.pupilCheck.AutoSize = true;
			this.pupilCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pupilCheck.Location = new global::System.Drawing.Point(9, 122);
			this.pupilCheck.Name = "pupilCheck";
			this.pupilCheck.Size = new global::System.Drawing.Size(62, 24);
			this.pupilCheck.TabIndex = 4;
			this.pupilCheck.Text = "Pupil";
			this.pupilCheck.UseVisualStyleBackColor = true;
			this.pupilCheck.CheckedChanged += new global::System.EventHandler(this.pupilCheck_CheckedChanged);
			this.sageCheck.AutoSize = true;
			this.sageCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sageCheck.Location = new global::System.Drawing.Point(500, 32);
			this.sageCheck.Name = "sageCheck";
			this.sageCheck.Size = new global::System.Drawing.Size(66, 24);
			this.sageCheck.TabIndex = 25;
			this.sageCheck.Text = "Sage";
			this.sageCheck.UseVisualStyleBackColor = true;
			this.jamaicanCheck.AutoSize = true;
			this.jamaicanCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.jamaicanCheck.Location = new global::System.Drawing.Point(9, 152);
			this.jamaicanCheck.Name = "jamaicanCheck";
			this.jamaicanCheck.Size = new global::System.Drawing.Size(96, 24);
			this.jamaicanCheck.TabIndex = 5;
			this.jamaicanCheck.Text = "Jamaican";
			this.jamaicanCheck.UseVisualStyleBackColor = true;
			this.indianCheck.AutoSize = true;
			this.indianCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.indianCheck.Location = new global::System.Drawing.Point(500, 2);
			this.indianCheck.Name = "indianCheck";
			this.indianCheck.Size = new global::System.Drawing.Size(72, 24);
			this.indianCheck.TabIndex = 24;
			this.indianCheck.Text = "Indian";
			this.indianCheck.UseVisualStyleBackColor = true;
			this.lumberjackCheck.AutoSize = true;
			this.lumberjackCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lumberjackCheck.Location = new global::System.Drawing.Point(130, 2);
			this.lumberjackCheck.Name = "lumberjackCheck";
			this.lumberjackCheck.Size = new global::System.Drawing.Size(110, 24);
			this.lumberjackCheck.TabIndex = 6;
			this.lumberjackCheck.Text = "Lumberjack";
			this.lumberjackCheck.UseVisualStyleBackColor = true;
			this.lumberjackCheck.CheckedChanged += new global::System.EventHandler(this.lumberjackCheck_CheckedChanged);
			this.handymanCheck.AutoSize = true;
			this.handymanCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.handymanCheck.Location = new global::System.Drawing.Point(363, 152);
			this.handymanCheck.Name = "handymanCheck";
			this.handymanCheck.Size = new global::System.Drawing.Size(105, 24);
			this.handymanCheck.TabIndex = 23;
			this.handymanCheck.Text = "Handyman";
			this.handymanCheck.UseVisualStyleBackColor = true;
			this.pirateCheck.AutoSize = true;
			this.pirateCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pirateCheck.Location = new global::System.Drawing.Point(130, 32);
			this.pirateCheck.Name = "pirateCheck";
			this.pirateCheck.Size = new global::System.Drawing.Size(69, 24);
			this.pirateCheck.TabIndex = 7;
			this.pirateCheck.Text = "Pirate";
			this.pirateCheck.UseVisualStyleBackColor = true;
			this.goldenknightCheck.AutoSize = true;
			this.goldenknightCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.goldenknightCheck.Location = new global::System.Drawing.Point(363, 122);
			this.goldenknightCheck.Name = "goldenknightCheck";
			this.goldenknightCheck.Size = new global::System.Drawing.Size(129, 24);
			this.goldenknightCheck.TabIndex = 22;
			this.goldenknightCheck.Text = "Golden Knight";
			this.goldenknightCheck.UseVisualStyleBackColor = true;
			this.refugeeCheck.AutoSize = true;
			this.refugeeCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.refugeeCheck.Location = new global::System.Drawing.Point(130, 62);
			this.refugeeCheck.Name = "refugeeCheck";
			this.refugeeCheck.Size = new global::System.Drawing.Size(90, 24);
			this.refugeeCheck.TabIndex = 8;
			this.refugeeCheck.Text = "Refugee";
			this.refugeeCheck.UseVisualStyleBackColor = true;
			this.entrepreneurCheck.AutoSize = true;
			this.entrepreneurCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.entrepreneurCheck.Location = new global::System.Drawing.Point(363, 92);
			this.entrepreneurCheck.Name = "entrepreneurCheck";
			this.entrepreneurCheck.Size = new global::System.Drawing.Size(122, 24);
			this.entrepreneurCheck.TabIndex = 21;
			this.entrepreneurCheck.Text = "Entrepreneur";
			this.entrepreneurCheck.UseVisualStyleBackColor = true;
			this.kingCheck.AutoSize = true;
			this.kingCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.kingCheck.Location = new global::System.Drawing.Point(130, 92);
			this.kingCheck.Name = "kingCheck";
			this.kingCheck.Size = new global::System.Drawing.Size(59, 24);
			this.kingCheck.TabIndex = 9;
			this.kingCheck.Text = "King";
			this.kingCheck.UseVisualStyleBackColor = true;
			this.angelCheck.AutoSize = true;
			this.angelCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.angelCheck.Location = new global::System.Drawing.Point(363, 32);
			this.angelCheck.Name = "angelCheck";
			this.angelCheck.Size = new global::System.Drawing.Size(69, 24);
			this.angelCheck.TabIndex = 20;
			this.angelCheck.Text = "Angel";
			this.angelCheck.UseVisualStyleBackColor = true;
			this.astronautCheck.AutoSize = true;
			this.astronautCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.astronautCheck.Location = new global::System.Drawing.Point(130, 122);
			this.astronautCheck.Name = "astronautCheck";
			this.astronautCheck.Size = new global::System.Drawing.Size(98, 24);
			this.astronautCheck.TabIndex = 10;
			this.astronautCheck.Text = "Astronaut";
			this.astronautCheck.UseVisualStyleBackColor = true;
			this.cowboyCheck.AutoSize = true;
			this.cowboyCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cowboyCheck.Location = new global::System.Drawing.Point(363, 62);
			this.cowboyCheck.Name = "cowboyCheck";
			this.cowboyCheck.Size = new global::System.Drawing.Size(84, 24);
			this.cowboyCheck.TabIndex = 19;
			this.cowboyCheck.Text = "Cowboy";
			this.cowboyCheck.UseVisualStyleBackColor = true;
			this.ninjaCheck.AutoSize = true;
			this.ninjaCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ninjaCheck.Location = new global::System.Drawing.Point(130, 152);
			this.ninjaCheck.Name = "ninjaCheck";
			this.ninjaCheck.Size = new global::System.Drawing.Size(63, 24);
			this.ninjaCheck.TabIndex = 11;
			this.ninjaCheck.Text = "Ninja";
			this.ninjaCheck.UseVisualStyleBackColor = true;
			this.diabloCheck.AutoSize = true;
			this.diabloCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.diabloCheck.Location = new global::System.Drawing.Point(363, 2);
			this.diabloCheck.Name = "diabloCheck";
			this.diabloCheck.Size = new global::System.Drawing.Size(73, 24);
			this.diabloCheck.TabIndex = 18;
			this.diabloCheck.Text = "Diablo";
			this.diabloCheck.UseVisualStyleBackColor = true;
			this.cavemanCheck.AutoSize = true;
			this.cavemanCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cavemanCheck.Location = new global::System.Drawing.Point(244, 2);
			this.cavemanCheck.Name = "cavemanCheck";
			this.cavemanCheck.Size = new global::System.Drawing.Size(95, 24);
			this.cavemanCheck.TabIndex = 12;
			this.cavemanCheck.Text = "Caveman";
			this.cavemanCheck.UseVisualStyleBackColor = true;
			this.medicCheck.AutoSize = true;
			this.medicCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.medicCheck.Location = new global::System.Drawing.Point(244, 152);
			this.medicCheck.Name = "medicCheck";
			this.medicCheck.Size = new global::System.Drawing.Size(70, 24);
			this.medicCheck.TabIndex = 17;
			this.medicCheck.Text = "Medic";
			this.medicCheck.UseVisualStyleBackColor = true;
			this.chefCheck.AutoSize = true;
			this.chefCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.chefCheck.Location = new global::System.Drawing.Point(244, 32);
			this.chefCheck.Name = "chefCheck";
			this.chefCheck.Size = new global::System.Drawing.Size(62, 24);
			this.chefCheck.TabIndex = 13;
			this.chefCheck.Text = "Chef";
			this.chefCheck.UseVisualStyleBackColor = true;
			this.chefCheck.CheckedChanged += new global::System.EventHandler(this.chefCheck_CheckedChanged);
			this.invadermanCheck.AutoSize = true;
			this.invadermanCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.invadermanCheck.Location = new global::System.Drawing.Point(244, 62);
			this.invadermanCheck.Name = "invadermanCheck";
			this.invadermanCheck.Size = new global::System.Drawing.Size(116, 24);
			this.invadermanCheck.TabIndex = 14;
			this.invadermanCheck.Text = "Invader Man";
			this.invadermanCheck.UseVisualStyleBackColor = true;
			this.madmanCheck.AutoSize = true;
			this.madmanCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.madmanCheck.Location = new global::System.Drawing.Point(244, 122);
			this.madmanCheck.Name = "madmanCheck";
			this.madmanCheck.Size = new global::System.Drawing.Size(94, 24);
			this.madmanCheck.TabIndex = 16;
			this.madmanCheck.Text = "Mad Man";
			this.madmanCheck.UseVisualStyleBackColor = true;
			this.hippieCheck.AutoSize = true;
			this.hippieCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hippieCheck.Location = new global::System.Drawing.Point(244, 92);
			this.hippieCheck.Name = "hippieCheck";
			this.hippieCheck.Size = new global::System.Drawing.Size(73, 24);
			this.hippieCheck.TabIndex = 15;
			this.hippieCheck.Text = "Hippie";
			this.hippieCheck.UseVisualStyleBackColor = true;
			this.nextPage.AutoSize = true;
			this.nextPage.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.nextPage.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.nextPage.Location = new global::System.Drawing.Point(576, 1);
			this.nextPage.Name = "nextPage";
			this.nextPage.Size = new global::System.Drawing.Size(91, 20);
			this.nextPage.TabIndex = 11;
			this.nextPage.Text = "Next Page >";
			this.nextPage.Click += new global::System.EventHandler(this.nextPage_Click);
			this.unlockPage2.Controls.Add(this.demigodCheck);
			this.unlockPage2.Location = new global::System.Drawing.Point(1, 23);
			this.unlockPage2.Name = "unlockPage2";
			this.unlockPage2.Size = new global::System.Drawing.Size(666, 177);
			this.unlockPage2.TabIndex = 10;
			this.unlockPage2.Visible = false;
			this.demigodCheck.AutoSize = true;
			this.demigodCheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.demigodCheck.Location = new global::System.Drawing.Point(9, 2);
			this.demigodCheck.Name = "demigodCheck";
			this.demigodCheck.Size = new global::System.Drawing.Size(96, 24);
			this.demigodCheck.TabIndex = 1;
			this.demigodCheck.Text = "DemiGod";
			this.demigodCheck.UseVisualStyleBackColor = true;
			this.unlockAllButton.AutoSize = true;
			this.unlockAllButton.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.unlockAllButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.unlockAllButton.Location = new global::System.Drawing.Point(3, 1);
			this.unlockAllButton.Name = "unlockAllButton";
			this.unlockAllButton.Size = new global::System.Drawing.Size(76, 20);
			this.unlockAllButton.TabIndex = 9;
			this.unlockAllButton.Text = "Unlock All";
			this.unlockAllButton.Click += new global::System.EventHandler(this.unlockAllButton_Click);
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.Location = new global::System.Drawing.Point(304, 84);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(88, 25);
			this.label12.TabIndex = 7;
			this.label12.Text = "Unlocks:";
			this.maxLabel.AutoSize = true;
			this.maxLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.maxLabel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.maxLabel.Location = new global::System.Drawing.Point(230, 62);
			this.maxLabel.Name = "maxLabel";
			this.maxLabel.Size = new global::System.Drawing.Size(57, 20);
			this.maxLabel.TabIndex = 6;
			this.maxLabel.Text = "Max All";
			this.maxLabel.Click += new global::System.EventHandler(this.maxLabel_Click);
			this.gamertagDataSkillsBox.Columns.Add(this.betterListViewColumnHeader1);
			this.gamertagDataSkillsBox.Columns.Add(this.betterListViewColumnHeader2);
			this.gamertagDataSkillsBox.FontItems = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.gamertagDataSkillsBox.GridLines = 1;
			this.gamertagDataSkillsBox.LabelEditActivation = 14;
			this.gamertagDataSkillsBox.LabelEditModeSubItems = 1;
			this.gamertagDataSkillsBox.Location = new global::System.Drawing.Point(12, 84);
			this.gamertagDataSkillsBox.Name = "gamertagDataSkillsBox";
			this.gamertagDataSkillsBox.Size = new global::System.Drawing.Size(275, 231);
			this.gamertagDataSkillsBox.TabIndex = 5;
			this.gamertagDataSkillsBox.AfterLabelEdit += new global::ComponentOwl.BetterListView.BetterListViewLabelEditEventHandler(this.gamertagDataSkillsBox_AfterLabelEdit);
			this.betterListViewColumnHeader1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.betterListViewColumnHeader1.Name = "betterListViewColumnHeader1";
			this.betterListViewColumnHeader1.Text = "Skill Name";
			this.betterListViewColumnHeader2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.betterListViewColumnHeader2.Name = "betterListViewColumnHeader2";
			this.betterListViewColumnHeader2.Text = "Skill Value";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(8, 61);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(49, 20);
			this.label11.TabIndex = 4;
			this.label11.Text = "Skills:";
			this.gamertagDataGamertags.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gamertagDataGamertags.FormattingEnabled = true;
			this.gamertagDataGamertags.Items.AddRange(new object[]
			{
				"None"
			});
			this.gamertagDataGamertags.Location = new global::System.Drawing.Point(11, 32);
			this.gamertagDataGamertags.Name = "gamertagDataGamertags";
			this.gamertagDataGamertags.Size = new global::System.Drawing.Size(952, 26);
			this.gamertagDataGamertags.TabIndex = 2;
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(8, 11);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(74, 18);
			this.label10.TabIndex = 1;
			this.label10.Text = "Gamertag";
			this.menuStrip2.Font = new global::System.Drawing.Font("Segoe UI", 10.5f);
			this.menuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem1
			});
			this.menuStrip2.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new global::System.Drawing.Size(971, 27);
			this.menuStrip2.TabIndex = 0;
			this.menuStrip2.Text = "menuStrip2";
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.gamertagdataOpen,
				this.gamertagDataSaveButton,
				this.toolStripSeparator3,
				this.gamertagDataCloseButton
			});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new global::System.Drawing.Size(41, 23);
			this.fileToolStripMenuItem1.Text = "File";
			this.gamertagdataOpen.Name = "gamertagdataOpen";
			this.gamertagdataOpen.Size = new global::System.Drawing.Size(152, 24);
			this.gamertagdataOpen.Text = "Open";
			this.gamertagdataOpen.Click += new global::System.EventHandler(this.gamertagdataOpen_Click);
			this.gamertagDataSaveButton.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.gamertagDataCurrentFile,
				this.gamertagDataNewFile
			});
			this.gamertagDataSaveButton.Enabled = false;
			this.gamertagDataSaveButton.Name = "gamertagDataSaveButton";
			this.gamertagDataSaveButton.Size = new global::System.Drawing.Size(152, 24);
			this.gamertagDataSaveButton.Text = "Save";
			this.gamertagDataCurrentFile.Name = "gamertagDataCurrentFile";
			this.gamertagDataCurrentFile.Size = new global::System.Drawing.Size(149, 24);
			this.gamertagDataCurrentFile.Text = "Current File";
			this.gamertagDataCurrentFile.Click += new global::System.EventHandler(this.gamertagDataCurrentFile_Click);
			this.gamertagDataNewFile.Name = "gamertagDataNewFile";
			this.gamertagDataNewFile.Size = new global::System.Drawing.Size(149, 24);
			this.gamertagDataNewFile.Text = "New File";
			this.gamertagDataNewFile.Click += new global::System.EventHandler(this.gamertagDataNewFile_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(149, 6);
			this.gamertagDataCloseButton.Enabled = false;
			this.gamertagDataCloseButton.Name = "gamertagDataCloseButton";
			this.gamertagDataCloseButton.Size = new global::System.Drawing.Size(152, 24);
			this.gamertagDataCloseButton.Text = "Close";
			this.gamertagDataCloseButton.Click += new global::System.EventHandler(this.gamertagDataCloseButton_Click);
			this.tabPage4.Controls.Add(this.headerDatPanel);
			this.tabPage4.Controls.Add(this.menuStrip3);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new global::System.Drawing.Size(971, 350);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Header.DAT";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.headerDatPanel.Controls.Add(this.gameModeBox);
			this.headerDatPanel.Controls.Add(this.label17);
			this.headerDatPanel.Controls.Add(this.mapOwnerTextBox);
			this.headerDatPanel.Controls.Add(this.label16);
			this.headerDatPanel.Controls.Add(this.bluePrintsButton);
			this.headerDatPanel.Controls.Add(this.statusStrip2);
			this.headerDatPanel.Controls.Add(this.itemHolder66);
			this.headerDatPanel.Controls.Add(this.itemHolder65);
			this.headerDatPanel.Controls.Add(this.itemHolder64);
			this.headerDatPanel.Controls.Add(this.itemHolder63);
			this.headerDatPanel.Controls.Add(this.itemHolder62);
			this.headerDatPanel.Controls.Add(this.itemHolder61);
			this.headerDatPanel.Controls.Add(this.itemHolder59);
			this.headerDatPanel.Controls.Add(this.itemHolder60);
			this.headerDatPanel.Controls.Add(this.itemHolder58);
			this.headerDatPanel.Controls.Add(this.itemHolder57);
			this.headerDatPanel.Controls.Add(this.label15);
			this.headerDatPanel.Controls.Add(this.itemHolder56);
			this.headerDatPanel.Controls.Add(this.itemHolder55);
			this.headerDatPanel.Controls.Add(this.itemHolder54);
			this.headerDatPanel.Controls.Add(this.itemHolder53);
			this.headerDatPanel.Controls.Add(this.itemHolder52);
			this.headerDatPanel.Controls.Add(this.itemHolder51);
			this.headerDatPanel.Controls.Add(this.itemHolder49);
			this.headerDatPanel.Controls.Add(this.itemHolder50);
			this.headerDatPanel.Controls.Add(this.itemHolder48);
			this.headerDatPanel.Controls.Add(this.itemHolder47);
			this.headerDatPanel.Controls.Add(this.itemHolder46);
			this.headerDatPanel.Controls.Add(this.itemHolder45);
			this.headerDatPanel.Controls.Add(this.itemHolder44);
			this.headerDatPanel.Controls.Add(this.itemHolder43);
			this.headerDatPanel.Controls.Add(this.itemHolder42);
			this.headerDatPanel.Controls.Add(this.itemHolder41);
			this.headerDatPanel.Controls.Add(this.itemHolder39);
			this.headerDatPanel.Controls.Add(this.itemHolder40);
			this.headerDatPanel.Controls.Add(this.itemHolder38);
			this.headerDatPanel.Controls.Add(this.itemHolder37);
			this.headerDatPanel.Controls.Add(this.label14);
			this.headerDatPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.headerDatPanel.Enabled = false;
			this.headerDatPanel.Location = new global::System.Drawing.Point(3, 30);
			this.headerDatPanel.Name = "headerDatPanel";
			this.headerDatPanel.Size = new global::System.Drawing.Size(965, 317);
			this.headerDatPanel.TabIndex = 2;
			this.bluePrintsButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.bluePrintsButton.Location = new global::System.Drawing.Point(565, 80);
			this.bluePrintsButton.Name = "bluePrintsButton";
			this.bluePrintsButton.Size = new global::System.Drawing.Size(129, 29);
			this.bluePrintsButton.TabIndex = 69;
			this.bluePrintsButton.Text = "Edit Blueprints";
			this.bluePrintsButton.UseVisualStyleBackColor = true;
			this.bluePrintsButton.Click += new global::System.EventHandler(this.bluePrintsButton_Click);
			this.statusStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.headerDatCurrentItem
			});
			this.statusStrip2.Location = new global::System.Drawing.Point(0, 293);
			this.statusStrip2.Name = "statusStrip2";
			this.statusStrip2.Size = new global::System.Drawing.Size(965, 24);
			this.statusStrip2.SizingGrip = false;
			this.statusStrip2.TabIndex = 68;
			this.statusStrip2.Text = "statusStrip2";
			this.headerDatCurrentItem.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.headerDatCurrentItem.Name = "headerDatCurrentItem";
			this.headerDatCurrentItem.Size = new global::System.Drawing.Size(77, 19);
			this.headerDatCurrentItem.Text = "Item: None";
			this.itemHolder66.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder66.Location = new global::System.Drawing.Point(496, 80);
			this.itemHolder66.Name = "itemHolder66";
			this.itemHolder66.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder66.TabIndex = 67;
			this.itemHolder66.TabStop = false;
			this.itemHolder65.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder65.Location = new global::System.Drawing.Point(442, 80);
			this.itemHolder65.Name = "itemHolder65";
			this.itemHolder65.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder65.TabIndex = 66;
			this.itemHolder65.TabStop = false;
			this.itemHolder64.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder64.Location = new global::System.Drawing.Point(388, 80);
			this.itemHolder64.Name = "itemHolder64";
			this.itemHolder64.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder64.TabIndex = 65;
			this.itemHolder64.TabStop = false;
			this.itemHolder63.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder63.Location = new global::System.Drawing.Point(334, 80);
			this.itemHolder63.Name = "itemHolder63";
			this.itemHolder63.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder63.TabIndex = 64;
			this.itemHolder63.TabStop = false;
			this.itemHolder62.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder62.Location = new global::System.Drawing.Point(280, 80);
			this.itemHolder62.Name = "itemHolder62";
			this.itemHolder62.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder62.TabIndex = 63;
			this.itemHolder62.TabStop = false;
			this.itemHolder61.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder61.Location = new global::System.Drawing.Point(226, 80);
			this.itemHolder61.Name = "itemHolder61";
			this.itemHolder61.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder61.TabIndex = 62;
			this.itemHolder61.TabStop = false;
			this.itemHolder59.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder59.Location = new global::System.Drawing.Point(118, 80);
			this.itemHolder59.Name = "itemHolder59";
			this.itemHolder59.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder59.TabIndex = 60;
			this.itemHolder59.TabStop = false;
			this.itemHolder60.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder60.Location = new global::System.Drawing.Point(172, 80);
			this.itemHolder60.Name = "itemHolder60";
			this.itemHolder60.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder60.TabIndex = 61;
			this.itemHolder60.TabStop = false;
			this.itemHolder58.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder58.Location = new global::System.Drawing.Point(64, 80);
			this.itemHolder58.Name = "itemHolder58";
			this.itemHolder58.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder58.TabIndex = 59;
			this.itemHolder58.TabStop = false;
			this.itemHolder57.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder57.Location = new global::System.Drawing.Point(10, 80);
			this.itemHolder57.Name = "itemHolder57";
			this.itemHolder57.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder57.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder57.TabIndex = 58;
			this.itemHolder57.TabStop = false;
			this.label15.AutoSize = true;
			this.label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.Location = new global::System.Drawing.Point(5, 208);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(230, 25);
			this.label15.TabIndex = 57;
			this.label15.Text = "Spawn Inventory Hot-Bar";
			this.itemHolder56.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder56.Location = new global::System.Drawing.Point(495, 141);
			this.itemHolder56.Name = "itemHolder56";
			this.itemHolder56.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder56.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder56.TabIndex = 56;
			this.itemHolder56.TabStop = false;
			this.itemHolder55.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder55.Location = new global::System.Drawing.Point(441, 141);
			this.itemHolder55.Name = "itemHolder55";
			this.itemHolder55.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder55.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder55.TabIndex = 55;
			this.itemHolder55.TabStop = false;
			this.itemHolder54.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder54.Location = new global::System.Drawing.Point(387, 141);
			this.itemHolder54.Name = "itemHolder54";
			this.itemHolder54.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder54.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder54.TabIndex = 54;
			this.itemHolder54.TabStop = false;
			this.itemHolder53.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder53.Location = new global::System.Drawing.Point(333, 141);
			this.itemHolder53.Name = "itemHolder53";
			this.itemHolder53.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder53.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder53.TabIndex = 53;
			this.itemHolder53.TabStop = false;
			this.itemHolder52.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder52.Location = new global::System.Drawing.Point(279, 141);
			this.itemHolder52.Name = "itemHolder52";
			this.itemHolder52.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder52.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder52.TabIndex = 52;
			this.itemHolder52.TabStop = false;
			this.itemHolder51.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder51.Location = new global::System.Drawing.Point(225, 141);
			this.itemHolder51.Name = "itemHolder51";
			this.itemHolder51.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder51.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder51.TabIndex = 51;
			this.itemHolder51.TabStop = false;
			this.itemHolder49.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder49.Location = new global::System.Drawing.Point(117, 141);
			this.itemHolder49.Name = "itemHolder49";
			this.itemHolder49.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder49.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder49.TabIndex = 49;
			this.itemHolder49.TabStop = false;
			this.itemHolder50.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder50.Location = new global::System.Drawing.Point(171, 141);
			this.itemHolder50.Name = "itemHolder50";
			this.itemHolder50.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder50.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder50.TabIndex = 50;
			this.itemHolder50.TabStop = false;
			this.itemHolder48.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder48.Location = new global::System.Drawing.Point(63, 141);
			this.itemHolder48.Name = "itemHolder48";
			this.itemHolder48.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder48.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder48.TabIndex = 48;
			this.itemHolder48.TabStop = false;
			this.itemHolder47.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder47.Location = new global::System.Drawing.Point(9, 141);
			this.itemHolder47.Name = "itemHolder47";
			this.itemHolder47.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder47.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder47.TabIndex = 47;
			this.itemHolder47.TabStop = false;
			this.itemHolder46.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder46.Location = new global::System.Drawing.Point(495, 238);
			this.itemHolder46.Name = "itemHolder46";
			this.itemHolder46.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder46.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder46.TabIndex = 46;
			this.itemHolder46.TabStop = false;
			this.itemHolder45.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder45.Location = new global::System.Drawing.Point(441, 238);
			this.itemHolder45.Name = "itemHolder45";
			this.itemHolder45.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder45.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder45.TabIndex = 45;
			this.itemHolder45.TabStop = false;
			this.itemHolder44.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder44.Location = new global::System.Drawing.Point(387, 238);
			this.itemHolder44.Name = "itemHolder44";
			this.itemHolder44.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder44.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder44.TabIndex = 44;
			this.itemHolder44.TabStop = false;
			this.itemHolder43.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder43.Location = new global::System.Drawing.Point(333, 238);
			this.itemHolder43.Name = "itemHolder43";
			this.itemHolder43.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder43.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder43.TabIndex = 43;
			this.itemHolder43.TabStop = false;
			this.itemHolder42.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder42.Location = new global::System.Drawing.Point(279, 238);
			this.itemHolder42.Name = "itemHolder42";
			this.itemHolder42.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder42.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder42.TabIndex = 42;
			this.itemHolder42.TabStop = false;
			this.itemHolder41.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder41.Location = new global::System.Drawing.Point(225, 238);
			this.itemHolder41.Name = "itemHolder41";
			this.itemHolder41.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder41.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder41.TabIndex = 41;
			this.itemHolder41.TabStop = false;
			this.itemHolder39.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder39.Location = new global::System.Drawing.Point(117, 238);
			this.itemHolder39.Name = "itemHolder39";
			this.itemHolder39.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder39.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder39.TabIndex = 39;
			this.itemHolder39.TabStop = false;
			this.itemHolder40.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder40.Location = new global::System.Drawing.Point(171, 238);
			this.itemHolder40.Name = "itemHolder40";
			this.itemHolder40.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder40.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder40.TabIndex = 40;
			this.itemHolder40.TabStop = false;
			this.itemHolder38.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder38.Location = new global::System.Drawing.Point(63, 238);
			this.itemHolder38.Name = "itemHolder38";
			this.itemHolder38.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder38.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder38.TabIndex = 38;
			this.itemHolder38.TabStop = false;
			this.itemHolder37.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.itemHolder37.Location = new global::System.Drawing.Point(9, 238);
			this.itemHolder37.Name = "itemHolder37";
			this.itemHolder37.Size = new global::System.Drawing.Size(48, 48);
			this.itemHolder37.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.itemHolder37.TabIndex = 37;
			this.itemHolder37.TabStop = false;
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.Location = new global::System.Drawing.Point(5, 52);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(158, 25);
			this.label14.TabIndex = 5;
			this.label14.Text = "Spawn Inventory";
			this.menuStrip3.Font = new global::System.Drawing.Font("Segoe UI", 10.5f);
			this.menuStrip3.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem1
			});
			this.menuStrip3.Location = new global::System.Drawing.Point(3, 3);
			this.menuStrip3.Name = "menuStrip3";
			this.menuStrip3.Size = new global::System.Drawing.Size(965, 27);
			this.menuStrip3.TabIndex = 1;
			this.menuStrip3.Text = "menuStrip3";
			this.toolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.headerDatOpen,
				this.headerDatSave,
				this.toolStripSeparator4,
				this.headerDatClose
			});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new global::System.Drawing.Size(41, 23);
			this.toolStripMenuItem1.Text = "File";
			this.headerDatOpen.Name = "headerDatOpen";
			this.headerDatOpen.Size = new global::System.Drawing.Size(152, 24);
			this.headerDatOpen.Text = "Open";
			this.headerDatOpen.Click += new global::System.EventHandler(this.headerDatOpen_Click);
			this.headerDatSave.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.headerDatSaveCurrent,
				this.headerDatSaveNew
			});
			this.headerDatSave.Enabled = false;
			this.headerDatSave.Name = "headerDatSave";
			this.headerDatSave.Size = new global::System.Drawing.Size(152, 24);
			this.headerDatSave.Text = "Save";
			this.headerDatSaveCurrent.Name = "headerDatSaveCurrent";
			this.headerDatSaveCurrent.Size = new global::System.Drawing.Size(152, 24);
			this.headerDatSaveCurrent.Text = "Current File";
			this.headerDatSaveCurrent.Click += new global::System.EventHandler(this.headerDatSaveCurrent_Click);
			this.headerDatSaveNew.Name = "headerDatSaveNew";
			this.headerDatSaveNew.Size = new global::System.Drawing.Size(152, 24);
			this.headerDatSaveNew.Text = "New File";
			this.headerDatSaveNew.Click += new global::System.EventHandler(this.headerDatSaveNew_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(149, 6);
			this.headerDatClose.Enabled = false;
			this.headerDatClose.Name = "headerDatClose";
			this.headerDatClose.Size = new global::System.Drawing.Size(152, 24);
			this.headerDatClose.Text = "Close";
			this.headerDatClose.Click += new global::System.EventHandler(this.headerDatClose_Click);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new global::System.Drawing.Size(971, 350);
			this.tabPage3.TabIndex = 1;
			this.tabPage3.Text = "About";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.label9.AutoSize = true;
			this.label9.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.Blue;
			this.label9.Location = new global::System.Drawing.Point(37, 179);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(139, 26);
			this.label9.TabIndex = 5;
			this.label9.Text = "XBLToothPik";
			this.label9.Click += new global::System.EventHandler(this.label9_Click);
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.Location = new global::System.Drawing.Point(22, 149);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(143, 29);
			this.label8.TabIndex = 4;
			this.label8.Text = "Developers:";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(23, 81);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(202, 24);
			this.label7.TabIndex = 3;
			this.label7.Text = "Program Version: 1.1.0\r\n";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(22, 54);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(397, 24);
			this.label6.TabIndex = 2;
			this.label6.Text = "Total Miner Compatibility: V2.1.115 (R14.11.01)";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 22f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Maroon;
			this.label5.Location = new global::System.Drawing.Point(312, 17);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(192, 36);
			this.label5.TabIndex = 1;
			this.label5.Text = "XBLToothPik";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(16, 17);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(293, 31);
			this.label4.TabIndex = 0;
			this.label4.Text = "Program Developed By";
			this.context_itemHolderOptions.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.editAmountToolStripMenuItem,
				this.editDurabilityToolStripMenuItem,
				this.toolStripSeparator2,
				this.deleteToolStripMenuItem
			});
			this.context_itemHolderOptions.Name = "context_itemHolderOptions";
			this.context_itemHolderOptions.Size = new global::System.Drawing.Size(149, 76);
			this.editAmountToolStripMenuItem.Name = "editAmountToolStripMenuItem";
			this.editAmountToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.editAmountToolStripMenuItem.Text = "Edit Amount";
			this.editAmountToolStripMenuItem.Click += new global::System.EventHandler(this.editAmountToolStripMenuItem_Click);
			this.editDurabilityToolStripMenuItem.Name = "editDurabilityToolStripMenuItem";
			this.editDurabilityToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.editDurabilityToolStripMenuItem.Text = "Edit Durability";
			this.editDurabilityToolStripMenuItem.Click += new global::System.EventHandler(this.editDurabilityToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(145, 6);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
			this.skillIcons.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.skillIcons.ImageSize = new global::System.Drawing.Size(16, 16);
			this.skillIcons.TransparentColor = global::System.Drawing.Color.Transparent;
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.5f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.Location = new global::System.Drawing.Point(11, 14);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(94, 20);
			this.label16.TabIndex = 70;
			this.label16.Text = "Map Owner:";
			this.mapOwnerTextBox.Location = new global::System.Drawing.Point(111, 13);
			this.mapOwnerTextBox.Name = "mapOwnerTextBox";
			this.mapOwnerTextBox.Size = new global::System.Drawing.Size(151, 24);
			this.mapOwnerTextBox.TabIndex = 71;
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.5f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.Location = new global::System.Drawing.Point(268, 14);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(97, 20);
			this.label17.TabIndex = 72;
			this.label17.Text = "Game Mode";
			this.gameModeBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.gameModeBox.FormattingEnabled = true;
			this.gameModeBox.Items.AddRange(new object[]
			{
				"None",
				"Dig Deep",
				"Creative",
				"Survival",
				"Peaceful"
			});
			this.gameModeBox.Location = new global::System.Drawing.Point(368, 11);
			this.gameModeBox.Name = "gameModeBox";
			this.gameModeBox.Size = new global::System.Drawing.Size(175, 26);
			this.gameModeBox.TabIndex = 73;
			this.AllowDrop = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(979, 381);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MainMenuStrip = this.menuStrip2;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Main";
			this.Text = "Total Miner Tools [TMF 2.1.115] [V1.1.0]";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.playerDatPanel.ResumeLayout(false);
			this.playerDatPanel.PerformLayout();
			this.inventoryVisualItems.EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder30).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder31).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder34).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder33).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder36).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder32).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder35).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder29).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder28).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder27).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder26).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder25).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder24).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder22).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder23).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder21).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder20).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder19).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder18).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder17).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder16).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder15).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder14).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder12).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder13).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder11).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder10).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder9).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder8).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder6).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder0).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.gamertagDataPanel.ResumeLayout(false);
			this.gamertagDataPanel.PerformLayout();
			this.gamertagDataUnlocksPanel.ResumeLayout(false);
			this.gamertagDataUnlocksPanel.PerformLayout();
			this.unlockPage1.ResumeLayout(false);
			this.unlockPage1.PerformLayout();
			this.unlockPage2.ResumeLayout(false);
			this.unlockPage2.PerformLayout();
			this.gamertagDataSkillsBox.EndInit();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.headerDatPanel.ResumeLayout(false);
			this.headerDatPanel.PerformLayout();
			this.statusStrip2.ResumeLayout(false);
			this.statusStrip2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder66).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder65).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder64).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder63).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder62).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder61).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder59).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder60).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder58).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder57).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder56).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder55).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder54).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder53).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder52).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder51).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder49).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder50).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder48).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder47).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder46).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder45).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder44).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder43).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder42).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder41).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder39).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder40).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder38).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.itemHolder37).EndInit();
			this.menuStrip3.ResumeLayout(false);
			this.menuStrip3.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.context_itemHolderOptions.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400002A RID: 42
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ComboBox playerDatListBox;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem playerDatOpen;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem PlayerDatSave;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripMenuItem playerDatSaveCurrent;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem playerDatSaveNew;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem playerDatClose;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Panel playerDatPanel;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.PictureBox itemHolder9;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.PictureBox itemHolder8;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.PictureBox itemHolder7;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.PictureBox itemHolder6;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.PictureBox itemHolder5;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.PictureBox itemHolder4;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.PictureBox itemHolder2;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.PictureBox itemHolder3;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.PictureBox itemHolder1;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.PictureBox itemHolder0;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.PictureBox itemHolder19;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.PictureBox itemHolder18;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.PictureBox itemHolder17;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.PictureBox itemHolder16;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.PictureBox itemHolder15;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.PictureBox itemHolder14;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.PictureBox itemHolder12;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.PictureBox itemHolder13;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.PictureBox itemHolder11;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.PictureBox itemHolder10;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.PictureBox itemHolder29;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.PictureBox itemHolder28;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.PictureBox itemHolder27;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.PictureBox itemHolder26;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.PictureBox itemHolder25;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.PictureBox itemHolder24;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.PictureBox itemHolder22;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.PictureBox itemHolder23;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.PictureBox itemHolder21;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.PictureBox itemHolder20;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.ContextMenuStrip context_itemHolderOptions;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.ToolStripMenuItem editAmountToolStripMenuItem;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.ToolStripMenuItem editDurabilityToolStripMenuItem;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.ToolStripStatusLabel currentHoverItem;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.PictureBox itemHolder30;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.PictureBox itemHolder31;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.PictureBox itemHolder34;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.PictureBox itemHolder33;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.PictureBox itemHolder36;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.PictureBox itemHolder32;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.PictureBox itemHolder35;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Panel gamertagDataPanel;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.ComboBox gamertagDataGamertags;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.MenuStrip menuStrip2;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.ToolStripMenuItem gamertagdataOpen;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.ToolStripMenuItem gamertagDataSaveButton;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.ToolStripMenuItem gamertagDataCurrentFile;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.ToolStripMenuItem gamertagDataNewFile;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.ImageList skillIcons;

		// Token: 0x04000079 RID: 121
		private global::ComponentOwl.BetterListView.BetterListView gamertagDataSkillsBox;

		// Token: 0x0400007A RID: 122
		private global::ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader1;

		// Token: 0x0400007B RID: 123
		private global::ComponentOwl.BetterListView.BetterListViewColumnHeader betterListViewColumnHeader2;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label maxLabel;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.ToolStripMenuItem gamertagDataCloseButton;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Panel gamertagDataUnlocksPanel;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.CheckBox explorerCheck;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.CheckBox prisonerCheck;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.CheckBox carpenterCheck;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.CheckBox treeHuggerCheck;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.CheckBox pupilCheck;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.CheckBox jamaicanCheck;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.CheckBox lumberjackCheck;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.CheckBox pirateCheck;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.CheckBox refugeeCheck;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.CheckBox kingCheck;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.CheckBox astronautCheck;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.CheckBox ninjaCheck;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.CheckBox cavemanCheck;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.CheckBox chefCheck;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.CheckBox invadermanCheck;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.CheckBox hippieCheck;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.Label unlockAllButton;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.CheckBox madmanCheck;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.CheckBox medicCheck;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.CheckBox diabloCheck;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.CheckBox angelCheck;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.CheckBox cowboyCheck;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.CheckBox entrepreneurCheck;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.CheckBox goldenknightCheck;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.CheckBox handymanCheck;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.CheckBox indianCheck;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.CheckBox sageCheck;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.CheckBox knightCheck;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.CheckBox soldierCheck;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.CheckBox terminatorCheck;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.CheckBox zombieCheck;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Panel unlockPage1;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Panel unlockPage2;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.CheckBox demigodCheck;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Label nextPage;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.Label lastPage;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.TextBox inventoryVisualItemSearchBox;

		// Token: 0x040000A6 RID: 166
		private global::ComponentOwl.BetterListView.BetterListView inventoryVisualItems;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Panel headerDatPanel;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.MenuStrip menuStrip3;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.ToolStripMenuItem headerDatOpen;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.ToolStripMenuItem headerDatSave;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.ToolStripMenuItem headerDatSaveCurrent;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.ToolStripMenuItem headerDatSaveNew;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ToolStripMenuItem headerDatClose;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ToolStripMenuItem playerDatVariables;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.PictureBox itemHolder66;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.PictureBox itemHolder65;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.PictureBox itemHolder64;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.PictureBox itemHolder63;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.PictureBox itemHolder62;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.PictureBox itemHolder61;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.PictureBox itemHolder59;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.PictureBox itemHolder60;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.PictureBox itemHolder58;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.PictureBox itemHolder57;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.PictureBox itemHolder56;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.PictureBox itemHolder55;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.PictureBox itemHolder54;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.PictureBox itemHolder53;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.PictureBox itemHolder52;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.PictureBox itemHolder51;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.PictureBox itemHolder49;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.PictureBox itemHolder50;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.PictureBox itemHolder48;

		// Token: 0x040000C8 RID: 200
		private global::System.Windows.Forms.PictureBox itemHolder47;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.PictureBox itemHolder46;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.PictureBox itemHolder45;

		// Token: 0x040000CB RID: 203
		private global::System.Windows.Forms.PictureBox itemHolder44;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.PictureBox itemHolder43;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.PictureBox itemHolder42;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.PictureBox itemHolder41;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.PictureBox itemHolder39;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.PictureBox itemHolder40;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.PictureBox itemHolder38;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.PictureBox itemHolder37;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.StatusStrip statusStrip2;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.ToolStripStatusLabel headerDatCurrentItem;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Button bluePrintsButton;

		// Token: 0x040000D6 RID: 214
		public global::System.Windows.Forms.ImageList itemImages;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.TextBox mapOwnerTextBox;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ComboBox gameModeBox;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.Label label17;
	}
}
