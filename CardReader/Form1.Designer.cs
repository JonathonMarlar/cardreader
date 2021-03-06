﻿namespace CardReader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.cardInputBox = new System.Windows.Forms.TextBox();
            this.okayLabel = new System.Windows.Forms.Label();
            this.howToSwipePic = new System.Windows.Forms.PictureBox();
            this.cardInstructLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.howToSwipePic)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(69, 108);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(647, 185);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "The QEP Office needs to know how many\r\npeople attend Research Days events.\r\n\r\nPle" +
    "ase scan your Mane Card to help us\r\ncollect the needed data.";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.instructionsLabel.Click += new System.EventHandler(this.instructionsLabel_Click);
            // 
            // cardInputBox
            // 
            this.cardInputBox.Location = new System.Drawing.Point(50, 6);
            this.cardInputBox.Name = "cardInputBox";
            this.cardInputBox.Size = new System.Drawing.Size(0, 20);
            this.cardInputBox.TabIndex = 1;
            this.cardInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardInputBox_KeyDown);
            // 
            // okayLabel
            // 
            this.okayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okayLabel.AutoSize = true;
            this.okayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okayLabel.ForeColor = System.Drawing.Color.Green;
            this.okayLabel.Location = new System.Drawing.Point(53, 146);
            this.okayLabel.Name = "okayLabel";
            this.okayLabel.Size = new System.Drawing.Size(679, 108);
            this.okayLabel.TabIndex = 2;
            this.okayLabel.Text = "Card scanned!";
            this.okayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.okayLabel.Visible = false;
            this.okayLabel.Click += new System.EventHandler(this.okayLabel_Click);
            // 
            // howToSwipePic
            // 
            this.howToSwipePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToSwipePic.Image = global::CardReader.Properties.Resources.card_scan;
            this.howToSwipePic.Location = new System.Drawing.Point(554, 321);
            this.howToSwipePic.Name = "howToSwipePic";
            this.howToSwipePic.Size = new System.Drawing.Size(162, 212);
            this.howToSwipePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.howToSwipePic.TabIndex = 3;
            this.howToSwipePic.TabStop = false;
            this.howToSwipePic.Click += new System.EventHandler(this.howToSwipePic_Click);
            // 
            // cardInstructLabel
            // 
            this.cardInstructLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardInstructLabel.AutoSize = true;
            this.cardInstructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardInstructLabel.Location = new System.Drawing.Point(64, 372);
            this.cardInstructLabel.Name = "cardInstructLabel";
            this.cardInstructLabel.Size = new System.Drawing.Size(340, 111);
            this.cardInstructLabel.TabIndex = 4;
            this.cardInstructLabel.Text = "Make sure your card\'s \r\nstripe is facing AWAY\r\nfrom the green light";
            this.cardInstructLabel.Click += new System.EventHandler(this.cardInstructLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cardInstructLabel);
            this.Controls.Add(this.howToSwipePic);
            this.Controls.Add(this.okayLabel);
            this.Controls.Add(this.cardInputBox);
            this.Controls.Add(this.instructionsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Card Reader v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.howToSwipePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox cardInputBox;
        private System.Windows.Forms.Label okayLabel;
        private System.Windows.Forms.PictureBox howToSwipePic;
        private System.Windows.Forms.Label cardInstructLabel;
    }
}

