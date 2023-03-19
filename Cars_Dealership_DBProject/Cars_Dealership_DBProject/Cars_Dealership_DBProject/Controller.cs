using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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


        //--------------------------------------- Maintainance ----------------------------------------------------------------//

        //Get Maintainance Centers
        public DataTable SelectMaintainanceCenters()
        {
            string query = "SELECT distinct District FROM Maintenance_Center ;";
            return dbMan.ExecuteReader(query);
        }
     

        //Get Id of Maintainance
        public DataTable SelectMaintainanaceId(string dist1)
        {
            string query = "SELECT M_Id FROM Maintenance_Center Where District = '" + dist1 + "';";
            return dbMan.ExecuteReader(query);
        }

        //select all cars in maintince
        public DataTable SelectAllCarsInMaintince()
        {
            string query = "select distinct Vin, Company, Model, Year, Colour, Distance_Travelled, Type  from Cars,Maintenance_Center where M_Flag =1";
            return dbMan.ExecuteReader(query);
        }

        //Move to maintainance
        public int MoveToMaintainance(string Vin, int M_Id)
        {
            string query = "update Cars set Cars.M_Flag = 1, Cars.M_Id =" + M_Id + ",Cars.Off_Flag = 0 Where Cars.Vin = '" + Vin + "';";
            return dbMan.ExecuteNonQuery(query);
        }




        //---------------------------------------------- Warehouses ----------------------------------------------------------//

        //Get Warehouses
        public DataTable SelectWarehouses()
        {
            string query = "SELECT District FROM Warehouse ;";
            return dbMan.ExecuteReader(query);
        }

        //Get Id of Warehouses
        public DataTable SelectWarehousesId(string dist)
        {
            string query = "SELECT W_Id FROM Warehouse Where District = '"+  dist +"';";
            return dbMan.ExecuteReader(query);
        }

        //move to wharehouse
        public int MoveToWharehouse(string Vin, int W_Id)
        {
            string query = "update Cars set Cars.W_Flag = 1, Cars.M_Flag = 0, Cars.M_Id =NULL , Cars.W_Id =" + W_Id + " Where Cars.Vin = '" + Vin + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        
        //------------------------------------------------------- SELLER ---------------------------------------------------//

        //Get Name of seller
        public DataTable SelectSellerNames()
        {
            string query = "SELECT DISTINCT L_Name, F_Name FROM Seller;";
            return dbMan.ExecuteReader(query);
        }

        //Get offered cars of this seller
        public DataTable SelectSellerOfferedCars(string FName, string LName)
        {
            string query = "SELECT C.Vin, Company, Model, Year, Colour, Distance_Travelled, Type FROM Cars as C, Seller as S"
             + " where Off_Flag=1 and C.Ssn_Seller=S.Ssn and S.L_Name='" + LName + "' and S.F_Name='" + FName + "' ;";

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


        //OD Query for (INSERTING)offering car by a seller user
        public int Insert_Offered_Car (int price , string Vin , string company ,string model , int year , string colour , int dist , string type ,int sellerssn)
        {
            string query = "INSERT INTO Cars (Price, Vin, Company, Model , Year ,Colour ,Distance_Travelled , Type , M_Flag , M_id , W_Flag , W_id , Off_Flag , Ssn_Seller )" +
            " VALUES ( " + price + ",'" + Vin + "','" + company + "','" + model + "'," + year + ",'" + colour + "'," + dist + ",'" + type + "', 0,NULL, 0 ,NULL , 1 ,"+sellerssn  +");";

            return dbMan.ExecuteNonQuery(query);
        } 


        //MJ query btakhod el seller username we btrag3ly el ssn bta3o fe datatable
        public DataTable Sellerssn_From_Username (string username)
        {
            string query = " SELECT Ssn from Seller where Username = '" + username + " '; ";
            return dbMan.ExecuteReader(query);
        }


        //MJ query btremove el car mn el vin we el model we el seller_ssn
        public int Delete_car_with_vin(string Vin) //int? btrg3 el rows affected?
        {
            string query = "Delete From Cars where Vin='" + Vin + "'; ";
            return dbMan.ExecuteNonQuery(query); //check
        }



        //MJ query btrg3ly (btselect) kol el rows ely feha el seller ely 3amel sign in 3an tare2 el ssn bta3o
        public DataTable ALL_From_Sellerssn(int sellerssn)
        {
            string query = "Select * from Cars where Ssn_Seller= '"+sellerssn+"'; ";
            return dbMan.ExecuteReader(query);
        }


        //MJ query btrg3ly (btselect) kol el rows ely feha el Vin bta3 el 3arbya ely mkhtrha
        public DataTable ALL_From_Vin(string Vin)
        {
            string query = "Select * from Cars where Vin= '" +Vin+ "'; ";
            return dbMan.ExecuteReader(query);
        }

        //MJ btupdate el car ely el seller 3amlha offer bel Vin
        public int Update_car_with_vin(int price, string Vin, string company, string model, int year, string colour, int dist, string type) //int? btrg3 el rows affected?
        {
            string query = "UPDATE CARS SET Price="+ price + ", Company='"+ company + "',Model='"+ model + "',Year="+year+",Colour='"+colour+"',Distance_Travelled="+dist+",Type='"+type+"' WHERE Vin='"+Vin+"';";
            return dbMan.ExecuteNonQuery(query); //check
        }


        //MJ query btrg3 ely el seller sold
        public DataTable Sold_car_with_Sellerssn(int sellerssn) //int? btrg3 el rows affected?
        {
            string query = "SELECT Price, Vin, Company, Model, Year, Colour, Distance_Travelled, Type FROM CARS WHERE Off_Flag = 0 AND Ssn_Seller = "+sellerssn+";";
            return dbMan.ExecuteReader(query);
        }







    }
}