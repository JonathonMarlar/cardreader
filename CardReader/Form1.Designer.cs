namespace CardReader
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
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(21, 119);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(743, 324);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Please scan\r\nyour Mane Card\r\nhere";
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.okayLabel.Location = new System.Drawing.Point(53, 227);
            this.okayLabel.Name = "okayLabel";
            this.okayLabel.Size = new System.Drawing.Size(679, 108);
            this.okayLabel.TabIndex = 2;
            this.okayLabel.Text = "Card scanned!";
            this.okayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.okayLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.okayLabel);
            this.Controls.Add(this.cardInputBox);
            this.Controls.Add(this.instructionsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Card Reader v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox cardInputBox;
        private System.Windows.Forms.Label okayLabel;
    }
}

