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

namespace Cars_Dealership_DBProject.Buyer
{
    public partial class SignInBuyer : Form
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

        public SignInBuyer()
        {
            InitializeComponent();
            controllerObj = new Controller();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog2 = new Buyer_Login();
            Blog2.Show();

            this.Close();
        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            // Check for username and password and if true go to next form
            DataTable dt = new DataTable();
            dt = controllerObj.SelectPasswordBuyer(Username_textBox.Text);


         


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

                    //madbouly
                    DataTable dt2 = new DataTable();
                    dt2 = controllerObj.GetSsnFromBuyer(Username_textBox.Text);
                    int ssn = Convert.ToInt32(dt2.Rows[0][0].ToString());
                   


                    BuyerFunctinalities Bfun = new BuyerFunctinalities(ssn);
                    Bfun.Show();

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }

            }

          

        }
    }
}
