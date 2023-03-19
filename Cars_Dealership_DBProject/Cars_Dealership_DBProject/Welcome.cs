using Cars_Dealership_DBProject.Admin;
using Cars_Dealership_DBProject.Buyer;
using Cars_Dealership_DBProject.Seller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Cars_Dealership_DBProject
{
    public partial class Welcome : Form
    {
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

        public Welcome()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            Admin_Login ALog = new Admin_Login();
            ALog.Show();

            



        }

        private void Seller_button_Click(object sender, EventArgs e)
        {
            Seller_Login Slog = new Seller_Login();
            Slog.Show();

            

        }

        private void Buyer_button_Click(object sender, EventArgs e)
        {
            Buyer_Login Blog = new Buyer_Login();
            Blog.Show();

            

            

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
