using System.IO;
using System.Windows.Forms;

namespace Assignment2
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPushes = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "None.png");
            this.imageList.Images.SetKeyName(1, "Player.png");
            this.imageList.Images.SetKeyName(2, "Wall.png");
            this.imageList.Images.SetKeyName(3, "Box.png");
            this.imageList.Images.SetKeyName(4, "Destination.png");
            this.imageList.Images.SetKeyName(5, "DestinationOnBox.png");
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.DefaultExt = "skbn";
            // 
            // pnlGame
            // 
            this.pnlGame.AutoSize = true;
            this.pnlGame.Location = new System.Drawing.Point(13, 28);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(450, 406);
            this.pnlGame.TabIndex = 1;
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(467, 54);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.ShortcutsEnabled = false;
            this.txtMoves.Size = new System.Drawing.Size(100, 20);
            this.txtMoves.TabIndex = 2;
            this.txtMoves.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Moves";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pushes";
            // 
            // txtPushes
            // 
            this.txtPushes.Location = new System.Drawing.Point(467, 110);
            this.txtPushes.Name = "txtPushes";
            this.txtPushes.ReadOnly = true;
            this.txtPushes.ShortcutsEnabled = false;
            this.txtPushes.Size = new System.Drawing.Size(100, 20);
            this.txtPushes.TabIndex = 4;
            this.txtPushes.Text = "0";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(490, 275);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(63, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.GamepadInput);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(470, 301);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(50, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.GamepadInput);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(523, 301);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(51, 23);
            this.btnRight.TabIndex = 8;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.GamepadInput);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(490, 327);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(63, 23);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.GamepadInput);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filled: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(507, 148);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 11;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 436);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPushes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOKOBAN";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardInput);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPushes;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private Label label3;
        private Label lblScore;
    }
}