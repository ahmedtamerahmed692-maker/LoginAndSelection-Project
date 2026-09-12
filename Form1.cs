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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (textPaswword.UseSystemPasswordChar)
            {
                btnShowPassword.Text = "Hide Password";
                textPaswword.UseSystemPasswordChar = false;
            }
            else
            {
                btnShowPassword.Text = "Show Password";
                textPaswword.UseSystemPasswordChar = true;
            }
        }

         /// ////////////////////////////////////////////////////////////////////////////////////////////////////
        bool IsOldImage = true;
        private void btnChangeImage_Click(object sender, EventArgs e)
        {  

            if (IsOldImage)
            {
                pictureBox1.Image = Progect_2_Form.Properties.Resources.image_ahmed_young;
                IsOldImage = false;
            }
            else
            {
                pictureBox1.Image = Progect_2_Form.Properties.Resources.Image_Ahmed;
                IsOldImage = true;
            }
            //   معلومة انه في كل مرة نفعل  //Resources.MyImage
            //سوف يتم انشاء كائن وانشاء صورة جديدة في الذاكرة
            // عشان الاداء والتوفير لو كان عنا الصورة سوف يتم استخدمها اكثر من مرة ف بالافضل نعرف مرجع ك حقل للكلاس ونستخدم المرجع مثل
            //private Bitmap _myImage = Properties.Resources.Image_Ahmed;
        }
        //private readonly Image _oldImage = Properties.Resources.image_ahmed_young;
        //private readonly Image _newImage = Properties.Resources.Image_Ahmed;

        //private void btnChangeImage_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Image = IsOldImage ? _newImage : _oldImage;
        //    IsOldImage = !IsOldImage;
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUserName.Text == "Ahmed" && textPaswword.Text == "1234")
            {
                MessageBox.Show(
                    "Login Successful",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Form2 frm = new Form2();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username or Password",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
    }
}

