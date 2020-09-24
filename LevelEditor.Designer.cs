namespace Assignment2
{
    partial class LevelEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRadio1 = new System.Windows.Forms.RadioButton();
            this.btnRadio4 = new System.Windows.Forms.RadioButton();
            this.btnRadio3 = new System.Windows.Forms.RadioButton();
            this.btnRadio2 = new System.Windows.Forms.RadioButton();
            this.btnRadio0 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(49, 32);
            this.txtRows.Margin = new System.Windows.Forms.Padding(2);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(46, 20);
            this.txtRows.TabIndex = 2;
            this.txtRows.Text = "5";
            this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(168, 32);
            this.txtColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(46, 20);
            this.txtColumns.TabIndex = 4;
            this.txtColumns.Text = "5";
            this.txtColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(245, 32);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(62, 20);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toolbox";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "None.png");
            this.imageList1.Images.SetKeyName(1, "Player.png");
            this.imageList1.Images.SetKeyName(2, "Wall.png");
            this.imageList1.Images.SetKeyName(3, "Box.png");
            this.imageList1.Images.SetKeyName(4, "Destination.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRadio1);
            this.panel1.Controls.Add(this.btnRadio4);
            this.panel1.Controls.Add(this.btnRadio3);
            this.panel1.Controls.Add(this.btnRadio2);
            this.panel1.Controls.Add(this.btnRadio0);
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 299);
            this.panel1.TabIndex = 16;
            // 
            // btnRadio1
            // 
            this.btnRadio1.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRadio1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio1.ImageIndex = 1;
            this.btnRadio1.ImageList = this.imageList1;
            this.btnRadio1.Location = new System.Drawing.Point(3, 61);
            this.btnRadio1.Margin = new System.Windows.Forms.Padding(1);
            this.btnRadio1.Name = "btnRadio1";
            this.btnRadio1.Size = new System.Drawing.Size(116, 56);
            this.btnRadio1.TabIndex = 19;
            this.btnRadio1.TabStop = true;
            this.btnRadio1.Text = "Hero";
            this.btnRadio1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRadio1.UseVisualStyleBackColor = true;
            this.btnRadio1.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // btnRadio4
            // 
            this.btnRadio4.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRadio4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio4.ImageIndex = 4;
            this.btnRadio4.ImageList = this.imageList1;
            this.btnRadio4.Location = new System.Drawing.Point(3, 235);
            this.btnRadio4.Margin = new System.Windows.Forms.Padding(1);
            this.btnRadio4.Name = "btnRadio4";
            this.btnRadio4.Size = new System.Drawing.Size(116, 56);
            this.btnRadio4.TabIndex = 18;
            this.btnRadio4.TabStop = true;
            this.btnRadio4.Text = "Storage";
            this.btnRadio4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRadio4.UseVisualStyleBackColor = true;
            this.btnRadio4.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // btnRadio3
            // 
            this.btnRadio3.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRadio3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio3.ImageIndex = 3;
            this.btnRadio3.ImageList = this.imageList1;
            this.btnRadio3.Location = new System.Drawing.Point(3, 177);
            this.btnRadio3.Margin = new System.Windows.Forms.Padding(1);
            this.btnRadio3.Name = "btnRadio3";
            this.btnRadio3.Size = new System.Drawing.Size(116, 56);
            this.btnRadio3.TabIndex = 17;
            this.btnRadio3.TabStop = true;
            this.btnRadio3.Text = "Box";
            this.btnRadio3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRadio3.UseVisualStyleBackColor = true;
            this.btnRadio3.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // btnRadio2
            // 
            this.btnRadio2.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRadio2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio2.ImageIndex = 2;
            this.btnRadio2.ImageList = this.imageList1;
            this.btnRadio2.Location = new System.Drawing.Point(3, 119);
            this.btnRadio2.Margin = new System.Windows.Forms.Padding(1);
            this.btnRadio2.Name = "btnRadio2";
            this.btnRadio2.Size = new System.Drawing.Size(116, 56);
            this.btnRadio2.TabIndex = 16;
            this.btnRadio2.TabStop = true;
            this.btnRadio2.Text = "Wall";
            this.btnRadio2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRadio2.UseVisualStyleBackColor = true;
            this.btnRadio2.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // btnRadio0
            // 
            this.btnRadio0.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRadio0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRadio0.ImageIndex = 0;
            this.btnRadio0.ImageList = this.imageList1;
            this.btnRadio0.Location = new System.Drawing.Point(3, 3);
            this.btnRadio0.Margin = new System.Windows.Forms.Padding(1);
            this.btnRadio0.Name = "btnRadio0";
            this.btnRadio0.Size = new System.Drawing.Size(116, 56);
            this.btnRadio0.TabIndex = 15;
            this.btnRadio0.TabStop = true;
            this.btnRadio0.Text = "None";
            this.btnRadio0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRadio0.UseVisualStyleBackColor = true;
            this.btnRadio0.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "skbn";
            this.saveFileDialog1.Filter = "SOKOBAN Files|*.skbn|All Files|*.*";
            this.saveFileDialog1.Title = "Save Map File";
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(618, 438);
            this.Name = "LevelEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban Level Editor";
            this.Load += new System.EventHandler(this.LevelEditor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.RadioButton btnRadio0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton btnRadio1;
        private System.Windows.Forms.RadioButton btnRadio4;
        private System.Windows.Forms.RadioButton btnRadio3;
        private System.Windows.Forms.RadioButton btnRadio2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}