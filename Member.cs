using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;


namespace GymSys
{
    class Member
    {
        //attributes
        private int memberId;
        private String surname;
        private String forename;
        private String gender;
        private String address;
        private String date;
        private int phone;
        private String email;
        private String plan;
        private String dateReg;


        //constuctors
        public Member()
        {
            memberId = 0;
            surname = "";
            forename = "";
            gender = "";
            address = "";
            date = "";
            phone = 0;
            email = "";
            plan = "";
            dateReg = "";
            

        }


        public Member(int memId, String sur, String fore, String gen, String add, String dat, int pho, String em, String pl,String datReg)
        {

            memberId = memId;
            surname = sur;
            forename = fore;
            gender = gen;
            address = add;
            date = dat;
            phone = pho;
            email = em;
            plan = pl;
            dateReg = datReg;

        }




        //mutators
        public void setMemberId(int memberId)
        {

            this.memberId = memberId;

        }



        public void setSurname(String sur)
        {

            surname = sur;

        }


        public void setForename(String fore)
        {

            forename = fore;

        }

        public void setGender(String gen)
        {

            gender = gen;

        }


        public void setAddress(String add)
        {

            address = add;

        }

        public void setDate(String dat)
        {

            date = dat;

        }


        public void setPhone(int pho)
        {

            phone = pho;

        }




        public void setEmail(String em)
        {

            email = em;

        }


        public void setPlan(String pl)
        {

            plan = pl;

        }



        public void setDateReg(String datReg)
        {

            dateReg = datReg;

        }



        //accessors
        public int getMemberId()
        {
            return memberId;

        }



        public String getSurname()
        {
            return surname;

        }


        public String getForename()
        {
            return forename;

        }

        public String getGender()
        {
            return gender;

        }


        public String getAddress()
        {
            return address;

        }


        public String getDate()
        {
            return date;

        }


        public int getPhone()
        {
            return phone;

        }

        public String getEmail()
        {
            return email;

        }

        public String getPlan()
        {
            return plan;

        }


        public String getDateReg()
        {
            return dateReg;

        }


        //method that gets the next member id for member registration.
        public int getNextMemberId()
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT MAX(MemberID) FROM Members";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();


            //increments the member id by 1.
            dr.Read();
            if (dr.IsDBNull(0)) memberId = 1;

            else
                memberId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return memberId;




        }


        //method that inserts into to members table.
        public void insMember()
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "INSERT INTO Members Values (" + this.memberId + ",'" + this.surname + "','" + this.forename + "','" + this.gender + "','" + this.address + "','" + this.date + "'," + this.phone + ",'" + this.email + "','" + this.plan + "','" + this.dateReg + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();


        }


        //Lists the members by the order selected in the list form.
        public void listMember(String Order)
        {

            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members ORDER BY" + Order;

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();



            da.Fill(ds, "Member");



            myConn.Close();




        }

        //method that returns the information of the selected member.
        public void getMemberId(int sno)
        {


            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT * FROM Members WHERE MemberID = " + sno.ToString();

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            this.memberId = dr.GetInt32(0);
            this.surname = dr.GetString(1);
            this.forename = dr.GetString(2);
            this.address = dr.GetString(4);
            this.date = dr.GetString(5);
            this.phone = dr.GetInt32(6);
            this.email = dr.GetString(7);
            this.plan = dr.GetString(8);



        }


        //Updates member table.
        public void updateMembers()
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = " UPDATE MEMBERS SET  " + "surname = '" + this.surname + "', forename = '" + this.forename + "', address = '" +
                this.address + "', DATE_OF_BIRTH = '" + this.date + "', phone =" + this.phone + ", email ='" + this.email + "', plan ='" + this.plan + "' " + "WHERE MemberID = " + this.memberId;



            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();



        }


        public void ListMemberShip(String Order)
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members ORDER BY" + Order;

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();



            da.Fill(ds, "Member");



            myConn.Close();



        }



        public void getMemberShip(int sno1)
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT * FROM Members WHERE MemberID = " + sno1.ToString();

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            this.memberId = dr.GetInt32(0);


        }

           //Deletes members from the members table
          public void cancelMember(){


            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = " DELETE FROM MEMBERS WHERE MemberID =  " + this.memberId; 
               



            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();


        }


        //Retrieves both the members information and fitness profile information to be displayed in the grid of member progress.
        public DataSet findMembers() {

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT M.MemberId, Surname, Forename, ProfileId FROM Members M, Fitness_Profile F  WHERE M.MemberId = F.MemberId";
            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");

            myConn.Close();

            return ds;


        }

        //Displays members in a grid that want a fitness profile and removes that memeber from the grid apon completing a fitness profile.
        public DataSet needProfile()
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT M.MemberID, Surname, Forename, Date_of_Birth  FROM Members M LEFT JOIN Fitness_Profile F ON M.MemberID = F.MemberID WHERE Weight IS NULL AND PLAN LIKE '%Y%'  ";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");

            myConn.Close();

            return ds;


        }


    }
}
