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

namespace Cars_Dealership_DBProject.Seller
{
    public partial class OfferNewCar : Form
    {
        Controller controllerObj;
        string seller_username;

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

        public OfferNewCar(int a, string username) //(int a) 
                                                   // 0->offer ; 1->edit ; 2->remove
        {
            InitializeComponent();
            controllerObj = new Controller();
            seller_username = username;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //MJ -> bakhod el username we barg3 mno el ssn   
            DataTable dt = new DataTable();
            dt = controllerObj.Sellerssn_From_Username(seller_username);
            int ssn = Convert.ToInt32(dt.Rows[0][0].ToString()); // ssn feha int el ssn bta3 el seller ely 3amel login



            if (a == 0)
            {
                groupBox2.Enabled = false; //Disables group box
                groupBox3.Enabled = false;
            }
            else if (a == 1)
            {
                groupBox3.Enabled = false;
                OfferCar_button.Enabled = false;




                //MJ baload el combo box
                DataTable dt1 = new DataTable();
                dt1 = controllerObj.ALL_From_Sellerssn(ssn);

                VINEdit_button.DataSource = dt1;
                VINEdit_button.DisplayMember = "Vin";


                ModelEdit_button.DataSource = dt1;
                ModelEdit_button.DisplayMember = "Model";
               
            }
            else if (a == 2)
            {
                groupBox2.Enabled = false;
                OfferCar_button.Enabled = false;


                //MJ baload el combo box
                DataTable dt2 = new DataTable();
                dt2 = controllerObj.ALL_From_Sellerssn(ssn);
                VINRemove_comboBox.DataSource = dt2;
                VINRemove_comboBox.DisplayMember = "Vin";
               


                ModelRemove_comboBox.DataSource = dt2;
                ModelRemove_comboBox.DisplayMember = "Model";
                

            }

        }



        private void Back_button_Click(object sender, EventArgs e)
        {
            SellerFunctionalities Sf1 = new SellerFunctionalities(seller_username);
            Sf1.Show();

            this.Close();
        }

        private void OfferCar_button_Click(object sender, EventArgs e)
        {
            //OD  validations and call insert query from controller
            if (VIN_textBox.Text == " " || Price_textBox.Text == " " || Company_textBox.Text == " " || Model_textBox.Text == " " || Year_textBox.Text == "" || Colour_textBox.Text == "" || DTravelled_textBox.Text == "" || Type_comboBox.Text == "")
            {
                MessageBox.Show("Please Fill Empty boxes ");

            }
            else
            {
                //todo: valdiation na2sa
                if (Company_textBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Company name can't contain digits");
                    Company_textBox.Clear();

                    return;



                }
                else
                {
                    if (VIN_textBox.Text.Length != 8)
                    {
                        MessageBox.Show("VIN must have 8 digits");
                        VIN_textBox.Clear();

                        return;


                    }
                    else
                    {
                        if(DTravelled_textBox.Text.Length > 6)
                        {

                            MessageBox.Show("Inappropriate Distance Travelled");
                            DTravelled_textBox.Clear();

                            return;

                        }
                        else
                        {

                            long yearcheck;
                            if (!Int64.TryParse(Year_textBox.Text, out yearcheck) || yearcheck < 0 || Year_textBox.Text.Length != 4)
                            {
                                MessageBox.Show("Inappropriate year");
                                Year_textBox.Clear();

                                return;
                            }
                            else
                            {

                               
                                    long pricecheck;
                                    if (!Int64.TryParse(Price_textBox.Text, out pricecheck) || pricecheck < 0 || Price_textBox.Text.Length > 7)
                                    {
                                        MessageBox.Show("Inappropriate value for Price");
                                        return;

                                    }
                                    else
                                    {
                                        if (Colour_textBox.Text.Any(char.IsDigit))
                                        {
                                            MessageBox.Show("Colour textbox can't contain digits");
                                            Colour_textBox.Clear();

                                            return;


                                        }
                                        else
                                        {


                                            //MJ -> bakhod el username we barg3 mno el ssn   
                                            DataTable dt = new DataTable();
                                            dt = controllerObj.Sellerssn_From_Username(seller_username);
                                            int ssn = Convert.ToInt32(dt.Rows[0][0].ToString()); // ssn feha int el ssn bta3 el seller ely 3amel login

                                            int query_done = controllerObj.Insert_Offered_Car(Convert.ToInt32(Price_textBox.Text), VIN_textBox.Text, Company_textBox.Text, Model_textBox.Text, Convert.ToInt32(Year_textBox.Text), Colour_textBox.Text, Convert.ToInt32(DTravelled_textBox.Text), Type_comboBox.Text, ssn); //check combo box //seller ssn
                                                                                                                                                                                                                                                                                                                            //bashof el query 8ayrt fe haga wala la
                                            if (query_done == 0)
                                            {
                                                MessageBox.Show("no car was added");
                                            }
                                            else
                                            {
                                                MessageBox.Show("car was added successfully");
                                            }





                                        }


                                    }


                                
                               

                            }

                        }
                        


                    }


                }



            }







           
            
        }

        private void Show_button_Click(object sender, EventArgs e)
        {
            DataTable dt4 = new DataTable();
            dt4 = controllerObj.ALL_From_Vin(VINEdit_button.Text);

            if(dt4 != null )
            {
                Price_textBox.Text = dt4.Rows[0][0].ToString();
                VIN_textBox.Text = dt4.Rows[0][2].ToString();
                Company_textBox.Text = dt4.Rows[0][3].ToString();
                Model_textBox.Text = dt4.Rows[0][4].ToString();
                Year_textBox.Text = dt4.Rows[0][5].ToString();
                Colour_textBox.Text = dt4.Rows[0][6].ToString();
                DTravelled_textBox.Text = dt4.Rows[0][7].ToString();
                Type_comboBox.Text = dt4.Rows[0][8].ToString();

                VIN_textBox.ReadOnly = true;

            }
           
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            //MJ
            if (VIN_textBox.Text == "" || Price_textBox.Text == "" || Company_textBox.Text == "" || Model_textBox.Text == "" || Year_textBox.Text == "" || Colour_textBox.Text == "" || DTravelled_textBox.Text == "" || Type_comboBox.Text == "")
            {
                MessageBox.Show("Please Fill Empty boxes ");

            }
            else
            {
                //todo: valdiation na2sa

                if (Company_textBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Company name can't contain digits");
                    Company_textBox.Clear();

                    return;

                }
                else
                {
                    /*if (Model_textBox.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("Model name can't contain digits");
                        Model_textBox.Clear();

                        return;

                    }*/
                    //else
                    {
                        long yearcheck;
                        if (!Int64.TryParse(Year_textBox.Text, out yearcheck) || yearcheck < 0 || Year_textBox.Text.Length != 4)
                        {
                            MessageBox.Show("Inappropriate year");
                            return;
                        }
                        else
                        {
                            long pricecheck;
                            if (!Int64.TryParse(Price_textBox.Text, out pricecheck) || pricecheck < 0)
                            {
                                MessageBox.Show("Inappropriate negative value for Price");
                                return;
                            }
                            else
                            {
                                if(Colour_textBox.Text.Any(char.IsDigit))
                                {
                                    MessageBox.Show("Colour textbox can't contain digits");
                                    Colour_textBox.Clear();

                                    return;


                                }
                                else
                                {
                                    int query_done3 = controllerObj.Update_car_with_vin(Convert.ToInt32(Price_textBox.Text), VIN_textBox.Text, Company_textBox.Text, Model_textBox.Text, Convert.ToInt32(Year_textBox.Text), Colour_textBox.Text, Convert.ToInt32(DTravelled_textBox.Text), Type_comboBox.Text);
                                    //bashof el query 8ayrt fe haga wala la
                                    if (query_done3 == 0)
                                    {
                                        MessageBox.Show("Data wasn't updated");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Data was updated successfully");
                                    }

                                }
                                
                               


                            }

                        }


                    }


                }



            }
        }


        //Validation for Distance travelled text box to accept only integrs
        private void DTravelled_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        //Validation only integres in  price
        private void Price_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void ShowDel_button_Click(object sender, EventArgs e)
        {
            //MJ values -> Vin ely mkhtaro (query)
            //barg3 el vin ely 3yz a3mlo show fe query btrg3ly kol haga leha 3laka bel vin lw null fa da m3naha eno etmas7 fa msh ha3mel show
            DataTable dt4 = new DataTable();
            dt4 = controllerObj.ALL_From_Vin(VINRemove_comboBox.Text);

            if (dt4 == null)   //condition 3shan lw ms7 haga mynf3sh y3mlha show
            {
                MessageBox.Show("The car is already deleted");
            }
            else
            {
                DataTable dt3 = new DataTable();
                dt3 = controllerObj.ALL_From_Vin(VINRemove_comboBox.Text);
                Price_textBox.Text = dt3.Rows[0][0].ToString();
                VIN_textBox.Text = dt3.Rows[0][2].ToString();
                Company_textBox.Text = dt3.Rows[0][3].ToString();
                Model_textBox.Text = dt3.Rows[0][4].ToString();
                Year_textBox.Text = dt3.Rows[0][5].ToString();
                Colour_textBox.Text = dt3.Rows[0][6].ToString();
                DTravelled_textBox.Text = dt3.Rows[0][7].ToString();
                Type_comboBox.Text = dt3.Rows[0][8].ToString();

                Price_textBox.ReadOnly = true;
                VIN_textBox.ReadOnly = true;
                Company_textBox.ReadOnly = true;
                Model_textBox.ReadOnly = true;
                Year_textBox.ReadOnly = true;
                Colour_textBox.ReadOnly = true;
                DTravelled_textBox.ReadOnly = true;
                Type_comboBox.Enabled = false;
            }







        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            //MJ
            int query_done2 = controllerObj.Delete_car_with_vin(VINRemove_comboBox.Text);
            if (query_done2 == 0)
            {
                MessageBox.Show("no car was deleted");

            }
            else
            {
                MessageBox.Show("car was deleted successfully");
            }
        }

        private void VIN_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Model_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VINRemove_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }




}
