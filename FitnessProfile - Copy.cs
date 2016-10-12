using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace GymSys
{
    class FitnessProfile
    {
        //attributes
        private int profileId;
        private int memberId;
        private int weight;
        private int height;
        private int heartRate;
        private String illness;
        private String injurys;
        private int bloodPressure;
        private int bmi;
        private int bodyFat;
        private String dietPlan;
        private String exercisePlan;
        private String date;



        public FitnessProfile()
        {

            //constructors
            profileId = 0;
            memberId = 0;
            weight = 0;
            height = 0;
            heartRate = 0;
            illness = "";
            injurys = "";
            bloodPressure = 0;
            bmi = 0;
            bodyFat = 0;
            dietPlan = "";
            exercisePlan = "";
            date = "";

        }


        public FitnessProfile(int proId, int memId, int we, int he, int heart, String ill, String inj, int bloodP, int bm, int bodyF, String diet, String exercise,String dat)
        {


            profileId = proId;
            memberId = memId;
            weight = we;
            height = he;
            heartRate = heart;
            illness = ill;
            injurys = inj;
            bloodPressure = bloodP;
            bmi = bm;
            bodyFat = bodyF;
            dietPlan = diet;
            exercisePlan = exercise;
            date = dat;



        }

        //accessors
        public int getProfileId()
        {

            return profileId;

        }

        public int getMemberId()
        {
            return memberId;

        }



        public int getWeight()
        {
            return weight;

        }

        public int getHeight()
        {
            return height;

        }

        public int getHeartRate()
        {
            return heartRate;

        }


        public String getIllness()
        {
            return illness;

        }


        public String getInjurys()
        {

            return injurys;

        }


        public int getBloodPressure()
        {

            return bloodPressure;

        }


        public int getBmi()
        {
            return bmi;

        }

        public int getBodyFat()
        {

            return bodyFat;

        }

        public String getDietPlan()
        {

            return dietPlan;

        }


        public String getExercise()
        {

            return exercisePlan;

        }


        public String getDate()
        {
            return date;

        }

        //mutators
        public void setProfileId(int proId)
        {

            profileId = proId;

        }


        public void setMemberId(int memberId)
        {

            this.memberId = memberId;

        }




        public void setWeight(int we)
        {

            weight = we;

        }


        public void setHeight(int he)
        {

            height = he;

        }

        public void setHeartRate(int heart)
        {

            heartRate = heart;

        }


        public void setIllness(String ill)
        {

            illness = ill;

        }


        public void setInjurys(String inj)
        {

            injurys = inj;

        }




        public void setBloodPressure(int bloodP)
        {

            bloodPressure = bloodP;

        }


        public void setBmi(int bm)
        {

            bmi = bm;

        }


        public void setBodyFat(int bodyF)
        {


            bodyFat = bodyF;

        }

        public void setDietPlan(String diet)
        {


            dietPlan = diet;

        }

        public void setExercisePlan(String exercise)
        {


            exercisePlan = exercise;

        }

        public void setDate(String dat)
        {

            date = dat;

        }

        public int getNextProfileId()
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT MAX(PROFILEID) FROM Fitness_Profile";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0)) profileId = 1;

            else
                profileId = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return profileId;

        }



        //insert values into a fitness profile
        public void insProfile()
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "INSERT INTO FITNESS_PROFILE Values (" + this.profileId + "," + this.memberId + "," + this.weight + "," + this.height + "," + this.heartRate + ",'" + this.illness + "','" + this.injurys +
                "'," + this.bloodPressure + "," + this.bmi + "," + this.bodyFat + ",'" + this.dietPlan + "','" + this.exercisePlan + "','" + this.date + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        //updates the fitness profile with the selected diet and exercise plans
        public void updPlans()
        {

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "UPDATE Fitness_Profile SET diet_Plan = '" + this.dietPlan + "', exercise_plan ='" + this.exercisePlan + "' WHERE profileId = " + this.profileId;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();
        }

        public void getMemberShip(int sno)
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT * FROM Members WHERE MemberID = " + sno.ToString();

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            this.memberId = dr.GetInt32(0);


        }

        //Finds the profile id.
        public void getProfile(int sno)
        {


            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "SELECT * FROM Fitness_Profile WHERE ProfileID = " + sno.ToString();

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();


            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.profileId = dr.GetInt32(0);
            this.memberId = dr.GetInt32(1);
            this.weight = dr.GetInt32(2);
            this.heartRate = dr.GetInt32(4);
            this.bloodPressure = dr.GetInt32(7);
            this.bmi = dr.GetInt32(8);
            this.bodyFat = dr.GetInt32(9);



            myConn.Close();


        }

        //updates the fitness profile with the new data
        public void updateProfile()
        {



            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = " UPDATE FITNESS_PROFILE SET  " +  "weight = " + this.weight + ", heart_Rate= " + this.heartRate + ", blood_Pressure =" + this.bloodPressure + ", bmi =" + this.bmi + ", body_fat =" + this.bodyFat + " " + "WHERE profileId = " + this.profileId;




            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();




        }


      

     



    }

}






