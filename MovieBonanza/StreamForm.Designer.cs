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
            this.label3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
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
            this.ChargedAmountLabel.Location = new System.Drawing.Point(41, 77);
            this.ChargedAmountLabel.Name = "ChargedAmountLabel";
            this.ChargedAmountLabel.Size = new System.Drawing.Size(275, 13);
            this.ChargedAmountLabel.TabIndex = 1;
            this.ChargedAmountLabel.Text = "Your Credit Card will be billed [Replace with total amount]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "[Replace with movie Title] will begin shortly!";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(146, 178);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 227);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
    }
}