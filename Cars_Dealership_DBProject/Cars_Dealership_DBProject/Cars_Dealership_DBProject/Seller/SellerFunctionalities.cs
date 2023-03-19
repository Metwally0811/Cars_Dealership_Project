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
    public partial class SellerFunctionalities : Form
    {
        string sellerusername; // od

        public SellerFunctionalities(string username) //od 3shan a3rf el username bta3 ely dakhly
        {
            InitializeComponent();
            sellerusername = username;

            
        }



        // input to the form number to differniate between each functionality of each button
        // some buttons will be disabled in the form due to you want to add/edit/remove
        private void OfferNewCar_button_Click(object sender, EventArgs e)
        {
           

            OfferNewCar newc = new OfferNewCar(0, sellerusername); //overload de be 0
            newc.Show();

            this.Close();
        }

        private void EditCarInfo_button_Click(object sender, EventArgs e)
        {

            OfferNewCar newc1 = new OfferNewCar(1, sellerusername); //overload de be 1
            newc1.Show();

            this.Close();

        }

        private void RemoveCar_button_Click(object sender, EventArgs e)
        {

            OfferNewCar newc1 = new OfferNewCar(2, sellerusername); //overload de be 2
            newc1.Show();

            this.Close();


        }

        private void ApproveCar_button_Click(object sender, EventArgs e)
        {
            ViewCarsSoldBySeller Vcs = new ViewCarsSoldBySeller(sellerusername);
            Vcs.Show();

            this.Close();
        }

        private void Back_Button_Sellerfn_Click(object sender, EventArgs e)
        {
            SignIn S = new SignIn();  //OD
            S.Show();
            this.Close();
        }
    }
}
