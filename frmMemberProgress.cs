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
using System.Text.RegularExpressions;


namespace GymSys
{
    public partial class frmProgress : Form
    {
        frmFitnessPlan parent;
        Member newMember = new Member();
        FitnessProfile newFitnessProfile = new FitnessProfile();
        FitnessHistory newFitnessHistory = new FitnessHistory();

        public frmProgress(frmFitnessPlan Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

     

        private void btnCheckID_Click(object sender, EventArgs e)
        {
           
            //calls method that shows member profiles in the grid
            gridUpProfile.DataSource = newMember.findMembers().Tables["Member"];
            gridUpProfile.Visible = true;

        }


        private void gridUpProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validation if an empty cell is clicked
            try {
                String strSno = gridUpProfile.Rows[gridUpProfile.CurrentCell.RowIndex].Cells[3].Value.ToString();

                //displays the information of the fitness profile in the text box
                newFitnessProfile.getProfile(int.Parse(strSno));

                txtMemId.Text = newFitnessProfile.getMemberId().ToString();
                txtProId.Text = newFitnessProfile.getProfileId().ToString();
                txtWe.Text = newFitnessProfile.getWeight().ToString();
                txtHRate.Text = newFitnessProfile.getHeartRate().ToString();
                txtBPressure.Text = newFitnessProfile.getBloodPressure().ToString();
                txtB.Text = newFitnessProfile.getBmi().ToString();
                txtBFat.Text = newFitnessProfile.getBodyFat().ToString();

                txtAmendDate.Text = DateTime.Now.ToString("dd-MMM-yy");
                grpProfile.Visible = true;

               }


            catch (Exception)
            {

                MessageBox.Show("Error", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnUpFitness_Click(object sender, EventArgs e)
        {
            //validation for null values and wrong data types.
            Regex stringPatterns = new Regex(@"[A-Z]");


            if (txtWe.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtWe.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtWe.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWe.Focus();

                return;
            }

            if (txtHRate.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Heart Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHRate.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtHRate.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Heart Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHRate.Focus();

                return;
            }



            if (txtBPressure.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Blood Pressure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBPressure.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtBPressure.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Blood Pressure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBPressure.Focus();

                return;
            }



            if (txtB.Text.Equals(""))

            {

                MessageBox.Show("Please enter a BMI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtB.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtB.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for BMI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();

                return;
            }


            if (txtBFat.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Body Fat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBFat.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtBFat.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Body Fat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBFat.Focus();

                return;
            }


                //inserts into the fitess history table
                newFitnessHistory.setProfileId(int.Parse(txtProId.Text));
                newFitnessHistory.setMemberId(int.Parse(txtMemId.Text));
                newFitnessHistory.setWeight(int.Parse(txtWe.Text));
                newFitnessHistory.setHeartRate(int.Parse(txtHRate.Text));
                newFitnessHistory.setBloodPressure(int.Parse(txtBPressure.Text));
                newFitnessHistory.setBmi(int.Parse(txtB.Text));
                newFitnessHistory.setBodyFat(int.Parse(txtBFat.Text));
                newFitnessHistory.setAmendDate(txtAmendDate.Text.ToString());

                newFitnessHistory.insHistory();

           
                //updates the fitness profile table.
                newFitnessProfile.setWeight(int.Parse(txtWe.Text));
                newFitnessProfile.setHeartRate(int.Parse(txtHRate.Text));
                newFitnessProfile.setBloodPressure(int.Parse(txtBPressure.Text));
                newFitnessProfile.setBmi(int.Parse(txtB.Text));
                newFitnessProfile.setBodyFat(int.Parse(txtBFat.Text));


                newFitnessProfile.updateProfile();

                MessageBox.Show("Member Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

               


        



        }

        //
        private void frmProgress_Load(object sender, EventArgs e)
        {   

            //loads the members into the grid who have a fitness profile completed.
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            String strSQL = "SELECT M.MemberID, Surname, Forename, Date_of_Birth  FROM Members M LEFT JOIN Fitness_Profile F ON M.MemberID = F.MemberID WHERE Weight IS NOT NULL AND PLAN LIKE '%Y%'";

            if (strSQL.Equals(null))
            {
                MessageBox.Show("Error");
            }

            else 
            {
                myConn.Open();


                OracleCommand cmd = new OracleCommand(strSQL, myConn);

                OracleDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    cmMember.Items.Add(reader.GetInt32(0).ToString("0") + " " + reader.GetString(1).Trim() + ", " + reader.GetString(2));


                }
            }

           


        }

        //On click the members id is picked out of the string and the corresponding updates of the fitness history is displayed.
        private void txtFind_Click(object sender, EventArgs e)
        {
            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * From Fitness_History WHERE MEMBERID LIKE '%" + cmMember.Text.Substring (0,1) + "%'";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Fitness_History");
            gridFitnessHistory.DataSource = ds.Tables["Fitness_History"];
            myConn.Close();

        




        }



        private void cmMember_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnFind.Visible = true;
        }
    }
    }
    

