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
    public partial class frmFees : Form
    {
        frmAdmin parent;
        Plans newPlan = new Plans();

        public frmFees(frmAdmin Parent)
        {
            InitializeComponent();
            parent = Parent;
            //adds items to the combobox
            txtProfileIncluded.Items.Add("Yes");
            txtProfileIncluded.Items.Add("No");
            cboDuration.Items.Add("3 Months");
            cboDuration.Items.Add("6 Months");
            cboDuration.Items.Add("12 Months");

            cboUpDuration.Items.Add("3 Months");
            cboUpDuration.Items.Add("6 Months");
            cboUpDuration.Items.Add("12 Months");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void btnAddNewPlan_Click(object sender, EventArgs e)
        {
              //Validation for null values and incorrect data types.
                Regex stringPatterns = new Regex(@"[A-Z]");


            if (txtPrice.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPrice.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtPrice.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();

                return;
            }


            if (cboDuration.Text.Equals(""))

            {

                MessageBox.Show("Please pick a duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboDuration.Focus();

                return;

            }

            if (txtProfileIncluded.Text.Equals(""))

            {

                MessageBox.Show("Please indicate if Personal Trainer Included", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtProfileIncluded.Focus();

                return;

            }


            //sets the values entered.
           

                newPlan.setPlanName(int.Parse(txtPlanCode.Text));
                newPlan.setPrice(int.Parse(txtPrice.Text));
                newPlan.setDuration(cboDuration.Text.ToString());
                newPlan.setProfileIncluded(txtProfileIncluded.Text.ToString());

                newPlan.insPlan();

                MessageBox.Show("New Plan Set", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPlanCode.Text = newPlan.getPlanCode().ToString("0000");

                txtPlanCode.Clear();
                txtPrice.Clear();

                txtPlanCode.Text = newPlan.getPlanCode().ToString("0000");

                if (txtProfileIncluded.SelectedIndex == 0)
                {

                    txtProfileIncluded.Text = "Yes";


                }

                if (txtProfileIncluded.SelectedIndex == 1)
                {

                    txtProfileIncluded.Text = "No";

                   


                }


                if(cboDuration.SelectedIndex == 0)
                {

                    cboDuration.Text = "3 Months";

                }


                if(cboDuration.SelectedIndex == 1)
                {

                    cboDuration.Text = "6 Months";

                }


                if(cboDuration.SelectedIndex == 2)
                {

                    cboDuration.Text = "12 Months";

                }

                        reloadGrid();

          
        }

        private void frmFees_Load(object sender, EventArgs e)
        {
            //diplays the fees info on the grid.
            txtPlanCode.Text = newPlan.getPlanCode().ToString("0000");

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Plans";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Plans");
            grdListPlan.DataSource = ds.Tables["Plans"];
            myConn.Close();
        }

        private void grdListPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   

            String strSno = grdListPlan.Rows[grdListPlan.CurrentCell.RowIndex].Cells[0].Value.ToString();


            newPlan.getCodeUpdate(int.Parse(strSno));

            txtUpCode.Text = newPlan.getPlanC().ToString();
            txtUpPrice.Text = newPlan.getPrice().ToString();
            cboUpDuration.Text = newPlan.getDuration();


            grpUpFee.Visible = true;


        }

        private void btnUpdatePlans_Click(object sender, EventArgs e)
        {
            //Validation for null values and incorrect data types.
                Regex stringPatterns = new Regex(@"[A-Z]");


            if (txtUpPrice.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUpPrice.Focus();

                return;

            }


            else if (stringPatterns.IsMatch(txtUpPrice.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpPrice.Focus();

                return;
            }


            if (cboUpDuration.Text.Equals(""))

            {

                MessageBox.Show("Please pick a duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboUpDuration.Focus();

                return;

            }



                newPlan.setPrice(int.Parse(txtUpPrice.Text));
                newPlan.setDuration(cboUpDuration.Text.ToString());

                newPlan.updatePlans();

                MessageBox.Show("Plan Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reloads the grid on butoon click.
                reloadGrid();

            



            


            if (cboUpDuration.SelectedIndex == 0)
            {

                cboUpDuration.Text = "3 Months";

            }


            if (cboUpDuration.SelectedIndex == 1)
            {

                cboUpDuration.Text = "6 Months";

            }


            if (cboUpDuration.SelectedIndex == 2)
            {

                cboUpDuration.Text = "12 Months";

            }


        }


        public void reloadGrid()
        {
            //reloads the grid.
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Plans";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Plans");
            grdListPlan.DataSource = ds.Tables["Plans"];
            myConn.Close();



        }

      
    }
}
