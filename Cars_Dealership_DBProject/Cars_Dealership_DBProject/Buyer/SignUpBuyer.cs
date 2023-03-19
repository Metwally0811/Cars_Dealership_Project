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
    
    public partial class SignUpBuyer : Form
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
        public SignUpBuyer()
        {
            InitializeComponent();
            controllerObj = new Controller();


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog = new Buyer_Login();
            Blog.Show();

            this.Close();

        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            // if signup successful go to next form

            if (FName_textBox.Text == "" || LName_textBox.Text == "" || Username_textBox.Text == "" || Password_textBox.Text == "" || SSN_textBox.Text == "" || DriverLicense_textBox.Text == "")
            {
                MessageBox.Show("Please Fill Empty boxes ");

            }
            else

            {
                if (LName_textBox.Text.Any(char.IsDigit) || FName_textBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Names can't contain digits");
                    LName_textBox.Clear();
                    FName_textBox.Clear();

                    return;

                }
                else
                {
                    //check if the user is already taken
                    if (controllerObj.CheckifUsernameTakenBuyer(Username_textBox.Text) == 1)
                    {
                        MessageBox.Show("Username Already Taken!");
                        Username_textBox.Clear();

                        return;

                    }
                    else
                    {

                        short pricenum;
                        if (!Int16.TryParse(SSN_textBox.Text, out pricenum))
                        {
                            MessageBox.Show("SSN Accepts only integer values");
                            SSN_textBox.Clear();
                            return;


                        }
                        else
                        {
                            if (controllerObj.CheckifSSNTakenBuyer(Convert.ToInt32(SSN_textBox.Text)) == 1)
                            {
                                MessageBox.Show("SSN Already registered");
                                SSN_textBox.Clear();

                                return;

                            }
                            else
                            {

                                //Encrypted Version
                                string key = "b14ca5898a4e4133bbce2ea2315a1916";
                                string pas = EncryptionClass.EncryptString(key, Password_textBox.Text.ToString());
                                int result = controllerObj.InsertBuyerSignUp(Username_textBox.Text, pas, Convert.ToInt32(SSN_textBox.Text), FName_textBox.Text, LName_textBox.Text, DriverLicense_textBox.Text);

                                if (result != 0)
                                {

                                    MessageBox.Show("Buyer Signed Up Successfullly!");

                                    SignInBuyer Bfun1 = new SignInBuyer();
                                    Bfun1.Show();

                                    this.Close();

                                }
                                else
                                {
                                    MessageBox.Show("Failed to Sign Up");

                                }


                            }


                        }

                    }
                }


            }
           
        }

    }
}
