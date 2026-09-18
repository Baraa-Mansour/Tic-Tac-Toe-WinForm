namespace Tic_Tac_Toe
{
    partial class FrmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicTacToe));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCell8 = new System.Windows.Forms.Button();
            this.btnCell7 = new System.Windows.Forms.Button();
            this.btnCell5 = new System.Windows.Forms.Button();
            this.btnCell4 = new System.Windows.Forms.Button();
            this.btnCell9 = new System.Windows.Forms.Button();
            this.btnCell6 = new System.Windows.Forms.Button();
            this.btnCell3 = new System.Windows.Forms.Button();
            this.btnCell2 = new System.Windows.Forms.Button();
            this.btnCell1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(500, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 97);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tic Tac Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer.Location = new System.Drawing.Point(81, 315);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(212, 73);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 73);
            this.label4.TabIndex = 4;
            this.label4.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(81, 461);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(273, 73);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Vladimir Script", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(62, 558);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(231, 61);
            this.btnRestart.TabIndex = 9;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCell8
            // 
            this.btnCell8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell8.Image = ((System.Drawing.Image)(resources.GetObject("btnCell8.Image")));
            this.btnCell8.Location = new System.Drawing.Point(575, 519);
            this.btnCell8.Name = "btnCell8";
            this.btnCell8.Size = new System.Drawing.Size(160, 149);
            this.btnCell8.TabIndex = 7;
            this.btnCell8.Tag = "?";
            this.btnCell8.UseVisualStyleBackColor = true;
            this.btnCell8.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell7
            // 
            this.btnCell7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell7.Image = ((System.Drawing.Image)(resources.GetObject("btnCell7.Image")));
            this.btnCell7.Location = new System.Drawing.Point(389, 519);
            this.btnCell7.Name = "btnCell7";
            this.btnCell7.Size = new System.Drawing.Size(160, 149);
            this.btnCell7.TabIndex = 6;
            this.btnCell7.Tag = "?";
            this.btnCell7.UseVisualStyleBackColor = true;
            this.btnCell7.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell5
            // 
            this.btnCell5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell5.Image = ((System.Drawing.Image)(resources.GetObject("btnCell5.Image")));
            this.btnCell5.Location = new System.Drawing.Point(575, 330);
            this.btnCell5.Name = "btnCell5";
            this.btnCell5.Size = new System.Drawing.Size(160, 149);
            this.btnCell5.TabIndex = 4;
            this.btnCell5.Tag = "?";
            this.btnCell5.UseVisualStyleBackColor = true;
            this.btnCell5.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell4
            // 
            this.btnCell4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell4.Image = ((System.Drawing.Image)(resources.GetObject("btnCell4.Image")));
            this.btnCell4.Location = new System.Drawing.Point(389, 330);
            this.btnCell4.Name = "btnCell4";
            this.btnCell4.Size = new System.Drawing.Size(160, 149);
            this.btnCell4.TabIndex = 3;
            this.btnCell4.Tag = "?";
            this.btnCell4.UseVisualStyleBackColor = true;
            this.btnCell4.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell9
            // 
            this.btnCell9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell9.Image = ((System.Drawing.Image)(resources.GetObject("btnCell9.Image")));
            this.btnCell9.Location = new System.Drawing.Point(760, 519);
            this.btnCell9.Name = "btnCell9";
            this.btnCell9.Size = new System.Drawing.Size(160, 149);
            this.btnCell9.TabIndex = 8;
            this.btnCell9.Tag = "?";
            this.btnCell9.UseVisualStyleBackColor = true;
            this.btnCell9.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell6
            // 
            this.btnCell6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell6.Image = ((System.Drawing.Image)(resources.GetObject("btnCell6.Image")));
            this.btnCell6.Location = new System.Drawing.Point(760, 330);
            this.btnCell6.Name = "btnCell6";
            this.btnCell6.Size = new System.Drawing.Size(160, 149);
            this.btnCell6.TabIndex = 5;
            this.btnCell6.Tag = "?";
            this.btnCell6.UseVisualStyleBackColor = true;
            this.btnCell6.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell3
            // 
            this.btnCell3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell3.Image = ((System.Drawing.Image)(resources.GetObject("btnCell3.Image")));
            this.btnCell3.Location = new System.Drawing.Point(760, 141);
            this.btnCell3.Name = "btnCell3";
            this.btnCell3.Size = new System.Drawing.Size(160, 149);
            this.btnCell3.TabIndex = 2;
            this.btnCell3.Tag = "?";
            this.btnCell3.UseVisualStyleBackColor = true;
            this.btnCell3.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell2
            // 
            this.btnCell2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell2.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnCell2.Location = new System.Drawing.Point(575, 141);
            this.btnCell2.Name = "btnCell2";
            this.btnCell2.Size = new System.Drawing.Size(160, 149);
            this.btnCell2.TabIndex = 1;
            this.btnCell2.Tag = "?";
            this.btnCell2.UseVisualStyleBackColor = true;
            this.btnCell2.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // btnCell1
            // 
            this.btnCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell1.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnCell1.Location = new System.Drawing.Point(389, 141);
            this.btnCell1.Name = "btnCell1";
            this.btnCell1.Size = new System.Drawing.Size(160, 149);
            this.btnCell1.TabIndex = 0;
            this.btnCell1.Tag = "?";
            this.btnCell1.UseVisualStyleBackColor = true;
            this.btnCell1.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1024, 701);
            this.Controls.Add(this.btnCell8);
            this.Controls.Add(this.btnCell7);
            this.Controls.Add(this.btnCell5);
            this.Controls.Add(this.btnCell4);
            this.Controls.Add(this.btnCell9);
            this.Controls.Add(this.btnCell6);
            this.Controls.Add(this.btnCell3);
            this.Controls.Add(this.btnCell2);
            this.Controls.Add(this.btnCell1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTicTacToe_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCell1;
        private System.Windows.Forms.Button btnCell2;
        private System.Windows.Forms.Button btnCell3;
        private System.Windows.Forms.Button btnCell4;
        private System.Windows.Forms.Button btnCell5;
        private System.Windows.Forms.Button btnCell6;
        private System.Windows.Forms.Button btnCell7;
        private System.Windows.Forms.Button btnCell8;
        private System.Windows.Forms.Button btnCell9;
    }
}

