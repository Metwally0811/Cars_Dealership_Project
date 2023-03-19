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
    public partial class Payment : Form
    {
        Controller controllerObj;

        string delete_VIN;// Metwally

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



        int buyrent_flag = 0;  //0 for buy 1 for rent
        //string Start_Date;
        int year;
        int month;
        int day;
        int No_of_days;
        int BuyerOrRenterSsn;

        public Payment(int a, string Vin_temp, int year1 ,int month1 , int day1, int Days,int Ssn) 
        {
            InitializeComponent();
            controllerObj = new Controller();
            delete_VIN = Vin_temp;// Metwally


            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //Start_Date = startDate;
            year = year1;
            month = month1;
            day = day1;
            No_of_days = Days;

            buyrent_flag = a;
            BuyerOrRenterSsn = Ssn;

            SSN_textBox.Text = Convert.ToString(BuyerOrRenterSsn);



        }

        private void Back_button_Click(object sender, EventArgs e)
        {
          
            this.Close();

        }

        private void Done_button_Click(object sender, EventArgs e)
        {

            if (buyrent_flag == 0) //buy msh rent
            {
                if (radioButton1.Checked == true)
                {
                    //Bought flag be 1
                    //add el flos lel buyer col price

                    DataTable dtable = new DataTable();

                    //if(dtable !=)

                    dtable = controllerObj.Price_of_car_from_vin(delete_VIN);
                    if (dtable == null)
                    {
                        MessageBox.Show("Car is not bought");
                    }
                    else
                    {
                        int price = Convert.ToInt32(dtable.Rows[0][0].ToString());
                        int querydone2 = controllerObj.Car_is_Bought(delete_VIN, BuyerOrRenterSsn, price);


                        if (querydone2 == 1)
                        {
                            MessageBox.Show("Car  bought successfully");
                        }
                        else
                        {
                            MessageBox.Show("Car is not bought");
                        }
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (CardNumber_textBox.Text == "" || Cvv_textBox.Text == "")
                    {

                        MessageBox.Show("Please fill all boxes");

                    }
                    else
                    {
                        if(CardNumber_textBox.Text.Length != 16)
                        {
                            MessageBox.Show("Card number must be 16 digits");
                            CardNumber_textBox.Clear();



                            return;

                        }
                        else
                        {
                            if (Cvv_textBox.Text.Length != 3)
                            {
                                MessageBox.Show("Cvv must be 3 digits");
                                Cvv_textBox.Clear();


                                return;
                            }
                            else
                            {

                                //TODO: Check if this card number registered before

                               

                                //DataTable dt = new DataTable();

                                int query_done9 = controllerObj.InsertCardDetails(Convert.ToInt64(CardNumber_textBox.Text), (int)year_num.Value, (int)Month_num.Value, Convert.ToInt32(Cvv_textBox.Text), Convert.ToInt32(SSN_textBox.Text));

                                if (query_done9 == 0)
                                {

                                    MessageBox.Show("Card Details invalid ");

                                }
                                else
                                {

                                    MessageBox.Show("Card Details added successfully");


                                    //BOught flag be 1
                                    //add el flos lel buyer col price
                                    DataTable dtable2 = new DataTable();
                                    dtable2 = controllerObj.Price_of_car_from_vin(delete_VIN);

                                    int price = Convert.ToInt32(dtable2.Rows[0][0].ToString());
                                    int querydone3 = controllerObj.Car_is_Bought(delete_VIN, BuyerOrRenterSsn, price);

                                    if (querydone3 == 1)
                                    {
                                        MessageBox.Show("Car  bought successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Car is not bought ");
                                    }


                                }

                            }


                        }
                        

                        
                    }
                }

                else
                {
                    MessageBox.Show("Please Select Either Cash or Card");
                }
            

        }
            else  //rent msh buy
            {

                if (radioButton1.Checked == true)
                {
                    int query_done5 = controllerObj.Move_Car_to_Cars_out_Rent( delete_VIN, BuyerOrRenterSsn, year, month , day, No_of_days);
              
                    if (query_done5 == 1)
                    {
                        //bageb el price bta3 el rent per day
                        DataTable dtable5 = new DataTable();
                        dtable5 = controllerObj.How_Much_Is_Rent(delete_VIN);

                        int Rent_price_per_day = Convert.ToInt32(dtable5.Rows[0][0].ToString());
                        int total_rent_price = Rent_price_per_day * No_of_days; //get total price

                        controllerObj.update_buyer_price_rent(total_rent_price, BuyerOrRenterSsn);
                        MessageBox.Show("Car is rented successfully");
                    }
                    else
                    {
                        MessageBox.Show("Car is not rented ");
                    }

                }
                else if (radioButton2.Checked == true)    //todo valdiations
                {

                    if (CardNumber_textBox.Text == "" || Cvv_textBox.Text == "" )
                    {
                        MessageBox.Show("Please fill all boxes");
                    }
                    else
                    {
                        if (CardNumber_textBox.Text.Length != 16)
                        {
                            MessageBox.Show("Card number must be 16 digits");
                            CardNumber_textBox.Clear();



                            return;

                        }
                        else
                        {

                            if (Cvv_textBox.Text.Length != 3)
                            {
                                MessageBox.Show("Cvv must be 3 digits");
                                Cvv_textBox.Clear();


                                return;
                            }
                            else
                            {

                                DataTable dt = new DataTable();

                                int query_done = controllerObj.InsertCardDetails(Convert.ToInt64(CardNumber_textBox.Text), (int)year_num.Value, (int)Month_num.Value, Convert.ToInt32(Cvv_textBox.Text), Convert.ToInt32(SSN_textBox.Text));

                                if (query_done == 0)
                                {
                                    MessageBox.Show("Card Details invalid ");
                                }
                                else
                                {
                                    MessageBox.Show("Card Details added successfully");

                                    int query_done3 = controllerObj.Move_Car_to_Cars_out_Rent(delete_VIN, BuyerOrRenterSsn, year, month, day, No_of_days);
                                    //int query_done2 = controllerObj.Delete_car_with_vin(delete_VIN);

                                    if (query_done3 == 1)
                                    {
                                        //bageb el price bta3 el rent per day
                                        DataTable dtable5 = new DataTable();
                                        dtable5 = controllerObj.How_Much_Is_Rent(delete_VIN);
                                        int Rent_price_per_day = Convert.ToInt32(dtable5.Rows[0][0].ToString());

                                        int total_rent_price = Rent_price_per_day * No_of_days; //get total price
                                        controllerObj.update_buyer_price_rent(total_rent_price, BuyerOrRenterSsn);
                                        MessageBox.Show("Car is rented successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Car is not rented ");
                                    }

                                }


                            }



                        }


                       
                    }
                }

                else
                {
                    MessageBox.Show("Please Select Either Cash or Card");
                }

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            DataTable dt6 = new DataTable();
            dt6 = controllerObj.CheckifBuyerHasOldCard(BuyerOrRenterSsn);

            if(dt6 == null)
            {

                groupBox1.Enabled = true;
                groupBox2.Enabled = false;



                






            }
            else
            {

                groupBox1.Enabled = false;
                groupBox2.Enabled = true;

                //load combo box with old card numbers

                comboBox1.DataSource = dt6;
                comboBox1.DisplayMember = "Card_Number";


            }


           
        }


        //Card num only integres
        private void CardNumber_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        //Card only accepts num only
        private void Cvv_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        private void Done2_button_Click(object sender, EventArgs e)
        {
            if (buyrent_flag == 0) //buyer
            {
                DataTable dtable2 = new DataTable();
                dtable2 = controllerObj.Price_of_car_from_vin(delete_VIN);

                int price = Convert.ToInt32(dtable2.Rows[0][0].ToString());
                int querydone7 = controllerObj.Car_is_Bought(delete_VIN, BuyerOrRenterSsn, price);

                if (querydone7 == 1)
                {
                    MessageBox.Show("Car  bought successfully");
                }
                else
                {
                    MessageBox.Show("Car is not bought ");
                }


            }
            else  //Renter
            {
                int query_done3 = controllerObj.Move_Car_to_Cars_out_Rent(delete_VIN, BuyerOrRenterSsn, year, month, day, No_of_days);
                //int query_done2 = controllerObj.Delete_car_with_vin(delete_VIN);

                if (query_done3 == 1)
                {
                    //bageb el price bta3 el rent per day
                    DataTable dtable5 = new DataTable();
                    dtable5 = controllerObj.How_Much_Is_Rent(delete_VIN);
                    int Rent_price_per_day = Convert.ToInt32(dtable5.Rows[0][0].ToString());

                    int total_rent_price = Rent_price_per_day * No_of_days; //get total price
                    controllerObj.update_buyer_price_rent(total_rent_price, BuyerOrRenterSsn);
                    MessageBox.Show("Car is rented successfully");
                }
                else
                {
                    MessageBox.Show("Car is not rented ");
                }



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Enabled = true;
            groupBox2.Enabled = false;


        }
    }
}

//todo omaribrahim add valds
