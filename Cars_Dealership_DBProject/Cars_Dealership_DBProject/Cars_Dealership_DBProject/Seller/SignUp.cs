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
    public partial class SignUp : Form
    {
        Controller controllerObj;
        public SignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Seller_Login Slog2 = new Seller_Login();
            Slog2.Show();

            this.Close();
        }


        //Seller SignUp with all Validations
        private void SignUp_button_Click(object sender, EventArgs e)
        {
            // Check correct format of entered password and username and if true go to next form

            if (FName_textBox.Text == "" || LName_textBox.Text == "" || Username_textBox.Text == "" || Password_textBox.Text == "" || SSN_textBox.Text == "")
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
                    if (controllerObj.CheckifUsernameTakenSeller(Username_textBox.Text) == 1)
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
                            if (controllerObj.CheckifSSNTakenSeller(Convert.ToInt32(SSN_textBox.Text)) == 1)
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
                                int result = controllerObj.InsertSellerSignUp(Username_textBox.Text, pas, Convert.ToInt32(SSN_textBox.Text), FName_textBox.Text, LName_textBox.Text);

                                if (result != 0)
                                {

                                    MessageBox.Show("Seller Signed Up Successfullly!");
                                    SignIn Sf1 = new SignIn();
                                    Sf1.Show();

                                    this.Close();

                                    //this.Close();  
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
