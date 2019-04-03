namespace Mario64Randomizer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnNewSeed = new System.Windows.Forms.Button();
            this.btnEnterSeed = new System.Windows.Forms.Button();
            this.chkFirst = new System.Windows.Forms.CheckBox();
            this.chkDownstairs = new System.Windows.Forms.CheckBox();
            this.chkUpstairs = new System.Windows.Forms.CheckBox();
            this.chkBowserStars = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkSecretStars = new System.Windows.Forms.CheckBox();
            this.chkToads = new System.Windows.Forms.CheckBox();
            this.nudSeed = new System.Windows.Forms.NumericUpDown();
            this.nudStarAmount = new System.Windows.Forms.NumericUpDown();
            this.lvStars = new System.Windows.Forms.ListView();
            this.chk100CS = new System.Windows.Forms.CheckBox();
            this.chkMips = new System.Windows.Forms.CheckBox();
            this.lblNumberOfStars = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSequence = new System.Windows.Forms.TabPage();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.tabWarps = new System.Windows.Forms.TabPage();
            this.tabClothes = new System.Windows.Forms.TabPage();
            this.pColorHair = new System.Windows.Forms.Panel();
            this.pColorFace = new System.Windows.Forms.Panel();
            this.pColorShoes = new System.Windows.Forms.Panel();
            this.pColorGloves = new System.Windows.Forms.Panel();
            this.pColorArms = new System.Windows.Forms.Panel();
            this.pColorOveralls = new System.Windows.Forms.Panel();
            this.btnColorHair = new System.Windows.Forms.Button();
            this.btnColorFace = new System.Windows.Forms.Button();
            this.btnColorShoes = new System.Windows.Forms.Button();
            this.btnColorGloves = new System.Windows.Forms.Button();
            this.btnColorCapArms = new System.Windows.Forms.Button();
            this.btnColorOveralls = new System.Windows.Forms.Button();
            this.btnColorRestore = new System.Windows.Forms.Button();
            this.chkRandomizeText = new System.Windows.Forms.CheckBox();
            this.btnSaveRom = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnOpenRom = new System.Windows.Forms.Button();
            this.chkRandomizeEnemies = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMarioClothes = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMusic = new System.Windows.Forms.CheckBox();
            this.chkRandomizeWarps = new System.Windows.Forms.CheckBox();
            this.cdClothes = new System.Windows.Forms.ColorDialog();
            this.chkRandomizeTextures = new System.Windows.Forms.CheckBox();
            this.txtBowserWarpId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRandomizeBowser = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSequence.SuspendLayout();
            this.tabWarps.SuspendLayout();
            this.tabClothes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewSeed
            // 
            this.btnNewSeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewSeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNewSeed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewSeed.Location = new System.Drawing.Point(23, 10);
            this.btnNewSeed.Name = "btnNewSeed";
            this.btnNewSeed.Size = new System.Drawing.Size(75, 20);
            this.btnNewSeed.TabIndex = 0;
            this.btnNewSeed.Text = "New Seed";
            this.btnNewSeed.UseVisualStyleBackColor = true;
            this.btnNewSeed.Click += new System.EventHandler(this.btnNewSeed_Click);
            // 
            // btnEnterSeed
            // 
            this.btnEnterSeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEnterSeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnterSeed.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterSeed.Location = new System.Drawing.Point(181, 10);
            this.btnEnterSeed.Name = "btnEnterSeed";
            this.btnEnterSeed.Size = new System.Drawing.Size(92, 20);
            this.btnEnterSeed.TabIndex = 1;
            this.btnEnterSeed.Text = "Enter Seed";
            this.btnEnterSeed.UseVisualStyleBackColor = false;
            this.btnEnterSeed.Click += new System.EventHandler(this.btnEnterSeed_Click);
            // 
            // chkFirst
            // 
            this.chkFirst.AutoSize = true;
            this.chkFirst.Checked = true;
            this.chkFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.chkFirst.Location = new System.Drawing.Point(6, 36);
            this.chkFirst.Name = "chkFirst";
            this.chkFirst.Size = new System.Drawing.Size(63, 17);
            this.chkFirst.TabIndex = 8;
            this.chkFirst.Text = "Hallway";
            this.chkFirst.UseVisualStyleBackColor = true;
            // 
            // chkDownstairs
            // 
            this.chkDownstairs.AutoSize = true;
            this.chkDownstairs.Checked = true;
            this.chkDownstairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDownstairs.ForeColor = System.Drawing.SystemColors.Control;
            this.chkDownstairs.Location = new System.Drawing.Point(6, 58);
            this.chkDownstairs.Name = "chkDownstairs";
            this.chkDownstairs.Size = new System.Drawing.Size(78, 17);
            this.chkDownstairs.TabIndex = 9;
            this.chkDownstairs.Text = "Downstairs";
            this.chkDownstairs.UseVisualStyleBackColor = true;
            // 
            // chkUpstairs
            // 
            this.chkUpstairs.AutoSize = true;
            this.chkUpstairs.Checked = true;
            this.chkUpstairs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpstairs.ForeColor = System.Drawing.SystemColors.Control;
            this.chkUpstairs.Location = new System.Drawing.Point(86, 36);
            this.chkUpstairs.Name = "chkUpstairs";
            this.chkUpstairs.Size = new System.Drawing.Size(64, 17);
            this.chkUpstairs.TabIndex = 10;
            this.chkUpstairs.Text = "Upstairs";
            this.chkUpstairs.UseVisualStyleBackColor = true;
            // 
            // chkBowserStars
            // 
            this.chkBowserStars.AutoSize = true;
            this.chkBowserStars.Checked = true;
            this.chkBowserStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBowserStars.ForeColor = System.Drawing.SystemColors.Control;
            this.chkBowserStars.Location = new System.Drawing.Point(164, 36);
            this.chkBowserStars.Name = "chkBowserStars";
            this.chkBowserStars.Size = new System.Drawing.Size(88, 17);
            this.chkBowserStars.TabIndex = 11;
            this.chkBowserStars.Text = "Bowser Stars";
            this.chkBowserStars.UseVisualStyleBackColor = true;
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Checked = true;
            this.chkTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTop.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTop.Location = new System.Drawing.Point(86, 58);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(45, 17);
            this.chkTop.TabIndex = 12;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // chkSecretStars
            // 
            this.chkSecretStars.AutoSize = true;
            this.chkSecretStars.Checked = true;
            this.chkSecretStars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSecretStars.ForeColor = System.Drawing.SystemColors.Control;
            this.chkSecretStars.Location = new System.Drawing.Point(164, 58);
            this.chkSecretStars.Name = "chkSecretStars";
            this.chkSecretStars.Size = new System.Drawing.Size(84, 17);
            this.chkSecretStars.TabIndex = 13;
            this.chkSecretStars.Text = "Secret Stars";
            this.chkSecretStars.UseVisualStyleBackColor = true;
            // 
            // chkToads
            // 
            this.chkToads.AutoSize = true;
            this.chkToads.ForeColor = System.Drawing.SystemColors.Control;
            this.chkToads.Location = new System.Drawing.Point(164, 81);
            this.chkToads.Name = "chkToads";
            this.chkToads.Size = new System.Drawing.Size(56, 17);
            this.chkToads.TabIndex = 14;
            this.chkToads.Text = "Toads";
            this.chkToads.UseVisualStyleBackColor = true;
            // 
            // nudSeed
            // 
            this.nudSeed.BackColor = System.Drawing.SystemColors.ControlText;
            this.nudSeed.ForeColor = System.Drawing.SystemColors.Info;
            this.nudSeed.Location = new System.Drawing.Point(103, 10);
            this.nudSeed.Maximum = new decimal(new int[] {
            160000,
            0,
            0,
            0});
            this.nudSeed.Name = "nudSeed";
            this.nudSeed.Size = new System.Drawing.Size(71, 20);
            this.nudSeed.TabIndex = 24;
            // 
            // nudStarAmount
            // 
            this.nudStarAmount.BackColor = System.Drawing.SystemColors.InfoText;
            this.nudStarAmount.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.nudStarAmount.Location = new System.Drawing.Point(165, 12);
            this.nudStarAmount.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudStarAmount.Name = "nudStarAmount";
            this.nudStarAmount.Size = new System.Drawing.Size(72, 20);
            this.nudStarAmount.TabIndex = 25;
            this.nudStarAmount.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lvStars
            // 
            this.lvStars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvStars.BackColor = System.Drawing.SystemColors.InfoText;
            this.lvStars.ForeColor = System.Drawing.SystemColors.Info;
            this.lvStars.LabelWrap = false;
            this.lvStars.Location = new System.Drawing.Point(6, 104);
            this.lvStars.MinimumSize = new System.Drawing.Size(250, 150);
            this.lvStars.MultiSelect = false;
            this.lvStars.Name = "lvStars";
            this.lvStars.Size = new System.Drawing.Size(324, 380);
            this.lvStars.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvStars.TabIndex = 28;
            this.lvStars.TileSize = new System.Drawing.Size(220, 30);
            this.lvStars.UseCompatibleStateImageBehavior = false;
            this.lvStars.View = System.Windows.Forms.View.Tile;
            this.lvStars.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvStars_ItemSelectionChanged);
            // 
            // chk100CS
            // 
            this.chk100CS.AutoSize = true;
            this.chk100CS.Checked = true;
            this.chk100CS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk100CS.ForeColor = System.Drawing.SystemColors.Control;
            this.chk100CS.Location = new System.Drawing.Point(86, 81);
            this.chk100CS.Name = "chk100CS";
            this.chk100CS.Size = new System.Drawing.Size(73, 17);
            this.chk100CS.TabIndex = 29;
            this.chk100CS.Text = "100 Coins";
            this.chk100CS.UseVisualStyleBackColor = true;
            // 
            // chkMips
            // 
            this.chkMips.AutoSize = true;
            this.chkMips.ForeColor = System.Drawing.SystemColors.Control;
            this.chkMips.Location = new System.Drawing.Point(6, 81);
            this.chkMips.Name = "chkMips";
            this.chkMips.Size = new System.Drawing.Size(48, 17);
            this.chkMips.TabIndex = 30;
            this.chkMips.Text = "Mips";
            this.chkMips.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfStars
            // 
            this.lblNumberOfStars.AutoSize = true;
            this.lblNumberOfStars.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumberOfStars.Location = new System.Drawing.Point(69, 14);
            this.lblNumberOfStars.Name = "lblNumberOfStars";
            this.lblNumberOfStars.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfStars.TabIndex = 31;
            this.lblNumberOfStars.Text = "Number of Stars";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabSequence);
            this.tabControl1.Controls.Add(this.tabWarps);
            this.tabControl1.Controls.Add(this.tabClothes);
            this.tabControl1.Location = new System.Drawing.Point(23, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 511);
            this.tabControl1.TabIndex = 33;
            // 
            // tabSequence
            // 
            this.tabSequence.BackColor = System.Drawing.Color.Black;
            this.tabSequence.Controls.Add(this.btnRefreshList);
            this.tabSequence.Controls.Add(this.chkMips);
            this.tabSequence.Controls.Add(this.chkFirst);
            this.tabSequence.Controls.Add(this.lblNumberOfStars);
            this.tabSequence.Controls.Add(this.chkDownstairs);
            this.tabSequence.Controls.Add(this.chkUpstairs);
            this.tabSequence.Controls.Add(this.chk100CS);
            this.tabSequence.Controls.Add(this.chkBowserStars);
            this.tabSequence.Controls.Add(this.lvStars);
            this.tabSequence.Controls.Add(this.chkTop);
            this.tabSequence.Controls.Add(this.nudStarAmount);
            this.tabSequence.Controls.Add(this.chkSecretStars);
            this.tabSequence.Controls.Add(this.chkToads);
            this.tabSequence.ForeColor = System.Drawing.SystemColors.Control;
            this.tabSequence.Location = new System.Drawing.Point(4, 22);
            this.tabSequence.Name = "tabSequence";
            this.tabSequence.Padding = new System.Windows.Forms.Padding(3);
            this.tabSequence.Size = new System.Drawing.Size(336, 485);
            this.tabSequence.TabIndex = 0;
            this.tabSequence.Text = "Sequence (Vanilla)";
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshList.BackgroundImage")));
            this.btnRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefreshList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshList.Location = new System.Drawing.Point(258, 47);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(36, 36);
            this.btnRefreshList.TabIndex = 42;
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // tabWarps
            // 
            this.tabWarps.BackColor = System.Drawing.Color.Black;
            this.tabWarps.Controls.Add(this.checkBox1);
            this.tabWarps.Controls.Add(this.checkBox2);
            this.tabWarps.Controls.Add(this.chkRandomizeBowser);
            this.tabWarps.Controls.Add(this.label1);
            this.tabWarps.Controls.Add(this.txtBowserWarpId);
            this.tabWarps.ForeColor = System.Drawing.SystemColors.Control;
            this.tabWarps.Location = new System.Drawing.Point(4, 22);
            this.tabWarps.Name = "tabWarps";
            this.tabWarps.Padding = new System.Windows.Forms.Padding(3);
            this.tabWarps.Size = new System.Drawing.Size(336, 485);
            this.tabWarps.TabIndex = 5;
            this.tabWarps.Text = "Warps";
            // 
            // tabClothes
            // 
            this.tabClothes.BackColor = System.Drawing.Color.Black;
            this.tabClothes.Controls.Add(this.pColorHair);
            this.tabClothes.Controls.Add(this.pColorFace);
            this.tabClothes.Controls.Add(this.pColorShoes);
            this.tabClothes.Controls.Add(this.pColorGloves);
            this.tabClothes.Controls.Add(this.pColorArms);
            this.tabClothes.Controls.Add(this.pColorOveralls);
            this.tabClothes.Controls.Add(this.btnColorHair);
            this.tabClothes.Controls.Add(this.btnColorFace);
            this.tabClothes.Controls.Add(this.btnColorShoes);
            this.tabClothes.Controls.Add(this.btnColorGloves);
            this.tabClothes.Controls.Add(this.btnColorCapArms);
            this.tabClothes.Controls.Add(this.btnColorOveralls);
            this.tabClothes.Controls.Add(this.btnColorRestore);
            this.tabClothes.ForeColor = System.Drawing.SystemColors.Control;
            this.tabClothes.Location = new System.Drawing.Point(4, 22);
            this.tabClothes.Name = "tabClothes";
            this.tabClothes.Size = new System.Drawing.Size(336, 485);
            this.tabClothes.TabIndex = 3;
            this.tabClothes.Text = "Mario\'s Clothes";
            // 
            // pColorHair
            // 
            this.pColorHair.BackColor = System.Drawing.Color.White;
            this.pColorHair.Location = new System.Drawing.Point(169, 381);
            this.pColorHair.Name = "pColorHair";
            this.pColorHair.Size = new System.Drawing.Size(109, 23);
            this.pColorHair.TabIndex = 14;
            // 
            // pColorFace
            // 
            this.pColorFace.BackColor = System.Drawing.Color.White;
            this.pColorFace.Location = new System.Drawing.Point(169, 326);
            this.pColorFace.Name = "pColorFace";
            this.pColorFace.Size = new System.Drawing.Size(109, 23);
            this.pColorFace.TabIndex = 14;
            // 
            // pColorShoes
            // 
            this.pColorShoes.BackColor = System.Drawing.Color.White;
            this.pColorShoes.Location = new System.Drawing.Point(169, 271);
            this.pColorShoes.Name = "pColorShoes";
            this.pColorShoes.Size = new System.Drawing.Size(109, 23);
            this.pColorShoes.TabIndex = 14;
            // 
            // pColorGloves
            // 
            this.pColorGloves.BackColor = System.Drawing.Color.White;
            this.pColorGloves.Location = new System.Drawing.Point(169, 219);
            this.pColorGloves.Name = "pColorGloves";
            this.pColorGloves.Size = new System.Drawing.Size(109, 23);
            this.pColorGloves.TabIndex = 14;
            // 
            // pColorArms
            // 
            this.pColorArms.BackColor = System.Drawing.Color.White;
            this.pColorArms.Location = new System.Drawing.Point(169, 168);
            this.pColorArms.Name = "pColorArms";
            this.pColorArms.Size = new System.Drawing.Size(109, 23);
            this.pColorArms.TabIndex = 14;
            // 
            // pColorOveralls
            // 
            this.pColorOveralls.BackColor = System.Drawing.Color.White;
            this.pColorOveralls.Location = new System.Drawing.Point(169, 122);
            this.pColorOveralls.Name = "pColorOveralls";
            this.pColorOveralls.Size = new System.Drawing.Size(109, 23);
            this.pColorOveralls.TabIndex = 13;
            // 
            // btnColorHair
            // 
            this.btnColorHair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColorHair.Location = new System.Drawing.Point(46, 381);
            this.btnColorHair.Name = "btnColorHair";
            this.btnColorHair.Size = new System.Drawing.Size(75, 23);
            this.btnColorHair.TabIndex = 6;
            this.btnColorHair.Text = "Hair";
            this.btnColorHair.UseVisualStyleBackColor = true;
            this.btnColorHair.Click += new System.EventHandler(this.btnColorHair_Click);
            // 
            // btnColorFace
            // 
            this.btnColorFace.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColorFace.Location = new System.Drawing.Point(46, 326);
            this.btnColorFace.Name = "btnColorFace";
            this.btnColorFace.Size = new System.Drawing.Size(75, 23);
            this.btnColorFace.TabIndex = 5;
            this.btnColorFace.Text = "Face";
            this.btnColorFace.UseVisualStyleBackColor = true;
            this.btnColorFace.Click += new System.EventHandler(this.btnColorFace_Click);
            // 
            // btnColorShoes
            // 
            this.btnColorShoes.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColorShoes.Location = new System.Drawing.Point(46, 271);
            this.btnColorShoes.Name = "btnColorShoes";
            this.btnColorShoes.Size = new System.Drawing.Size(75, 23);
            this.btnColorShoes.TabIndex = 4;
            this.btnColorShoes.Text = "Shoes";
            this.btnColorShoes.UseVisualStyleBackColor = true;
            this.btnColorShoes.Click += new System.EventHandler(this.btnColorShoes_Click);
            // 
            // btnColorGloves
            // 
            this.btnColorGloves.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColorGloves.Location = new System.Drawing.Point(46, 219);
            this.btnColorGloves.Name = "btnColorGloves";
            this.btnColorGloves.Size = new System.Drawing.Size(75, 23);
            this.btnColorGloves.TabIndex = 3;
            this.btnColorGloves.Text = "Gloves";
            this.btnColorGloves.UseVisualStyleBackColor = true;
            this.btnColorGloves.Click += new System.EventHandler(this.btnColorGloves_Click);
            // 
            // btnColorCapArms
            // 
            this.btnColorCapArms.ForeColor = System.Drawing.Color.Black;
            this.btnColorCapArms.Location = new System.Drawing.Point(46, 168);
            this.btnColorCapArms.Name = "btnColorCapArms";
            this.btnColorCapArms.Size = new System.Drawing.Size(75, 23);
            this.btnColorCapArms.TabIndex = 2;
            this.btnColorCapArms.Text = "Cap Arms Shirt";
            this.btnColorCapArms.UseVisualStyleBackColor = true;
            this.btnColorCapArms.Click += new System.EventHandler(this.btnColorCapArms_Click);
            // 
            // btnColorOveralls
            // 
            this.btnColorOveralls.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnColorOveralls.Location = new System.Drawing.Point(46, 122);
            this.btnColorOveralls.Name = "btnColorOveralls";
            this.btnColorOveralls.Size = new System.Drawing.Size(75, 23);
            this.btnColorOveralls.TabIndex = 1;
            this.btnColorOveralls.Text = "Overalls";
            this.btnColorOveralls.UseVisualStyleBackColor = true;
            this.btnColorOveralls.Click += new System.EventHandler(this.btnColorOveralls_Click);
            // 
            // btnColorRestore
            // 
            this.btnColorRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColorRestore.Location = new System.Drawing.Point(46, 65);
            this.btnColorRestore.Name = "btnColorRestore";
            this.btnColorRestore.Size = new System.Drawing.Size(75, 23);
            this.btnColorRestore.TabIndex = 0;
            this.btnColorRestore.Text = "Restore";
            this.btnColorRestore.UseVisualStyleBackColor = true;
            this.btnColorRestore.Click += new System.EventHandler(this.btnColorRestore_Click);
            // 
            // chkRandomizeText
            // 
            this.chkRandomizeText.AutoSize = true;
            this.chkRandomizeText.Enabled = false;
            this.chkRandomizeText.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeText.Location = new System.Drawing.Point(206, 89);
            this.chkRandomizeText.Name = "chkRandomizeText";
            this.chkRandomizeText.Size = new System.Drawing.Size(47, 17);
            this.chkRandomizeText.TabIndex = 0;
            this.chkRandomizeText.Text = "Text";
            this.chkRandomizeText.UseVisualStyleBackColor = true;
            // 
            // btnSaveRom
            // 
            this.btnSaveRom.Location = new System.Drawing.Point(185, 36);
            this.btnSaveRom.Name = "btnSaveRom";
            this.btnSaveRom.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRom.TabIndex = 36;
            this.btnSaveRom.Text = "Save Rom";
            this.btnSaveRom.UseVisualStyleBackColor = true;
            this.btnSaveRom.Click += new System.EventHandler(this.btnSaveRom_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(104, 36);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 35;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnOpenRom
            // 
            this.btnOpenRom.Location = new System.Drawing.Point(23, 36);
            this.btnOpenRom.Name = "btnOpenRom";
            this.btnOpenRom.Size = new System.Drawing.Size(75, 23);
            this.btnOpenRom.TabIndex = 34;
            this.btnOpenRom.Text = "Open Rom";
            this.btnOpenRom.UseVisualStyleBackColor = true;
            this.btnOpenRom.Click += new System.EventHandler(this.btnOpenRom_Click);
            // 
            // chkRandomizeEnemies
            // 
            this.chkRandomizeEnemies.AutoSize = true;
            this.chkRandomizeEnemies.Checked = true;
            this.chkRandomizeEnemies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeEnemies.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeEnemies.Location = new System.Drawing.Point(104, 66);
            this.chkRandomizeEnemies.Name = "chkRandomizeEnemies";
            this.chkRandomizeEnemies.Size = new System.Drawing.Size(66, 17);
            this.chkRandomizeEnemies.TabIndex = 40;
            this.chkRandomizeEnemies.Text = "Enemies";
            this.chkRandomizeEnemies.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMarioClothes
            // 
            this.chkRandomizeMarioClothes.AutoSize = true;
            this.chkRandomizeMarioClothes.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeMarioClothes.Location = new System.Drawing.Point(104, 89);
            this.chkRandomizeMarioClothes.Name = "chkRandomizeMarioClothes";
            this.chkRandomizeMarioClothes.Size = new System.Drawing.Size(97, 17);
            this.chkRandomizeMarioClothes.TabIndex = 39;
            this.chkRandomizeMarioClothes.Text = "Mario\'s Clothes";
            this.chkRandomizeMarioClothes.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMusic
            // 
            this.chkRandomizeMusic.AutoSize = true;
            this.chkRandomizeMusic.Checked = true;
            this.chkRandomizeMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeMusic.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeMusic.Location = new System.Drawing.Point(23, 89);
            this.chkRandomizeMusic.Name = "chkRandomizeMusic";
            this.chkRandomizeMusic.Size = new System.Drawing.Size(54, 17);
            this.chkRandomizeMusic.TabIndex = 38;
            this.chkRandomizeMusic.Text = "Music";
            this.chkRandomizeMusic.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeWarps
            // 
            this.chkRandomizeWarps.AutoSize = true;
            this.chkRandomizeWarps.Checked = true;
            this.chkRandomizeWarps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeWarps.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeWarps.Location = new System.Drawing.Point(23, 65);
            this.chkRandomizeWarps.Name = "chkRandomizeWarps";
            this.chkRandomizeWarps.Size = new System.Drawing.Size(57, 17);
            this.chkRandomizeWarps.TabIndex = 37;
            this.chkRandomizeWarps.Text = "Warps";
            this.chkRandomizeWarps.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeTextures
            // 
            this.chkRandomizeTextures.AutoSize = true;
            this.chkRandomizeTextures.Enabled = false;
            this.chkRandomizeTextures.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeTextures.Location = new System.Drawing.Point(206, 66);
            this.chkRandomizeTextures.Name = "chkRandomizeTextures";
            this.chkRandomizeTextures.Size = new System.Drawing.Size(67, 17);
            this.chkRandomizeTextures.TabIndex = 41;
            this.chkRandomizeTextures.Text = "Textures";
            this.chkRandomizeTextures.UseVisualStyleBackColor = true;
            this.chkRandomizeTextures.Visible = false;
            // 
            // txtBowserWarpId
            // 
            this.txtBowserWarpId.Location = new System.Drawing.Point(143, 120);
            this.txtBowserWarpId.Name = "txtBowserWarpId";
            this.txtBowserWarpId.Size = new System.Drawing.Size(162, 20);
            this.txtBowserWarpId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bowser Warp Id";
            // 
            // chkRandomizeBowser
            // 
            this.chkRandomizeBowser.AutoSize = true;
            this.chkRandomizeBowser.Location = new System.Drawing.Point(36, 38);
            this.chkRandomizeBowser.Name = "chkRandomizeBowser";
            this.chkRandomizeBowser.Size = new System.Drawing.Size(146, 17);
            this.chkRandomizeBowser.TabIndex = 2;
            this.chkRandomizeBowser.Text = "Randomize Bowser Warp";
            this.chkRandomizeBowser.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(36, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Output Warp File";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(36, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Randomize Paintings";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(404, 644);
            this.Controls.Add(this.chkRandomizeText);
            this.Controls.Add(this.chkRandomizeTextures);
            this.Controls.Add(this.chkRandomizeEnemies);
            this.Controls.Add(this.chkRandomizeMarioClothes);
            this.Controls.Add(this.chkRandomizeMusic);
            this.Controls.Add(this.chkRandomizeWarps);
            this.Controls.Add(this.btnSaveRom);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnOpenRom);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.nudSeed);
            this.Controls.Add(this.btnEnterSeed);
            this.Controls.Add(this.btnNewSeed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 1080);
            this.MinimumSize = new System.Drawing.Size(420, 350);
            this.Name = "Main";
            this.Text = "Super Mario 64 Randomizer v0.75";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSequence.ResumeLayout(false);
            this.tabSequence.PerformLayout();
            this.tabWarps.ResumeLayout(false);
            this.tabWarps.PerformLayout();
            this.tabClothes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewSeed;
        private System.Windows.Forms.Button btnEnterSeed;
        private System.Windows.Forms.CheckBox chkFirst;
        private System.Windows.Forms.CheckBox chkDownstairs;
        private System.Windows.Forms.CheckBox chkUpstairs;
        private System.Windows.Forms.CheckBox chkBowserStars;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkSecretStars;
        private System.Windows.Forms.CheckBox chkToads;
        private System.Windows.Forms.NumericUpDown nudSeed;
        private System.Windows.Forms.NumericUpDown nudStarAmount;
        private System.Windows.Forms.ListView lvStars;
        private System.Windows.Forms.CheckBox chk100CS;
        private System.Windows.Forms.CheckBox chkMips;
        private System.Windows.Forms.Label lblNumberOfStars;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSequence;
        private System.Windows.Forms.Button btnSaveRom;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnOpenRom;
        private System.Windows.Forms.CheckBox chkRandomizeEnemies;
        private System.Windows.Forms.CheckBox chkRandomizeMarioClothes;
        private System.Windows.Forms.CheckBox chkRandomizeMusic;
        private System.Windows.Forms.CheckBox chkRandomizeWarps;
        private System.Windows.Forms.TabPage tabClothes;
        private System.Windows.Forms.ColorDialog cdClothes;
        private System.Windows.Forms.Button btnColorRestore;
        private System.Windows.Forms.CheckBox chkRandomizeTextures;
        private System.Windows.Forms.Button btnColorHair;
        private System.Windows.Forms.Button btnColorFace;
        private System.Windows.Forms.Button btnColorShoes;
        private System.Windows.Forms.Button btnColorGloves;
        private System.Windows.Forms.Button btnColorCapArms;
        private System.Windows.Forms.Button btnColorOveralls;
        private System.Windows.Forms.Panel pColorOveralls;
        private System.Windows.Forms.Panel pColorHair;
        private System.Windows.Forms.Panel pColorFace;
        private System.Windows.Forms.Panel pColorShoes;
        private System.Windows.Forms.Panel pColorGloves;
        private System.Windows.Forms.Panel pColorArms;
        private System.Windows.Forms.CheckBox chkRandomizeText;
        private System.Windows.Forms.TabPage tabWarps;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkRandomizeBowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBowserWarpId;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

