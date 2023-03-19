using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Reflection;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //------------------------------------------------------- ADMIN ---------------------------------------------------//

        //Get Pass of admin 
        public DataTable SelectPasswordAdmin(string Username)
        {
            string query = "SELECT Password FROM Admin WHERE Username = '" + Username + "';";
            return dbMan.ExecuteReader(query);
        }

        //Change Pass of admin
        public int ChangePasswordAdmin(string UserName, string Pas)
        {
            string query = "UPDATE Admin Set Password='" + Pas + "' WHERE Username = '" + UserName + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        //Checks if username is already taken
        public int CheckifUsernameTakenAdmin(string UserName)
        {
            string query = "Select Count(1) from Admin where Username = '" + UserName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        //Inserting New Admin
        public int InsertAdmin(string Username, string Password, string FName, string LName )
        {
            string query = "INSERT into Admin VALUES('" + Username + "','" + Password + "','" + FName + "','" + LName + "'); ";
            return dbMan.ExecuteNonQuery(query);

        }

        //OD query btrg3 el cars el rented 3andy
        public DataTable Get_Rented_Cars()
        {
            string query = "select cars.Company , cars.Model, cars.Vin, cars.Colour, cars.Type from cars where cars.Rent_Flag= 1";
            return dbMan.ExecuteReader(query);

        }

        //OD  query 3shan tretrive from cars_rented
        //1.yset el rent_flag be 0 we el w_flag be 1 we el w_id be el warehouse el selected
        //2.yshelo mn el cars_out_rent

        

        public int Delete_Car_From_Cars_out_rent(string Vin) //int? btrg3 el rows affected?
        {
            string query = "delete from Cars_Out_Rent where Vin='"+ Vin   +"'";
            return dbMan.ExecuteNonQuery(query); //check
        }

        public int Retrive_Car_From_Cars_Out_rent(string vin, int W_ID)
        {
            //query btset el rent flag be 1
            int query2 = Delete_Car_From_Cars_out_rent(vin);

            if (query2 == 1) //if condition 3shan lw m3rfsh y3mel ydelete mayhotsh hnak

            {
                string query = "update Cars set Cars.M_Flag = 0, Cars.M_Id = null ,W_Flag = 1,W_Id = " + W_ID + " ,Cars.Off_Flag = 0  ,cars.Rent_Flag = 0   where vin = '" +vin+ "';";   
                return dbMan.ExecuteNonQuery(query);
            }
            else
            {

                return 0;
            }


        }


        //live share madbouly
        /*
             //move to wharehouse el adima
        public int MoveToWharehouse(string Vin, int W_Id)
        {
            string query = "update Cars set Cars.W_Flag = 1, Cars.M_Flag = 0, Cars.M_Id =NULL , Cars.W_Id =" + W_Id + " Where Cars.Vin = '" + Vin + "';";
            return dbMan.ExecuteNonQuery(query);
        }
         */

        public int MoveToWharehouse(string Vin, int W_Id,int New_Price,int Rentperdayprice)
        {
            string query = "update Cars set Cars.W_Flag = 1, Cars.M_Flag = 0, Cars.M_Id =NULL , Cars.W_Id =" + W_Id + ",Cars.Price=" + New_Price+ ",Cars.Rentperdayprice=" + Rentperdayprice +" Where Cars.Vin = '" + Vin + "';";
            return dbMan.ExecuteNonQuery(query);
        }




        //--------------------------------------- Maintainance ----------------------------------------------------------------//



        //Get Id of Maintainance
        public DataTable SelectMaintainanaceId(string dist1)
        {
            string query = "SELECT M_Id FROM Maintenance_Center Where District = '" + dist1 + "';";
            return dbMan.ExecuteReader(query);
        }

        //select all cars in maintince
    

        //Move to maintainance
        public int MoveToMaintainance(string Vin, int M_Id)
        {
            string query = "update Cars set Cars.M_Flag = 1, Cars.M_Id =" + M_Id + ",Cars.Off_Flag = 0 Where Cars.Vin = '" + Vin + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        //---------------------------------------------- Warehouses ----------------------------------------------------------//

 

        //Get Id of Warehouses
        public DataTable SelectWarehousesId(string dist)
        {
            string query = "SELECT W_Id FROM Warehouse Where District = '"+  dist +"';";
            return dbMan.ExecuteReader(query);
        }

    

 

        //Get Model of certain company in Warehouse
        public DataTable SelectModelofCompany(string company)
        {
            string query = "select distinct Model from Cars,Warehouse where W_Flag =1 and Company = '" + company + "' ;";
            return dbMan.ExecuteReader(query);
        }

        //Get Year of certain car in Warehouse
        public DataTable SelectYearofCompanyandModel(string company, string model)
        {
            string query = "select distinct Year from Cars,Warehouse where W_Flag =1 and Company = '" + company + "' and Model = '" + model + "' ;";
            return dbMan.ExecuteReader(query);
        }




        //------------------------------------------------------- SELLER ---------------------------------------------------//


        //Get offered cars of this seller
        public DataTable SelectSellerOfferedCars()
        {
            string query = "SELECT C.Vin, Company, Model, Year, Colour, Distance_Travelled, Type, F_Name, L_Name, Ssn_Seller FROM Cars as C, Seller as S"
             + " where Off_Flag=1 and C.Ssn_Seller=S.Ssn ;";


            return dbMan.ExecuteReader(query);

        }

        //Get Pass of Seller 
        public DataTable SelectPasswordSeller(string Username)
        {
            string query = "SELECT Password FROM Seller WHERE Username = '" + Username + "';";
            return dbMan.ExecuteReader(query);
        }


        //Inserting New Seller
        public int InsertSellerSignUp(string Username, string Password, int SSN, string FName, string LName)
        {
            string query = "INSERT into Seller(F_Name, L_Name, Ssn, Username, Password) VALUES('" + FName + "','" + LName + "'," + SSN + ",'" + Username + "','" + Password + "'); ";
            return dbMan.ExecuteNonQuery(query);

        }

        //Checks if username is already taken
        public int CheckifUsernameTakenSeller(string UserName)
        {
            string query = "Select Count(1) from Seller where Username = '" + UserName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        //Checks if SSN is already taken
        public int CheckifSSNTakenSeller(int SSN)
        {
            string query = "Select Count(1) from Seller where Ssn = " + SSN + ";";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }

        //MJ query btakhod el seller username we btrag3ly el ssn bta3o fe datatable
        public DataTable Sellerssn_From_Username(string username)
        {
            string query = " SELECT Ssn from Seller where Username = '" + username + " '; ";
            return dbMan.ExecuteReader(query);
        }

   

        //MJ query btrg3ly (btselect) kol el rows ely feha el Vin bta3 el 3arbya ely mkhtrha
        public DataTable ALL_From_Vin(string Vin)
        {
            string query = "Select * from Cars where Vin= '" + Vin + "'; ";
            return dbMan.ExecuteReader(query);
        }

        //MJ btupdate el car ely el seller 3amlha offer bel Vin
        public int Update_car_with_vin(int price, string Vin, string company, string model, int year, string colour, int dist, string type) //int? btrg3 el rows affected?
        {
            string query = "UPDATE CARS SET Price=" + price + ", Company='" + company + "',Model='" + model + "',Year=" + year + ",Colour='" + colour + "',Distance_Travelled=" + dist + ",Type='" + type + "' WHERE Vin='" + Vin + "';";
            return dbMan.ExecuteNonQuery(query); //check
        }

        //OD Query for (INSERTING)offering car by a seller user
        public int Insert_Offered_Car(int price, string Vin, string company, string model, int year, string colour, int dist, string type, int sellerssn)
        {
            string query = "INSERT INTO Cars (Price, Vin, Company, Model , Year ,Colour ,Distance_Travelled , Type , M_Flag , M_id , W_Flag , W_id , Off_Flag , Ssn_Seller )" +
            " VALUES ( " + price + ",'" + Vin + "','" + company + "','" + model + "'," + year + ",'" + colour + "'," + dist + ",'" + type + "', 0,NULL, 0 ,NULL , 1 ," + sellerssn + ");";

            return dbMan.ExecuteNonQuery(query);
        }


        //MJ query btremove el car mn el vin we el model we el seller_ssn
        public int Delete_car_with_vin(string Vin) //int? btrg3 el rows affected?
        {
            string query = "Delete From Cars where Vin='" + Vin + "'; ";
            return dbMan.ExecuteNonQuery(query); //check
        }

    




        //------------------------------------------------------- Buyer ----------------------------------------------------------------//

        //Get Password of buyer
        public DataTable SelectPasswordBuyer(string Username)
        {
            string query = "SELECT Password FROM Buyer WHERE Username = '" + Username + "';";
            return dbMan.ExecuteReader(query);

        }

        //Checks if username is already taken
        public int CheckifUsernameTakenBuyer(string UserName)
        {
            string query = "Select Count(1) from Buyer where Username = '" + UserName + "';";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }



        //Inserting New Buyer
        public int InsertBuyerSignUp(string Username, string Password, int SSN, string FName, string LName, string DrivLic)
        {
            string query = "INSERT into Buyer(F_Name, L_Name, Ssn, Driver_License, Username, Password) VALUES('" + FName + "','" + LName + "'," + SSN + ",'" + DrivLic + "' ,'" + Username + "','" + Password + "'); ";
            return dbMan.ExecuteNonQuery(query);

        }

        //view cars for buyer
        //madbouly
        public DataTable SelectcarForBuyer(string com, string model , int year)


        {
            int value1 = 0;
            int value2 = 900000000;

            //if(index == 0)
            //{
            //    value1 = 0;
            //    value2 = 100000;
            //}
            //else if(index == 1)
            //{
            //    value1 = 100000;
            //    value2 = 250000;
            //}
            //else if (index == 2)
            //{
            //    value1 = 250000;
            //    value2 = 500000;
            //}
            //else if (index == 3)
            //{
            //    value1 = 500000;
            //    value2 = 1000000;

            //}
            //else if (index == 4)
            //{
            //    value1 = 1000000;
            //    value2 = 7000000;

            //}
            //else  //index =10
            //{
            //    value1 = 0;
            //    value2 = 900000000;
            //}



            string query = "SELECT  Price, Rentperdayprice, Vin, Company, Model, Cars.Year, Colour, Distance_Travelled, Cars.Type FROM CARS WHERE Cars.Company='" + com+ "' and Cars.Model='" +model+"' and Cars.Year=" +year+ " and Cars.Price  between " + value1 + " and " +value2+";";
            return dbMan.ExecuteReader(query);

        }

        //filter el price range
        public DataTable SelectcarForBuyerByPrice(int index)
        {

            int value1 = 0;
            int value2 = 0;

            if (index == 0)
            {
                value1 = 0;
                value2 = 100000;
            }
            else if (index == 1)
            {
                value1 = 100000;
                value2 = 250000;
            }
            else if (index == 2)
            {
                value1 = 250000;
                value2 = 500000;
            }
            else if (index == 3)
            {
                value1 = 500000;
                value2 = 1000000;

            }
            else if (index == 4)
            {
                value1 = 1000000;
                value2 = 7000000;

            }
            else  //index =10
            {
                value1 = 0;
                value2 = 900000000;
            }



            string query = "SELECT  Price,  Vin, Company, Model, Cars.Year, Colour, Distance_Travelled, Cars.Type FROM CARS WHERE W_Flag=1 and Cars.Price  between " + value1 + " and " + value2 + ";";
            return dbMan.ExecuteReader(query);

        }


        // Inserting Card Details 

        public int InsertCardDetails(long CardNumber, int year, int month, int CVV, int SSN)
        {
            int day = 1;

            if(month < 10)
            {
                string query = "Insert into Card_Details(Card_Number, Exp_Date, Cvv, Ssn_Holder) Values(" + CardNumber + ",'" + year + "-0" + month + "-0" + day + "'," + CVV + "," + SSN + ");";
                return dbMan.ExecuteNonQuery(query);

            }
            else
            {
                string query = "Insert into Card_Details(Card_Number, Exp_Date, Cvv, Ssn_Holder) Values(" + CardNumber + ",'" + year + "-" + month + "-0" + day + "'," + CVV + "," + SSN + ");";
                return dbMan.ExecuteNonQuery(query);

            }
           
        }
       
        public int InsertCarsOutRent(int SSN, string VIN, int year,int month ,int day, int days)
        {
            if (day < 10 && month < 10)
            {
                string query = "INSERT INTO Cars_Out_Rent (Ssn,Vin,Start_Date,Days) VALUES(" + SSN + ",'" + VIN + "','" + year + "-0"+month + "-0"+day + "'," + days + ");";
                return dbMan.ExecuteNonQuery(query);
            }
            else if (day < 10 )
            {
            string query = "INSERT INTO Cars_Out_Rent (Ssn,Vin,Start_Date,Days) VALUES(" + SSN + ",'" + VIN + "','" + year + "-" + month + "-0"+day + "'," + days + ");";
                return dbMan.ExecuteNonQuery(query);
            }
            else if (month < 10)
            {
            string query = "INSERT INTO Cars_Out_Rent (Ssn,Vin,Start_Date,Days) VALUES(" + SSN + ",'" + VIN + "','" + year + "-0"+month + "-" + day + "'," + days + ");";
                return dbMan.ExecuteNonQuery(query);
            }
            else
            { 
            string query = "INSERT INTO Cars_Out_Rent (Ssn,Vin,Start_Date,Days) VALUES(" + SSN + ",'" + VIN + "','" + year+"-"+month+"-"+day+"',"+days+");";
                return dbMan.ExecuteNonQuery(query);
            }
            

        }

        //madbouly
        public DataTable GetSsnFromBuyer(string UserName)
        {
            string query = "Select Ssn from Buyer where Username = '" + UserName + "';";
            return dbMan.ExecuteReader(query);
        }




        //OD Query btset el rent flag be 1 we bthot el car fe el cars_out_rent
        /*public int Move_Car_from_Cars_To_car_out_rent(int ssn, string vin, string Start_Date, string End_Date)
        {
            //query btset el rent flag be 1
            int query2 = Set_Rent_Flag_1(vin);

            if (query2 == 1) //if condition 3shan lw m3rfsh y3mel set mayhotsh hnak

            {
                string query = "INSERT INTO Cars_Out_Rent (Ssn,Vin,Start_Date,End_Date) VALUES(" + ssn + ",'" + vin + "','" + Start_Date + "','" + End_Date + "');";    //query btwadeh lel cars_out_rent
                return dbMan.ExecuteNonQuery(query);
            }

            else
            {

                return 0;
            }
      

        }*/

        public int Move_Car_to_Cars_out_Rent(string vin , int SSN, int year, int month, int day, int days)   //hya deh ely btmove el car le el cars_out_rent we btset el flag
        {
            int query2 = InsertCarsOutRent(SSN, vin, year, month, day, days);

            if (query2 == 1)
            {  //query btset el rent_flag be 1
                string query = "update Cars set Cars.M_Flag = 0, Cars.M_Id =null ,W_Flag = 0 ,Cars.Off_Flag = 0 ,Cars.W_Id = null ,cars.Rent_Flag=1   where vin = '" + vin + "';";
                return dbMan.ExecuteNonQuery(query);
            }

            else
            {
                return 0;
            }

            
        }

        //3yz ashof el price bta3 el rent bta3 el 3arbya bkam mn el vin 
        //3ayz ashof kam el rent per day
        //add el 3la price el buyer

        //OD
        public DataTable How_Much_Is_Rent(string vin)
        {
            string query = "Select Rentperdayprice from Cars where Vin = '" + vin + "';";
            return dbMan.ExecuteReader(query);
        }





        //OD query btkhaly el 3arbya bought 
        //1.bysafr kol el flags we byset el bougt flag be 1 we byhot el buyer ssn
        //2. byinc el tamn el 3arbya fe el price ely 3nd el buyer ely bel ssn dah


        public int Set_Bought_Flag_1(string vin,int buyerssn) //query btnada fe Move_Car_from_Cars_To_car_out_rent
        {
            string query = "update Cars set Cars.M_Flag = 0, Cars.M_Id =null ,W_Flag = 0 ,Cars.Off_Flag = 0 ,Cars.W_Id = null ,cars.Rent_Flag=0,Cars.Bought_Flag =1, Ssn_Buyer= ' "+ buyerssn +"'   where vin = '" + vin + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Car_is_Bought(string vin, int buyerssn , int Car_price) //query btnada fe Move_Car_from_Cars_To_car_out_rent
        {
            int query2 = Set_Bought_Flag_1(vin, buyerssn);
            if (query2 == 1)
            {   //byadd 3la el price ely fe el buyer price el car ely eshtraha  
                string query = " UPDATE Buyer SET Price =price +" + Car_price + " where Ssn =" + buyerssn + " ;";
                return dbMan.ExecuteNonQuery(query);
            }
            else
            {
                return 0;
            }

        }

        //OD takes vin returns price 
        public DataTable Price_of_car_from_vin(string vin)
        {
            string query = "Select Price from Cars where Vin = '" + vin + "';";
            return dbMan.ExecuteReader(query);

        }

        //Checks if SSN is already taken
        public int CheckifSSNTakenBuyer(int SSN)
        {
            string query = "Select Count(1) from Buyer where Ssn = " + SSN + ";";
            return Convert.ToInt16(dbMan.ExecuteScalar(query));
        }


        //-------------------------------------PROCEDURES---------------------------------

        //Get Warehouses
        public DataTable SelectWarehouses()  //OD convert to procedure done  //Proc1
        {
            //string query = "SELECT * FROM Warehouse ;";
            //return dbMan.ExecuteReader(query);
            string StoredProcedure1 = StoredProcedures.SelectWarehouses;
            return dbMan.ExecuteReader(StoredProcedure1, null);

        }

        //Get distinct company of cars in warehouse OIbra
        public DataTable SelectCompanyCarsInWareHouse() //Proc2 used in buy or rent form in buyer
        {
            //string query = "select distinct Company from Cars where W_Flag =1;";
            // return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.SelectCompanyCarsInWareHouse;
            return dbMan.ExecuteReader(StoredProcedure1, null);

        }


        //Get Name of seller
        public DataTable SelectSellerNames() //used in car requests form in admin
        {
            //string query = "SELECT DISTINCT L_Name, F_Name FROM Seller;";
            //return dbMan.ExecuteReader(query);
            string StoredProcedure1 = StoredProcedures.SelectSellerNames;
            return dbMan.ExecuteReader(StoredProcedure1, null);

        }

        //Get Cars in Warehouse
        public DataTable SelectAllCarsInWareHouse()
        {
            //string query = "select distinct Vin, Company, Model, Year, Colour, Distance_Travelled, Type  from Cars,Warehouse where W_Flag =1;";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.SelectAllCarsInWareHouse;
            return dbMan.ExecuteReader(StoredProcedure1, null);
        }


        //msh sha8ala as proc
        public DataTable SelectAllCarsInMaintince()
        {
            string query = "select distinct Vin, Company, Model, Year, Colour, Distance_Travelled, Type,Price  from Cars,Maintenance_Center where M_Flag =1";
            return dbMan.ExecuteReader(query);

            // string StoredProcedure1 = StoredProcedures.SelectAllCarsInMaintince;
            //return dbMan.ExecuteReader(StoredProcedure1, null);
            

        }

        //Get Maintainance Centers
        public DataTable SelectMaintainanceCenters()
        {
            //string query = "SELECT distinct District FROM Maintenance_Center ;";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.SelectMaintainanceCenters;
            return dbMan.ExecuteReader(StoredProcedure1, null);
        }



        //para


        //Od query btrg3ly el cars ely el buyer 3amlha rent be el ssn bta3o
        public DataTable Rented_Cars_with_SsN(int ssn)
        {
            //string query = "select c.Vin , Company , Model , Year , Colour , Distance_Travelled , Type from Cars as c, Cars_Out_Rent as r where c.Rent_Flag = 1 AND c.Vin = r.Vin AND r.ssn =" + ssn + ";";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.Rented_Cars_with_SsN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bssn", ssn);
            return dbMan.ExecuteReader(StoredProcedure1, Parameters);
        }


        //OD query btrg3ly el cars ely el buyer eshtraha be el ssn bta3o

        public DataTable Bought_Cars_with_SsN(int ssn)
        {
            //string query = "select Vin, Company, Model, Year, Colour, Distance_Travelled, Type from Cars where Bought_flag = 1 AND Ssn_Buyer = " + ssn + ";";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.Bought_Cars_with_SsN;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bssn", ssn);
            return dbMan.ExecuteReader(StoredProcedure1, Parameters);
        }

        //OD
        public int update_buyer_price_rent(int rentprice, int buyerssn)
        {

            //string query = " UPDATE Buyer SET Price =price +" + rentprice + " where Ssn =" + buyerssn + " ;";
            //return dbMan.ExecuteNonQuery(query);

            string StoredProcedure1 = StoredProcedures.update_buyer_price_rent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bssn", buyerssn);
            Parameters.Add("@rentprice", rentprice);
            return dbMan.ExecuteNonQuery(StoredProcedure1, Parameters);
        }

        //MJ query btrg3 ely el seller sold
        public DataTable Sold_car_with_Sellerssn(int sellerssn) //int? btrg3 el rows affected?
        {
            //string query = "SELECT Price, Vin, Company, Model, Year, Colour, Distance_Travelled, Type FROM CARS WHERE Off_Flag = 0 AND Ssn_Seller = " + sellerssn + ";";
            //return dbMan.ExecuteReader(query);
            string StoredProcedure1 = StoredProcedures.Sold_car_with_Sellerssn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bssn", sellerssn);
            return dbMan.ExecuteReader(StoredProcedure1, Parameters);

        }

        //MJ query btrg3ly (btselect) kol el rows ely feha el seller ely 3amel sign in 3an tare2 el ssn bta3o
        public DataTable ALL_From_Sellerssn(int sellerssn)
        {
            //string query = "Select * from Cars where Ssn_Seller= '" + sellerssn + "'; ";
            //return dbMan.ExecuteReader(query);

            string StoredProcedure1 = StoredProcedures.ALL_From_Sellerssn;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@bssn", sellerssn);
            return dbMan.ExecuteReader(StoredProcedure1, Parameters);

        }



        public DataTable CheckifBuyerHasOldCard(int ssn)
        {
            string query = "Select Card_Number from Buyer as B,Card_Details as C where B.Ssn =  " + ssn + " and B.Ssn = C.Ssn_Holder;";
            return dbMan.ExecuteReader(query);
        }

    }
}