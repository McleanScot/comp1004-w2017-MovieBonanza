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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            //assign the cost and title info to the textboxes.
            InitializeComponent();
            TotalValueLabel.Text = Info.cost;
            MovieLabel.Text = Info.title + " will begin shortly!";
        }

        private void ChargedAmountLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }
    }
}
