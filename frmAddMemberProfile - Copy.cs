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
using System.Text.RegularExpressions;

namespace GymSys
{
    public partial class frmProfile : Form
    {
        frmFitnessPlan parent;
        FitnessProfile newFitnessProfile = new FitnessProfile();
        Member newMember = new Member();
        FitnessHistory newFitnessHistory = new FitnessHistory();
        public frmProfile(frmFitnessPlan Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

       
        private void frmProfile_Load(object sender, EventArgs e)
        {
            //loads the need profile method and the get next profile id method.
            gridPlan.DataSource = newMember.needProfile().Tables["Member"];
            txtProfile.Text = newFitnessProfile.getNextProfileId().ToString("0000");
        }


        public void load()
        {

            //displays members in the grid that want afitness profile and remove them from the grid apon completing a fitness profile. 
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

            gridPlan.DataSource = ds.Tables["Member"];

            myConn.Close();

            



        }

        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            //Validation for null entrie and for wrong data types.
                Regex numberPatterns = new Regex(@"[0-9]");
                Regex stringPatterns = new Regex(@"[A-Z]");


            if (txtWeight.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtWeight.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtWeight.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Weight", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWeight.Focus();

                return;
            }



            if (txtHeight.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHeight.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtHeight.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Focus();

                return;
            }




            if (txtHeart.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Heart Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtHeart.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtHeart.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Heart Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeart.Focus();

                return;
            }



            if (txtBlood.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Blood Pressure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBlood.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtBlood.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Blood Pressure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBlood.Focus();

                return;
            }



            if (txtBmi.Text.Equals(""))

            {

                MessageBox.Show("Please enter a BMI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBmi.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtBmi.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for BMI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBmi.Focus();

                return;
            }


            if (txtBodyFat.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Body Fat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtBodyFat.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtBodyFat.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Body Fat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBodyFat.Focus();

                return;
            }


                
                 //inserts the data into the fitness profile table   
                newFitnessProfile.setProfileId(int.Parse(txtProfile.Text));
                newFitnessProfile.setMemberId(int.Parse(txtMemberPlan.Text));
                newFitnessProfile.setWeight(int.Parse(txtWeight.Text));
                newFitnessProfile.setHeight(int.Parse(txtHeight.Text));
                newFitnessProfile.setHeartRate(int.Parse(txtHeart.Text));
                newFitnessProfile.setIllness(txtIllness.Text.ToString());
                newFitnessProfile.setInjurys(txtInjurys.Text.ToString());
                newFitnessProfile.setBloodPressure(int.Parse(txtBlood.Text));
                newFitnessProfile.setBmi(int.Parse(txtBmi.Text));
                newFitnessProfile.setBodyFat(int.Parse(txtBodyFat.Text));
                newFitnessProfile.setDate(txtDate.Text.ToString());

                newFitnessProfile.insProfile();

                //insertas the data into the fitness history table.
                newFitnessHistory.setMemberId(int.Parse(txtMemberPlan.Text));
                newFitnessHistory.setProfileId(int.Parse(txtProfile.Text));
                newFitnessHistory.setWeight(int.Parse(txtWeight.Text));
                newFitnessHistory.setHeartRate(int.Parse(txtHeart.Text));
                newFitnessHistory.setBloodPressure(int.Parse(txtBlood.Text));
                newFitnessHistory.setBmi(int.Parse(txtBmi.Text));
                newFitnessHistory.setBodyFat(int.Parse(txtBodyFat.Text));
                newFitnessHistory.setAmendDate(txtDate.Text.ToString());


                newFitnessHistory.insHistory();

               

                MessageBox.Show("Fitness Profile Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //clears the data in the form
                txtMemberPlan.Clear();
                txtProfile.Clear();
                txtHeight.Clear();
                txtWeight.Clear();
                txtBlood.Clear();
                txtBmi.Clear();
                txtBodyFat.Clear();
                txtIllness.Clear();
                txtInjurys.Clear();
                txtHeart.Clear();
              
                txtProfile.Text = newFitnessProfile.getNextProfileId().ToString("0000");
                grpAddPorfile.Visible = false;
                
                //reloads the grid
                load();


          







        }




        // when a cell is clicked in the grid the corresponding member id is displayed in the text box
        private void gridPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

         

            String strSno = gridPlan.Rows[gridPlan.CurrentCell.RowIndex].Cells[0].Value.ToString();


            newMember.getMemberId(int.Parse(strSno));


            txtMemberPlan.Text = newMember.getMemberId().ToString();
            txtDate.Text = DateTime.Now.ToString("dd-MMM-yy");

            grpAddPorfile.Visible = true;

           
        }

       
    }
    }
