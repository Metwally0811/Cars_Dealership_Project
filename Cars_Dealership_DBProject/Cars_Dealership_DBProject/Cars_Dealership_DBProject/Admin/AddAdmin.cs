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
    public partial class AddAdmin : Form
    {
        Controller controllerObj;
        public AddAdmin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc1 = new AdminFunctionalities();
            AFunc1.Show();

            this.Close(); //To close when clicking back
        }

        private void AddNewAdmin_button_Click(object sender, EventArgs e)
        {
            if (FName_textBox.Text == " " || LName_textBox.Text == " " || Username_textBox.Text == " " || Password_textBox.Text == " ")
            {
                MessageBox.Show("Please Fill Empty boxes ");

            }
            else
            {
                if (LName_textBox.Text.Any(char.IsDigit) || FName_textBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Names can't contain digits");

                }
                else
                {
                    //check if the user is already taken
                    if (controllerObj.CheckifUsernameTakenAdmin(Username_textBox.Text) == 1)
                    {
                        MessageBox.Show("Username Already Taken!");
                    }
                    else
                    {
                        //Encrypted Version
                        string key = "b14ca5898a4e4133bbce2ea2315a1916";
                        string pas = EncryptionClass.EncryptString(key, Password_textBox.Text.ToString());
                        int result = controllerObj.InsertAdmin(Username_textBox.Text, pas , FName_textBox.Text, LName_textBox.Text);

                        if (result != 0)
                        {
                            
                            MessageBox.Show("Admin Added Successfullly!");

                            //this.Close();  
                        }
                    }
                   

                }
            }
          
        }

        private void FName_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
