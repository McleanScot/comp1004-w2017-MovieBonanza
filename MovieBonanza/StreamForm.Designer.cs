namespace MovieBonanza
{
    partial class StreamForm
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
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.ChargedAmountLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Location = new System.Drawing.Point(82, 45);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(199, 13);
            this.ThankYouLabel.TabIndex = 0;
            this.ThankYouLabel.Text = "Thank you for choosing Movie Bonanza!";
            // 
            // ChargedAmountLabel
            // 
            this.ChargedAmountLabel.AutoSize = true;
            this.ChargedAmountLabel.Location = new System.Drawing.Point(75, 77);
            this.ChargedAmountLabel.Name = "ChargedAmountLabel";
            this.ChargedAmountLabel.Size = new System.Drawing.Size(146, 13);
            this.ChargedAmountLabel.TabIndex = 1;
            this.ChargedAmountLabel.Text = "Your Credit Card will be billed:";
            this.ChargedAmountLabel.Click += new System.EventHandler(this.ChargedAmountLabel_Click);
            // 
            // MovieLabel
            // 
            this.MovieLabel.AutoSize = true;
            this.MovieLabel.Location = new System.Drawing.Point(101, 117);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(86, 13);
            this.MovieLabel.TabIndex = 2;
            this.MovieLabel.Text = "will begin shortly!";
            this.MovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(146, 178);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(236, 77);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(35, 13);
            this.TotalValueLabel.TabIndex = 4;
            this.TotalValueLabel.Text = "label1";
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 227);
            this.Controls.Add(this.TotalValueLabel);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.ChargedAmountLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Name = "StreamForm";
            this.Text = "woohoo movie time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label ChargedAmountLabel;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label TotalValueLabel;
    }
}