using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progect_2_Form.Properties;

namespace Progect_2_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Image = Resources.Pen;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();

        }

       
      
        //private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        //{
        //    RadioButton rb = (RadioButton)sender;

        //    if (!rb.Checked)
        //        return;

        //    lblTitle.Text = rb.Tag.ToString();

        //    switch (rb.Name)
        //    {
        //        case "rbBoy":
        //            pictureBox1.Image = Resources.Boy;
        //            break;

        //        case "rbGirl":
        //            pictureBox1.Image = Resources.Girl;
        //            break;

        //        case "rbBook":
        //            pictureBox1.Image = Resources.Book;
        //            break;

        //        case "rbPen":
        //            pictureBox1.Image = Resources.Pen;
        //            break;
        // }
        // }
        ////////////////////////////


        //****


        /*void Convert_Image()
         {
             // Create a list that contains all RadioButtons
             List<RadioButton> listRadioButtons = new List<RadioButton>
     {
         rbPen,
         rbGirl,
         rbBoy,
         rbBook
     };

             // Loop through all RadioButtons
             foreach (RadioButton radioButton in listRadioButtons)
             {
                 // Check which RadioButton is selected
                 if (radioButton.Checked)
                 {
                     // Display the RadioButton text in the title
                     lblTitle.Text = radioButton.Text;

                     // Load the image that has the same name as the RadioButton text
                     pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(radioButton.Text);

                     // Exit because we found the selected RadioButton
                     return;
                 }
             }
         }*/

    }
}
