﻿
namespace code_asses2022JM
{
    partial class FrmAlien
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
            this.label1 = new System.Windows.Forms.Label();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.MnuStart = new System.Windows.Forms.Button();
            this.MnuStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alien game ";
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Gray;
            this.PnlGame.Location = new System.Drawing.Point(7, 137);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(562, 356);
            this.PnlGame.TabIndex = 1;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // MnuStart
            // 
            this.MnuStart.Location = new System.Drawing.Point(597, 137);
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(75, 23);
            this.MnuStart.TabIndex = 2;
            this.MnuStart.Text = "Start ";
            this.MnuStart.UseVisualStyleBackColor = true;
            // 
            // MnuStop
            // 
            this.MnuStop.Location = new System.Drawing.Point(597, 178);
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(75, 23);
            this.MnuStop.TabIndex = 3;
            this.MnuStop.Text = "Stop";
            this.MnuStop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(53, 104);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Score";
            // 
            // LblScore
            // 
            this.LblScore.Location = new System.Drawing.Point(239, 104);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(39, 20);
            this.LblScore.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lives";
            // 
            // LblLives
            // 
            this.LblLives.Location = new System.Drawing.Point(351, 104);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(39, 20);
            this.LblLives.TabIndex = 9;
            // 
            // FrmAlien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 523);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MnuStop);
            this.Controls.Add(this.MnuStart);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.label1);
            this.Name = "FrmAlien";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Button MnuStart;
        private System.Windows.Forms.Button MnuStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LblLives;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

