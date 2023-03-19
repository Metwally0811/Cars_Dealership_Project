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

namespace Cars_Dealership_DBProject.Seller
{

    public partial class SignIn : Form
    {
        
        Controller controllerObj;
        public SignIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Seller_Login Slog1 = new Seller_Login();
            Slog1.Show();

            this.Close();

        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controllerObj.SelectPasswordSeller(Username_textBox.Text);


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
                    SellerFunctionalities Sf = new SellerFunctionalities(Username_textBox.Text);//od htet el textbox
                    Sf.Show();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }

            }

           
        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
