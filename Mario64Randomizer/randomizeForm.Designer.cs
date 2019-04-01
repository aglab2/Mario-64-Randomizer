namespace Mario64Randomizer
{
    partial class randomizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randomizeForm));
            this.chkRandomizeWarps = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMusic = new System.Windows.Forms.CheckBox();
            this.chkRandomizeMarioClothes = new System.Windows.Forms.CheckBox();
            this.btnOpenRom = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.chkRandomizeEnemies = new System.Windows.Forms.CheckBox();
            this.btnSaveRom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkRandomizeWarps
            // 
            this.chkRandomizeWarps.AutoSize = true;
            this.chkRandomizeWarps.Checked = true;
            this.chkRandomizeWarps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeWarps.Location = new System.Drawing.Point(13, 13);
            this.chkRandomizeWarps.Name = "chkRandomizeWarps";
            this.chkRandomizeWarps.Size = new System.Drawing.Size(57, 17);
            this.chkRandomizeWarps.TabIndex = 0;
            this.chkRandomizeWarps.Text = "Warps";
            this.chkRandomizeWarps.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMusic
            // 
            this.chkRandomizeMusic.AutoSize = true;
            this.chkRandomizeMusic.Checked = true;
            this.chkRandomizeMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRandomizeMusic.Location = new System.Drawing.Point(13, 37);
            this.chkRandomizeMusic.Name = "chkRandomizeMusic";
            this.chkRandomizeMusic.Size = new System.Drawing.Size(54, 17);
            this.chkRandomizeMusic.TabIndex = 1;
            this.chkRandomizeMusic.Text = "Music";
            this.chkRandomizeMusic.UseVisualStyleBackColor = true;
            // 
            // chkRandomizeMarioClothes
            // 
            this.chkRandomizeMarioClothes.AutoSize = true;
            this.chkRandomizeMarioClothes.Enabled = false;
            this.chkRandomizeMarioClothes.Location = new System.Drawing.Point(120, 36);
            this.chkRandomizeMarioClothes.Name = "chkRandomizeMarioClothes";
            this.chkRandomizeMarioClothes.Size = new System.Drawing.Size(97, 17);
            this.chkRandomizeMarioClothes.TabIndex = 2;
            this.chkRandomizeMarioClothes.Text = "Mario\'s Clothes";
            this.chkRandomizeMarioClothes.UseVisualStyleBackColor = true;
            // 
            // btnOpenRom
            // 
            this.btnOpenRom.Location = new System.Drawing.Point(13, 60);
            this.btnOpenRom.Name = "btnOpenRom";
            this.btnOpenRom.Size = new System.Drawing.Size(75, 23);
            this.btnOpenRom.TabIndex = 3;
            this.btnOpenRom.Text = "Open Rom";
            this.btnOpenRom.UseVisualStyleBackColor = true;
            this.btnOpenRom.Click += new System.EventHandler(this.btnOpenRom_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(120, 59);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 23);
            this.btnRandomize.TabIndex = 4;
            this.btnRandomize.Text = "Randomize";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // chkRandomizeEnemies
            // 
            this.chkRandomizeEnemies.AutoSize = true;
            this.chkRandomizeEnemies.Location = new System.Drawing.Point(120, 13);
            this.chkRandomizeEnemies.Name = "chkRandomizeEnemies";
            this.chkRandomizeEnemies.Size = new System.Drawing.Size(66, 17);
            this.chkRandomizeEnemies.TabIndex = 5;
            this.chkRandomizeEnemies.Text = "Enemies";
            this.chkRandomizeEnemies.UseVisualStyleBackColor = true;
            // 
            // btnSaveRom
            // 
            this.btnSaveRom.Location = new System.Drawing.Point(12, 89);
            this.btnSaveRom.Name = "btnSaveRom";
            this.btnSaveRom.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRom.TabIndex = 6;
            this.btnSaveRom.Text = "Save Rom";
            this.btnSaveRom.UseVisualStyleBackColor = true;
            this.btnSaveRom.Click += new System.EventHandler(this.btnSaveRom_Click);
            // 
            // randomizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 124);
            this.Controls.Add(this.btnSaveRom);
            this.Controls.Add(this.chkRandomizeEnemies);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnOpenRom);
            this.Controls.Add(this.chkRandomizeMarioClothes);
            this.Controls.Add(this.chkRandomizeMusic);
            this.Controls.Add(this.chkRandomizeWarps);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "randomizeForm";
            this.Text = "Randomize Rom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRandomizeWarps;
        private System.Windows.Forms.CheckBox chkRandomizeMusic;
        private System.Windows.Forms.CheckBox chkRandomizeMarioClothes;
        private System.Windows.Forms.Button btnOpenRom;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.CheckBox chkRandomizeEnemies;
        private System.Windows.Forms.Button btnSaveRom;
    }
}