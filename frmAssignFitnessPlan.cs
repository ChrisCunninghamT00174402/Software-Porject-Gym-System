using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;

namespace GymSys
{
    public partial class frmPlan : Form
    {
        frmFitnessPlan parent;
        FitnessProfile newFitnessProfile = new FitnessProfile();

        Member newMember = new Member();
        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }


        public frmPlan(frmFitnessPlan Parent)
        {
            InitializeComponent();
            parent = Parent;
            //adds items to the combo boxes.
            cboDiet.Items.Add("Diet Plan A");
            cboDiet.Items.Add("Diet Plan B");
            cboExercise.Items.Add("Exercise Plan A");
            cboExercise.Items.Add("Exercise Plan B");

        }





        private void frmPlan_Load(object sender, EventArgs e)
        {
            //loads members into the combobox

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            String strSQL = "SELECT M.MemberID, Surname, Forename, Date_of_Birth  FROM Members M LEFT JOIN Fitness_Profile F ON M.MemberID = F.MemberID WHERE Weight IS NOT NULL AND PLAN LIKE '%Y%'";


            myConn.Open();


            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                cboMember.Items.Add(reader.GetInt32(0).ToString("00000") + " " + reader.GetString(1).Trim() + ", " + reader.GetString(2));


            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //validation if no options are picked.
            try
            {

                newFitnessProfile.setProfileId(Convert.ToInt32(cboMember.Text.Substring(0, 5)));
                newFitnessProfile.setDietPlan(cboDiet.Text.ToString());
                newFitnessProfile.setExercisePlan(cboExercise.Text.ToString());



                newFitnessProfile.updPlans();

                MessageBox.Show("Fitness Profile Updated with Diet and Exercise Plans");

            }


            catch (Exception)
            {

                MessageBox.Show("Please fill in all details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;

            }              


         if (cboDiet.SelectedIndex == 0)
            {

                cboDiet.Text = "Diet Plan A";


            }

            if (cboDiet.SelectedIndex == 1)
            {

                cboDiet.Text = "Diet Plan B";


            }

            if (cboExercise.SelectedIndex == 0)
            {

                cboExercise.Text = "Exercise Plan A";


            }

            if (cboExercise.SelectedIndex == 1)
            {

                cboExercise.Text = "Exercise Plan B";


            }



         }

       
    }

}
