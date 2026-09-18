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
            this.lblPlyer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCell8 = new System.Windows.Forms.Button();
            this.btnCell3 = new System.Windows.Forms.Button();
            this.btnCell2 = new System.Windows.Forms.Button();
            this.btnCell9 = new System.Windows.Forms.Button();
            this.btnCell7 = new System.Windows.Forms.Button();
            this.btnCell5 = new System.Windows.Forms.Button();
            this.btnCell6 = new System.Windows.Forms.Button();
            this.btnCell1 = new System.Windows.Forms.Button();
            this.btnCell4 = new System.Windows.Forms.Button();
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
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
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
            // lblPlyer
            // 
            this.lblPlyer.AutoSize = true;
            this.lblPlyer.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyer.ForeColor = System.Drawing.Color.Lime;
            this.lblPlyer.Location = new System.Drawing.Point(81, 315);
            this.lblPlyer.Name = "lblPlyer";
            this.lblPlyer.Size = new System.Drawing.Size(212, 73);
            this.lblPlyer.TabIndex = 3;
            this.lblPlyer.Text = "Player 1";
            this.lblPlyer.Click += new System.EventHandler(this.label3_Click);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer.Location = new System.Drawing.Point(140, 315);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(212, 73);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "Player 1";
            this.lblPlayer.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vladimir Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(140, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 73);
            this.label5.TabIndex = 5;
            this.label5.Text = "In Progress";
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
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnCell8
            // 
            this.btnCell8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell8.Image = ((System.Drawing.Image)(resources.GetObject("btnCell8.Image")));
            this.btnCell8.Location = new System.Drawing.Point(575, 519);
            this.btnCell8.Name = "btnCell8";
            this.btnCell8.Size = new System.Drawing.Size(160, 149);
            this.btnCell8.TabIndex = 15;
            this.btnCell8.UseVisualStyleBackColor = true;
            // 
            // btnCell3
            // 
            this.btnCell3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell3.Image = ((System.Drawing.Image)(resources.GetObject("btnCell3.Image")));
            this.btnCell3.Location = new System.Drawing.Point(760, 141);
            this.btnCell3.Name = "btnCell3";
            this.btnCell3.Size = new System.Drawing.Size(160, 149);
            this.btnCell3.TabIndex = 9;
            this.btnCell3.UseVisualStyleBackColor = true;
            // 
            // btnCell2
            // 
            this.btnCell2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell2.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnCell2.Location = new System.Drawing.Point(575, 141);
            this.btnCell2.Name = "btnCell2";
            this.btnCell2.Size = new System.Drawing.Size(160, 149);
            this.btnCell2.TabIndex = 8;
            this.btnCell2.UseVisualStyleBackColor = true;
            // 
            // btnCell9
            // 
            this.btnCell9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell9.Image = ((System.Drawing.Image)(resources.GetObject("btnCell9.Image")));
            this.btnCell9.Location = new System.Drawing.Point(760, 519);
            this.btnCell9.Name = "btnCell9";
            this.btnCell9.Size = new System.Drawing.Size(160, 149);
            this.btnCell9.TabIndex = 11;
            this.btnCell9.UseVisualStyleBackColor = true;
            // 
            // btnCell7
            // 
            this.btnCell7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell7.Image = ((System.Drawing.Image)(resources.GetObject("btnCell7.Image")));
            this.btnCell7.Location = new System.Drawing.Point(389, 519);
            this.btnCell7.Name = "btnCell7";
            this.btnCell7.Size = new System.Drawing.Size(160, 149);
            this.btnCell7.TabIndex = 14;
            this.btnCell7.UseVisualStyleBackColor = true;
            // 
            // btnCell5
            // 
            this.btnCell5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell5.Image = ((System.Drawing.Image)(resources.GetObject("btnCell5.Image")));
            this.btnCell5.Location = new System.Drawing.Point(575, 330);
            this.btnCell5.Name = "btnCell5";
            this.btnCell5.Size = new System.Drawing.Size(160, 149);
            this.btnCell5.TabIndex = 13;
            this.btnCell5.UseVisualStyleBackColor = true;
            this.btnCell5.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnCell6
            // 
            this.btnCell6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell6.Image = ((System.Drawing.Image)(resources.GetObject("btnCell6.Image")));
            this.btnCell6.Location = new System.Drawing.Point(760, 330);
            this.btnCell6.Name = "btnCell6";
            this.btnCell6.Size = new System.Drawing.Size(160, 149);
            this.btnCell6.TabIndex = 10;
            this.btnCell6.UseVisualStyleBackColor = true;
            // 
            // btnCell1
            // 
            this.btnCell1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell1.Image = global::Tic_Tac_Toe.Properties.Resources.question_mark_96;
            this.btnCell1.Location = new System.Drawing.Point(389, 141);
            this.btnCell1.Name = "btnCell1";
            this.btnCell1.Size = new System.Drawing.Size(160, 149);
            this.btnCell1.TabIndex = 7;
            this.btnCell1.UseVisualStyleBackColor = true;
            // 
            // btnCell4
            // 
            this.btnCell4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCell4.Image = ((System.Drawing.Image)(resources.GetObject("btnCell4.Image")));
            this.btnCell4.Location = new System.Drawing.Point(389, 330);
            this.btnCell4.Name = "btnCell4";
            this.btnCell4.Size = new System.Drawing.Size(160, 149);
            this.btnCell4.TabIndex = 12;
            this.btnCell4.UseVisualStyleBackColor = true;
            this.btnCell4.Click += new System.EventHandler(this.button6_Click);
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
            this.Controls.Add(this.lblPlyer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTicTacToe";
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
        private System.Windows.Forms.Label lblPlyer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCell8;
        private System.Windows.Forms.Button btnCell3;
        private System.Windows.Forms.Button btnCell2;
        private System.Windows.Forms.Button btnCell9;
        private System.Windows.Forms.Button btnCell7;
        private System.Windows.Forms.Button btnCell5;
        private System.Windows.Forms.Button btnCell6;
        private System.Windows.Forms.Button btnCell1;
        private System.Windows.Forms.Button btnCell4;
    }
}

