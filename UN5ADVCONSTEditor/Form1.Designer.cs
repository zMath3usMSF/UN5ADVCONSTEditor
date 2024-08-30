namespace UN5ADVCONSTEditor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveADVCONSTCCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveADVCONSTCCSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllStageNamesToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAllStageNamesFromTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFPlposDMY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFBgdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFCCS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFMapTEX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFIconPosX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFIconPosY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFIconScaleX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFIconScaleY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBFBgdata = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBFCCS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addNewStageToolStripMenuItem,
            this.utilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveADVCONSTCCSToolStripMenuItem,
            this.saveADVCONSTCCSToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveADVCONSTCCSToolStripMenuItem
            // 
            this.saveADVCONSTCCSToolStripMenuItem.Name = "saveADVCONSTCCSToolStripMenuItem";
            this.saveADVCONSTCCSToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveADVCONSTCCSToolStripMenuItem.Text = "Open ADVCONST.CCS";
            this.saveADVCONSTCCSToolStripMenuItem.Click += new System.EventHandler(this.saveADVCONSTCCSToolStripMenuItem_Click);
            // 
            // saveADVCONSTCCSToolStripMenuItem1
            // 
            this.saveADVCONSTCCSToolStripMenuItem1.Enabled = false;
            this.saveADVCONSTCCSToolStripMenuItem1.Name = "saveADVCONSTCCSToolStripMenuItem1";
            this.saveADVCONSTCCSToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.saveADVCONSTCCSToolStripMenuItem1.Text = "Save ADVCONST.CCS";
            this.saveADVCONSTCCSToolStripMenuItem1.Click += new System.EventHandler(this.saveADVCONSTCCSToolStripMenuItem1_Click);
            // 
            // addNewStageToolStripMenuItem
            // 
            this.addNewStageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.addNewStageToolStripMenuItem.Enabled = false;
            this.addNewStageToolStripMenuItem.Name = "addNewStageToolStripMenuItem";
            this.addNewStageToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.addNewStageToolStripMenuItem.Text = "Stage";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // utilToolStripMenuItem
            // 
            this.utilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAllStageNamesToTXTToolStripMenuItem,
            this.importAllStageNamesFromTXTToolStripMenuItem});
            this.utilToolStripMenuItem.Enabled = false;
            this.utilToolStripMenuItem.Name = "utilToolStripMenuItem";
            this.utilToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.utilToolStripMenuItem.Text = "Util";
            // 
            // exportAllStageNamesToTXTToolStripMenuItem
            // 
            this.exportAllStageNamesToTXTToolStripMenuItem.Name = "exportAllStageNamesToTXTToolStripMenuItem";
            this.exportAllStageNamesToTXTToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.exportAllStageNamesToTXTToolStripMenuItem.Text = "Export All Stage Names to TXT";
            this.exportAllStageNamesToTXTToolStripMenuItem.Click += new System.EventHandler(this.exportAllStageNamesToTXTToolStripMenuItem_Click);
            // 
            // importAllStageNamesFromTXTToolStripMenuItem
            // 
            this.importAllStageNamesFromTXTToolStripMenuItem.Name = "importAllStageNamesFromTXTToolStripMenuItem";
            this.importAllStageNamesFromTXTToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.importAllStageNamesFromTXTToolStripMenuItem.Text = "Import All Stage Names from TXT";
            this.importAllStageNamesFromTXTToolStripMenuItem.Click += new System.EventHandler(this.importAllStageNamesFromTXTToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 426);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFPlposDMY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFBgdata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFCCS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(229, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stage";
            // 
            // txtFPlposDMY
            // 
            this.txtFPlposDMY.Location = new System.Drawing.Point(389, 43);
            this.txtFPlposDMY.MaxLength = 32;
            this.txtFPlposDMY.Name = "txtFPlposDMY";
            this.txtFPlposDMY.Size = new System.Drawing.Size(164, 20);
            this.txtFPlposDMY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Player Position DMY:";
            // 
            // txtFBgdata
            // 
            this.txtFBgdata.Location = new System.Drawing.Point(128, 43);
            this.txtFBgdata.MaxLength = 32;
            this.txtFBgdata.Name = "txtFBgdata";
            this.txtFBgdata.Size = new System.Drawing.Size(143, 20);
            this.txtFBgdata.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Background Data BIN:";
            // 
            // txtFCCS
            // 
            this.txtFCCS.Location = new System.Drawing.Point(314, 17);
            this.txtFCCS.MaxLength = 32;
            this.txtFCCS.Name = "txtFCCS";
            this.txtFCCS.Size = new System.Drawing.Size(239, 20);
            this.txtFCCS.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CCS:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(51, 17);
            this.txtFName.MaxLength = 32;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(220, 20);
            this.txtFName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtFMapTEX
            // 
            this.txtFMapTEX.Location = new System.Drawing.Point(86, 19);
            this.txtFMapTEX.MaxLength = 32;
            this.txtFMapTEX.Name = "txtFMapTEX";
            this.txtFMapTEX.Size = new System.Drawing.Size(130, 20);
            this.txtFMapTEX.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Minimap TEX:";
            // 
            // txtFIconPosX
            // 
            this.txtFIconPosX.Location = new System.Drawing.Point(314, 19);
            this.txtFIconPosX.MaxLength = 32;
            this.txtFIconPosX.Name = "txtFIconPosX";
            this.txtFIconPosX.Size = new System.Drawing.Size(73, 20);
            this.txtFIconPosX.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Icons Position X:";
            // 
            // txtFIconPosY
            // 
            this.txtFIconPosY.Location = new System.Drawing.Point(480, 19);
            this.txtFIconPosY.MaxLength = 32;
            this.txtFIconPosY.Name = "txtFIconPosY";
            this.txtFIconPosY.Size = new System.Drawing.Size(73, 20);
            this.txtFIconPosY.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Icons Position Y:";
            // 
            // txtFIconScaleX
            // 
            this.txtFIconScaleX.Location = new System.Drawing.Point(86, 45);
            this.txtFIconScaleX.MaxLength = 32;
            this.txtFIconScaleX.Name = "txtFIconScaleX";
            this.txtFIconScaleX.Size = new System.Drawing.Size(73, 20);
            this.txtFIconScaleX.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Icons Scale X:";
            // 
            // txtFIconScaleY
            // 
            this.txtFIconScaleY.Location = new System.Drawing.Point(247, 45);
            this.txtFIconScaleY.MaxLength = 32;
            this.txtFIconScaleY.Name = "txtFIconScaleY";
            this.txtFIconScaleY.Size = new System.Drawing.Size(73, 20);
            this.txtFIconScaleY.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Icons Scale Y:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBFBgdata);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtBFCCS);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(229, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Battle Stage";
            // 
            // txtBFBgdata
            // 
            this.txtBFBgdata.Location = new System.Drawing.Point(410, 19);
            this.txtBFBgdata.MaxLength = 32;
            this.txtBFBgdata.Name = "txtBFBgdata";
            this.txtBFBgdata.Size = new System.Drawing.Size(143, 20);
            this.txtBFBgdata.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Background Data BIN:";
            // 
            // txtBFCCS
            // 
            this.txtBFCCS.Location = new System.Drawing.Point(43, 19);
            this.txtBFCCS.MaxLength = 32;
            this.txtBFCCS.Name = "txtBFCCS";
            this.txtBFCCS.Size = new System.Drawing.Size(239, 20);
            this.txtBFCCS.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "CCS:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFIconScaleY);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtFMapTEX);
            this.groupBox3.Controls.Add(this.txtFIconScaleX);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtFIconPosX);
            this.groupBox3.Controls.Add(this.txtFIconPosY);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(229, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 78);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minimap";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UN5ADVCONSTEditor.Properties.Resources.ADVCONSTBackgroundImage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADVCONST.CCS Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveADVCONSTCCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveADVCONSTCCSToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFCCS;
        private System.Windows.Forms.TextBox txtFIconScaleY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFIconScaleX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFIconPosY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFIconPosX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFMapTEX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFPlposDMY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFBgdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem addNewStageToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBFCCS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem utilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAllStageNamesToTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAllStageNamesFromTXTToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBFBgdata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

