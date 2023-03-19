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
    public partial class BuyerFunctinalities : Form
    {
        int buyerssn;
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
        public BuyerFunctinalities(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();

            buyerssn = ssn;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void ViewPastTrans_button_Click(object sender, EventArgs e)
        {
            ViewPastTransactions Vt = new ViewPastTransactions(buyerssn);
            Vt.Show();

            this.Close();
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            // hayfta7 el form de lel buyer fa lazem a disable el re

            BuyOrRent BR = new BuyOrRent(0, buyerssn); // overload 0
            BR.Show();

            this.Close();
        }

        private void Rent_button_Click(object sender, EventArgs e)
        {

            // hayfta7 el form de lel seller fa lazem a disable el buy
            

            BuyOrRent BR = new BuyOrRent(1, buyerssn); // overload 1
            BR.Show();

            this.Close();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            SignInBuyer s = new SignInBuyer();
            s.Show();

            this.Close();
        }
    }
}
