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
    class FitnessHistory
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
        private String amendDate;


        public FitnessHistory()
        {

            //constuctors
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
            amendDate = "";


        }


        public FitnessHistory(int proId, int memId, int we, int he, int heart, String ill, String inj, int bloodP, int bm, int bodyF, String diet, String exercise, String amend)
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
            amendDate = amend;



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


        public String getAmendDate()
        {

            return amendDate;

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



        public void setAmendDate(String amend)
        {
            amendDate = amend;

        }



        public void insHistory()
        {
            //inserts the data into the fitness history table

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            String strSQL = "INSERT INTO FITNESS_HISTORY  Values (" + this.profileId + "," + this.memberId + "," + this.weight + "," + this.heartRate + 
                "," + this.bloodPressure + "," + this.bmi + "," + this.bodyFat + ",'" + this.amendDate + "')";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            cmd.ExecuteNonQuery();

            myConn.Close();
        }


      





    }
}
