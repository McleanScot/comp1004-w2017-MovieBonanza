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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = MovieListBox.Text.ToString();


            if (TitleTextBox.Text == "Cedar Rapids")
            {

            }
        }
    }
}
