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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveRom = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnOpenRom = new System.Windows.Forms.Button();
            this.chkRandomizeEnemies = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMarioClothes = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMusic = new System.Windows.Forms.CheckBox();
            this.chkRandomizeWarps = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.chkFirst.Location = new System.Drawing.Point(6, 25);
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
            this.chkDownstairs.Location = new System.Drawing.Point(6, 47);
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
            this.chkUpstairs.Location = new System.Drawing.Point(86, 25);
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
            this.chkBowserStars.Location = new System.Drawing.Point(164, 25);
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
            this.chkTop.Location = new System.Drawing.Point(86, 47);
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
            this.chkSecretStars.Location = new System.Drawing.Point(164, 47);
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
            this.chkToads.Location = new System.Drawing.Point(164, 70);
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
            this.nudStarAmount.Location = new System.Drawing.Point(86, 0);
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
            this.lvStars.Location = new System.Drawing.Point(6, 93);
            this.lvStars.MinimumSize = new System.Drawing.Size(250, 150);
            this.lvStars.MultiSelect = false;
            this.lvStars.Name = "lvStars";
            this.lvStars.Size = new System.Drawing.Size(324, 761);
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
            this.chk100CS.Location = new System.Drawing.Point(86, 70);
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
            this.chkMips.Location = new System.Drawing.Point(6, 70);
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
            this.lblNumberOfStars.Location = new System.Drawing.Point(3, 2);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(23, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 511);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.chkMips);
            this.tabPage1.Controls.Add(this.chkFirst);
            this.tabPage1.Controls.Add(this.lblNumberOfStars);
            this.tabPage1.Controls.Add(this.chkDownstairs);
            this.tabPage1.Controls.Add(this.chkUpstairs);
            this.tabPage1.Controls.Add(this.chk100CS);
            this.tabPage1.Controls.Add(this.chkBowserStars);
            this.tabPage1.Controls.Add(this.lvStars);
            this.tabPage1.Controls.Add(this.chkTop);
            this.tabPage1.Controls.Add(this.nudStarAmount);
            this.tabPage1.Controls.Add(this.chkSecretStars);
            this.tabPage1.Controls.Add(this.chkToads);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sequence";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sound";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Banks";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(46, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "SFX";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Music";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.checkBox5);
            this.tabPage3.Controls.Add(this.checkBox4);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(336, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Warps";
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
            this.chkRandomizeEnemies.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeEnemies.Location = new System.Drawing.Point(130, 65);
            this.chkRandomizeEnemies.Name = "chkRandomizeEnemies";
            this.chkRandomizeEnemies.Size = new System.Drawing.Size(66, 17);
            this.chkRandomizeEnemies.TabIndex = 40;
            this.chkRandomizeEnemies.Text = "Enemies";
            this.chkRandomizeEnemies.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMarioClothes
            // 
            this.chkRandomizeMarioClothes.AutoSize = true;
            this.chkRandomizeMarioClothes.Enabled = false;
            this.chkRandomizeMarioClothes.ForeColor = System.Drawing.SystemColors.Control;
            this.chkRandomizeMarioClothes.Location = new System.Drawing.Point(130, 88);
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
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(336, 485);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mario\'s Clothes";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(13, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Just Paintings";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(13, 44);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 17);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "No Logic";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(14, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(404, 644);
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
            this.Text = "Super Mario 64 Randomizer v0.6";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarAmount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveRom;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnOpenRom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkRandomizeEnemies;
        private System.Windows.Forms.CheckBox chkRandomizeMarioClothes;
        private System.Windows.Forms.CheckBox chkRandomizeMusic;
        private System.Windows.Forms.CheckBox chkRandomizeWarps;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
    }
}

