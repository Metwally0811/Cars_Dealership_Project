using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars_Dealership_DBProject.Admin
{
    public partial class Admin_Login : Form
    {
        Controller controllerObj;

        public Admin_Login()
        {
            InitializeComponent();
            controllerObj = new Controller();

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

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
        


