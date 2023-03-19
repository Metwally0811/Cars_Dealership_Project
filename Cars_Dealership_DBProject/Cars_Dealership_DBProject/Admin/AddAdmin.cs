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
    public partial class AddAdmin : Form
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
        public AddAdmin()
        {
            InitializeComponent();
            controllerObj = new Controller();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            AdminFunctionalities AFunc1 = new AdminFunctionalities();
            AFunc1.Show();

            this.Close(); //To close when clicking back
        }

        private void AddNewAdmin_button_Click(object sender, EventArgs e)
        {
            if (FName_textBox.Text == "" || LName_textBox.Text == "" || Username_textBox.Text == "" || Password_textBox.Text == "")
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
                    if (controllerObj.CheckifUsernameTakenAdmin(Username_textBox.Text) == 1)
                    {
                        MessageBox.Show("Username Already Taken!");
                        Username_textBox.Clear();

                        return;

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

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
