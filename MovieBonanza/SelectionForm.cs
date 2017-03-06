/*
 * scot mclean
 * 200332937
 * march 5th 2017
 */

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
        //Bool to make things work if someone clicked a back button
        private bool _firstTime = true;
        public SelectionForm()
        {
            //Checks to see if info.title exists. If it does, it means that this form was already submitted
            // and a back button was pressed. So, fill in the information from info
            InitializeComponent();
            if (Info.title != null)
            {
                TitleTextBox.Text = Info.title;
                _firstTime = false;
                MovieListBox_SelectedIndexChanged(null, null);
            }
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking if the title exists.
            if (_firstTime)
            {
                TitleTextBox.Text = MovieListBox.Text.ToString();
            }
            else
            {
                _firstTime = true;
            }
            //enable next button if it does
            NextButton.Enabled = true;
            //if statements assigning the values to the title, category, cost and picture based off each movie
            if (TitleTextBox.Text == "Season of the Witch")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.witch;
            }
            else if(TitleTextBox.Text == "The Green Hornet")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.greenhornet;
            }
            else if (TitleTextBox.Text == "The Dilemma")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.dilemma;
            }
            else if (TitleTextBox.Text == "Death Race 2")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.Death_Race_2_poster;
            }
            else if (TitleTextBox.Text == "Company Men")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.companymen;
            }
            else if (TitleTextBox.Text == "No Strings Attached")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.No_Strings_Attached_Poster;
            }
            else if (TitleTextBox.Text == "The Way Back")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.way_back;
            }
            else if (TitleTextBox.Text == "The Mechanic")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.mechanic;
            }
            else if (TitleTextBox.Text == "The Rite")
            {
                CategoryTextBox.Text = "Horror";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.the_rite_poster;
            }
            else if (TitleTextBox.Text == "Sanctum")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.sanctum;
            }
            else if (TitleTextBox.Text == "The Other Woman")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.theotherwoman;
            }
            else if (TitleTextBox.Text == "The Roommate")
            {
                CategoryTextBox.Text = "Thriller";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.the_roommate_poster;
            }
            else if (TitleTextBox.Text == "Waiting for Forever")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.waiting_for_forever;
            }
            else if (TitleTextBox.Text == "Cedar Rapids")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.cedar;
            }
            else if (TitleTextBox.Text == "Gnomeo and Juliet")
            {
                CategoryTextBox.Text = "Family";
                CostTextBox.Text = "0.99";
                SmallPictureBox.Image = Properties.Resources.gj;
            }
            else if (TitleTextBox.Text == "Just Go With It")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.just_go_with_it;
            }
            else if (TitleTextBox.Text == "The Eagle")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "1.99";
                SmallPictureBox.Image = Properties.Resources.eagle;
            }
            else if (TitleTextBox.Text == "I Am Number Four")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = "2.99";
                SmallPictureBox.Image = Properties.Resources.i_am_number_four;
            }
            else if (TitleTextBox.Text == "Footloose")
            {
                CategoryTextBox.Text = "New Release";
                CostTextBox.Text = "4.99";
                SmallPictureBox.Image = Properties.Resources.footloose_poster1;
            }
            else if (TitleTextBox.Text == "Real Steel")
            {
                CategoryTextBox.Text = "New Release";
                CostTextBox.Text = "4.99";
                SmallPictureBox.Image = Properties.Resources.realsteel;
            }
            //assigning the public getters to the related text boxes.
            Info.category = CategoryTextBox.Text;
            Info.title = TitleTextBox.Text;
            Info.cost = CostTextBox.Text;
            Info.image = SmallPictureBox.Image;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }
    }
}
