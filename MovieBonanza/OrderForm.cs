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
        //instance variables cost, tax. assigning them to the getter and then applying the math to get the tax
        private static double _cost = Convert.ToDouble(Info.cost);
        private static double _tax =_cost  * 0.13;
        public OrderForm()
        {
            //make the text boxes the same as the getters.
            InitializeComponent();
            TitleTextBox.Text = Info.title;
            CostTextBox.Text = Info.cost;
            CategoryTextBox.Text = Info.category;
            BigPictureBox.Image = Info.image;
            //making dvd price 10.00
            DVDTextBox.Text = "10.00";
            //assigning the text to getter
            SubTotalTextBox.Text = Info.cost;
            TaxTextBox.Text = Convert.ToString(_tax);
            GrandTotalTextBox.Text = Convert.ToString(_tax + _cost);
        }

        private void OrderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //if the checkbox is checked make them visible
            DVDLabel.Visible = OrderCheckBox.Checked;
            DVDTextBox.Visible = OrderCheckBox.Checked;
            //if the checkbox is checked add 10 to cost
            if (OrderCheckBox.Checked)
            {
                GrandTotalTextBox.Text = (_cost + 10.00 + _tax).ToString();
            }
            //if not just to cost + tax 
            else if (!OrderCheckBox.Checked)
            {
                GrandTotalTextBox.Text = (_cost + _tax).ToString();
            }
        }

        private void StreamButton_Click(object sender, EventArgs e)
        {
            //assigning getter to textbox
            Info.cost = GrandTotalTextBox.Text;
            //hide form
            this.Hide();

            //show the streamform
            StreamForm streamForm = new StreamForm();
            streamForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //hide the form
            this.Hide();
            //show selection form
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Uses the same function as the button
            BackButton_Click(null, null);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Uses the same function as the button
            CancelButton_Click(null, null);
        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamButton_Click(null, null);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(null,"Made by: Scot McLean, 200332937",MessageBoxButtons.OK);
        }
    }
}
