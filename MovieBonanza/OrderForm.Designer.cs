namespace MovieBonanza
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.BigPictureBox = new System.Windows.Forms.PictureBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.DVDTextBox = new System.Windows.Forms.TextBox();
            this.DVDLabel = new System.Windows.Forms.Label();
            this.OrderCheckBox = new System.Windows.Forms.CheckBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLable = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.MovieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // MovieSelectedGroupBox
            // 
            this.MovieSelectedGroupBox.Controls.Add(this.BigPictureBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.CategoryLabel);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleTextBox);
            this.MovieSelectedGroupBox.Controls.Add(this.TitleLabel);
            this.MovieSelectedGroupBox.Location = new System.Drawing.Point(13, 28);
            this.MovieSelectedGroupBox.Name = "MovieSelectedGroupBox";
            this.MovieSelectedGroupBox.Size = new System.Drawing.Size(288, 348);
            this.MovieSelectedGroupBox.TabIndex = 1;
            this.MovieSelectedGroupBox.TabStop = false;
            this.MovieSelectedGroupBox.Text = "Movie Selected:";
            // 
            // BigPictureBox
            // 
            this.BigPictureBox.Location = new System.Drawing.Point(10, 113);
            this.BigPictureBox.Name = "BigPictureBox";
            this.BigPictureBox.Size = new System.Drawing.Size(272, 229);
            this.BigPictureBox.TabIndex = 4;
            this.BigPictureBox.TabStop = false;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(10, 77);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(272, 20);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(7, 60);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 2;
            this.CategoryLabel.Text = "Category:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(10, 37);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(272, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(7, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title:";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.DVDTextBox);
            this.OrderGroupBox.Controls.Add(this.DVDLabel);
            this.OrderGroupBox.Controls.Add(this.OrderCheckBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.TaxTextBox);
            this.OrderGroupBox.Controls.Add(this.TaxLabel);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.OrderGroupBox.Controls.Add(this.CostTextBox);
            this.OrderGroupBox.Controls.Add(this.CostLable);
            this.OrderGroupBox.Location = new System.Drawing.Point(308, 28);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(288, 288);
            this.OrderGroupBox.TabIndex = 2;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order:";
            // 
            // DVDTextBox
            // 
            this.DVDTextBox.Location = new System.Drawing.Point(127, 69);
            this.DVDTextBox.Name = "DVDTextBox";
            this.DVDTextBox.Size = new System.Drawing.Size(60, 20);
            this.DVDTextBox.TabIndex = 13;
            this.DVDTextBox.Visible = false;
            // 
            // DVDLabel
            // 
            this.DVDLabel.AutoSize = true;
            this.DVDLabel.Location = new System.Drawing.Point(88, 72);
            this.DVDLabel.Name = "DVDLabel";
            this.DVDLabel.Size = new System.Drawing.Size(33, 13);
            this.DVDLabel.TabIndex = 14;
            this.DVDLabel.Text = "DVD:";
            this.DVDLabel.Visible = false;
            // 
            // OrderCheckBox
            // 
            this.OrderCheckBox.AutoSize = true;
            this.OrderCheckBox.Location = new System.Drawing.Point(6, 250);
            this.OrderCheckBox.Name = "OrderCheckBox";
            this.OrderCheckBox.Size = new System.Drawing.Size(259, 17);
            this.OrderCheckBox.TabIndex = 12;
            this.OrderCheckBox.Text = "Order the DVD(Additional $10.00 fee to the order)";
            this.OrderCheckBox.UseVisualStyleBackColor = true;
            this.OrderCheckBox.CheckedChanged += new System.EventHandler(this.OrderCheckBox_CheckedChanged);
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(127, 195);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.Size = new System.Drawing.Size(60, 20);
            this.GrandTotalTextBox.TabIndex = 10;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(55, 198);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(66, 13);
            this.GrandTotalLabel.TabIndex = 11;
            this.GrandTotalLabel.Text = "Grand Total:";
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(127, 153);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.Size = new System.Drawing.Size(60, 20);
            this.TaxTextBox.TabIndex = 8;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(38, 156);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(83, 13);
            this.TaxLabel.TabIndex = 9;
            this.TaxLabel.Text = "Sales Tax(13%):";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(127, 110);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(60, 20);
            this.SubTotalTextBox.TabIndex = 6;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(65, 113);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 7;
            this.SubTotalLabel.Text = "Sub Total:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(127, 26);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(60, 20);
            this.CostTextBox.TabIndex = 5;
            // 
            // CostLable
            // 
            this.CostLable.AutoSize = true;
            this.CostLable.Location = new System.Drawing.Point(90, 29);
            this.CostLable.Name = "CostLable";
            this.CostLable.Size = new System.Drawing.Size(31, 13);
            this.CostLable.TabIndex = 5;
            this.CostLable.Text = "Cost:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(314, 352);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(420, 352);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(521, 352);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(75, 23);
            this.StreamButton.TabIndex = 5;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            this.StreamButton.Click += new System.EventHandler(this.StreamButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 388);
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.MovieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MovieSelectedGroupBox.ResumeLayout(false);
            this.MovieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigPictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox MovieSelectedGroupBox;
        private System.Windows.Forms.PictureBox BigPictureBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLable;
        private System.Windows.Forms.TextBox DVDTextBox;
        private System.Windows.Forms.Label DVDLabel;
        private System.Windows.Forms.CheckBox OrderCheckBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button StreamButton;
    }
}