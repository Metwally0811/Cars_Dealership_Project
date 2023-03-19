using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Admin
{
    public partial class ChangePassword : Form
    {
        Controller controllerObj;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );
        public ChangePassword()
        {
            InitializeComponent();
            controllerObj = new Controller();


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ChangePass_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerObj.SelectPasswordAdmin(Username_textBox.Text);

            if (dt == null)
            {
                MessageBox.Show("Wrong UserName");
            }
            else
            {
                string oldpas = dt.Rows[0][0].ToString();


                string key = "b14ca5898a4e4133bbce2ea2315a1916";


                //Encrypted
                oldpas = EncryptionClass.DecryptString(key, oldpas);


                if (oldpas == OldPassword_textBox.Text)
                {
                    //Update Password

                    string newpas = EncryptionClass.EncryptString(key, NewPassword_textBox.Text);

                    controllerObj.ChangePasswordAdmin(Username_textBox.Text, newpas);

                    MessageBox.Show("Password Changed Successfully!");

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
       

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Admin_Login Alog = new Admin_Login();
            Alog.Show();

            this.Close();

        }


    }
}
