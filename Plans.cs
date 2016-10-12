using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;



namespace GymSys
{
    class Plans
    {   
        //attributes.
        private int planCode;
        private int price;
        private String duration;
        private String profileIncluded;



        public Plans()
        {
            //constuctors
            planCode = 0;
            price = 0;
            duration = "";
            profileIncluded = "";
         


        }



        public Plans(int planC, int pr, String dur, String profileInclud)
        {

            planCode = planC;
            price = pr;
            duration = dur;
            profileIncluded = profileInclud;


        }


        //accessors
        public int getPlanC()
        {
            return planCode;

        }


        public int getPrice()
        {
            return price;

        }

        public String getDuration()
        {

            return duration;

        }

        public String getProfileIncluded()
        {

            return profileIncluded;

        }

        //mutators
        public void setPlanName(int planC)
        {

            planCode = planC;

        }


        public void setPrice(int pr)
        {

            price = pr;

        }


        public void setDuration(String dur)
        {

            duration = dur;

        }


        public void setProfileIncluded(String profileInclud)
        {

            profileIncluded = profileInclud;


        }


        //Gets the plan code and increments the next value by one
        public int getPlanCode()
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT MAX(Plan_Code) FROM Plans";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0)) planCode = 1;

            else
                planCode = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return planCode;

        }

        //inserts the valus into the plans table
        public void insPlan()
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "INSERT INTO Plans Values (" + this.planCode + "," + this.price + ",'" + this.duration + "','" + this.profileIncluded + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();


        }



        public void getCodeUpdate(int sno)
        {


            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT * FROM PLANS WHERE Plan_Code = " + sno.ToString();

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            this.planCode = dr.GetInt32(0);
            this.price = dr.GetInt32(1);
            this.duration = dr.GetString(2);

            myConn.Close();




        }


        public void updatePlans()
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = " UPDATE PLANS SET  " + " price = " + this.price + ", plan_duration = '" + this.duration + "'  " + "WHERE Plan_Code = " + this.planCode;




            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();





        }

        public int showMember()
        {

            //counts the number of members registered.
            //connect to database

            

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT COUNT(MemberID) FROM Members";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            

            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr.GetInt32(0);


            cmd.ExecuteNonQuery();

            myConn.Close();


        }



        public int showProfiles()
        {

            //counts the number of fitness profiles
            //connect to database



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT COUNT(ProfileID) FROM Fitness_Profile";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);



            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr.GetInt32(0);


            cmd.ExecuteNonQuery();

            myConn.Close();


        }


        public int showFemale()
        {
            //counts the number of females

            //connect to database



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT COUNT(Gender) FROM Members WHERE Gender LIKE '%Female%'";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);



            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr.GetInt32(0);


            cmd.ExecuteNonQuery();

            myConn.Close();


        }

        public int showMale()
        {
            //counts the nuber of males
            //connect to database



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT COUNT(Gender) FROM Members WHERE Gender = 'Male'";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);



            myConn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            return dr.GetInt32(0);


            cmd.ExecuteNonQuery();

            myConn.Close();


        }







    }

}