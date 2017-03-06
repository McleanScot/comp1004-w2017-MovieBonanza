using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza
{
    public partial class OrderForm : Form
    {
        private static double cost = Convert.ToDouble(Info.cost);
        private static double tax =cost  * 0.13;
        public OrderForm()
        {
            InitializeComponent();
            TitleTextBox.Text = Info.title;
            CostTextBox.Text = Info.cost;
            CategoryTextBox.Text = Info.category;
            BigPictureBox.Image = Info.image;
            DVDTextBox.Text = "10.00";
            SubTotalTextBox.Text = Info.cost;
            TaxTextBox.Text = Convert.ToString(tax);
            GrandTotalTextBox.Text = Convert.ToString(tax + cost);
        }

        private void OrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DVDLabel.Visible = OrderCheckBox.Checked;
            DVDTextBox.Visible = OrderCheckBox.Checked;
            if (OrderCheckBox.Checked)
            {
                GrandTotalTextBox.Text = (cost + 10.00 + tax).ToString();
            }
            else if (!OrderCheckBox.Checked)
            {
                GrandTotalTextBox.Text = (cost + tax).ToString();
            }
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            Info.cost = GrandTotalTextBox.Text;

            this.Hide();

            StreamForm streamForm = new StreamForm();
            streamForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
