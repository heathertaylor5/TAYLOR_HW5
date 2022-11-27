using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaylorLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Heather Taylor - October 6th, 2022
             * This program is both a calculator and a display of some information about my cat Moose
             * The left side of the program will multiply 2 numbers and display the solution
             * The right side of the program will display a photo and a short description of Moose
             * */
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Show the picture and hide data label
            picMoose.Visible = true;
            lblData.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //hide the picture and data label on top of it
            picMoose.Visible = false;
            lblData.Visible = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //blank out the text boxes and the answer label
            txtNum.Text = "";
            txtMultiplier.Text = "";
            lblAnswer.Text = "";

            //set focus to Number text box 
            txtNum.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //hide picture
            picMoose.Visible = false;

            //display information in lblData
            lblData.Visible = true;

            //description of my topic using the label
            lblData.Text = "My topic is " + lblTopic.Text
                + "\n"
                + "\nMoose is a stray cat who I adopted unexpectedly in 2011."
                + "\n"
                + "\nShe charged at me when I called her and that's how she got her name."
                + "\n"
                + "\nThis is the change I'm making for Dev Tools homework #5.";

        }

        private void picMoose_Click(object sender, EventArgs e)
        {
            //display a message box when the image is clicked
            MessageBox.Show("Meow!", "Heather Taylor");
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare data types for text boxes
            int number = Convert.ToInt32(txtNum.Text);
            int multiplier = Convert.ToInt32(txtMultiplier.Text);
            int answer = number * multiplier;

            //display calculation answer in answer label
            lblAnswer.Text = answer.ToString();
        }
    }
}
