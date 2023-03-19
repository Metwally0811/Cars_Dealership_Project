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
    public partial class Admin_Login : Form
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

        public Admin_Login()
        {
            InitializeComponent();
            controllerObj = new Controller();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Login_button_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = controllerObj.SelectPasswordAdmin(Username_textBox.Text);


            if (dt == null)
            {
                MessageBox.Show("Please Enter Valid Login Details");
            }
            else
            {
                string pas = dt.Rows[0][0].ToString();

                string key = "b14ca5898a4e4133bbce2ea2315a1916";

                //Encrypted
                pas = EncryptionClass.DecryptString(key, pas);


                if (pas == Password_textBox.Text)
                {

                    AdminFunctionalities AFunc = new AdminFunctionalities();
                    AFunc.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }

            }

        }

        private void ChangePass_button_Click(object sender, EventArgs e)
        {
            ChangePassword ChP = new ChangePassword();
            ChP.Show();

            this.Close();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            //Welcome w = new Welcome();
            //w.Show();


            this.Close();
        }
    }



}
        


