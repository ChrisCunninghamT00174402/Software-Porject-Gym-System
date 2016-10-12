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
    public partial class frmChange : Form
    {
        frmMembers parent;
        Member newMember = new Member();

        public frmChange(frmMembers Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

   

        private void btnCheck_Click(object sender, EventArgs e)
        {
            /*when button is clicked this method checks to see if the user entered a valid surname. If no surname is entered
              an error will be displayed asking the user to enter a surname.
            */
              


            //get data
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members WHERE Surname LIKE  '" + txtUpdate.Text.ToString() + "%'";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridUpdate.DataSource = ds.Tables["Member"];
            myConn.Close();


            //validating if the user enter a null surname.
            if (txtUpdate.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUpdate.Focus();


                gridUpdate.Visible = false;
                return;

             }

           else {

                gridUpdate.Visible = true;
            }

            
        }



  


        private void gridUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //When a cell is clicked, the information of that member will be displayed in the selected text boxes.

            String strSno = gridUpdate.Rows[gridUpdate.CurrentCell.RowIndex].Cells[0].Value.ToString();

            newMember.getMemberId(int.Parse(strSno));

            txtMemberId.Text = newMember.getMemberId().ToString();
            txtSurname.Text = newMember.getSurname();
            txtForename.Text = newMember.getForename();
            txtAddress.Text = newMember.getAddress();
            dtpAmend.Text = newMember.getDate().ToString();
            txtPhone.Text = newMember.getPhone().ToString();
            txtEmail.Text = newMember.getEmail();
            txtPlan.Text = newMember.getPlan();



            grpListDetails.Visible = true;
        }

     

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            //Validation is the user enters a null value or the incorrect data type.

            Regex numberPatterns = new Regex(@"[0-9]");
            Regex stringPatterns = new Regex(@"[A-Z]");



            if (txtSurname.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtSurname.Focus();

                return;
            }


            else if (numberPatterns.IsMatch(txtSurname.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers not allowed for Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();

                return;
            }




            if (txtForename.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Forename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtForename.Focus();

                return;

            }


            else if (numberPatterns.IsMatch(txtForename.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers not allowed for Forename", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();

                return;
            }




            if (txtAddress.Text.Equals(""))

            {

                MessageBox.Show("Please enter an Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAddress.Focus();

                return;

            }






            if (txtPhone.Text.Equals(""))

            {

                MessageBox.Show("Please enter a Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPhone.Focus();

                return;

            }

            else if (stringPatterns.IsMatch(txtPhone.Text.ToString().ToUpper()))
            {

                MessageBox.Show("Numbers only for a Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();

                return;
            }




            if (txtEmail.Text.Equals(""))

            {

                MessageBox.Show("Please enter an Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtEmail.Focus();

                return;

            }



            if (txtPlan.Text.Equals(""))

            {

                MessageBox.Show("Please select a Plan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPlan.Focus();

                return;

            }


                
                //inserts the new information back into the members table.
                newMember.setSurname(txtSurname.Text.ToString());
                newMember.setForename(txtForename.Text.ToString());
                newMember.setAddress(txtAddress.Text.ToString());
                newMember.setDate(dtpAmend.Text);
                newMember.setPhone(int.Parse(txtPhone.Text));
                newMember.setEmail(txtEmail.Text.ToString());
                newMember.setPlan(txtPlan.Text.ToString());

                newMember.updateMembers();

                MessageBox.Show("Member Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpListDetails.Visible = false;
                //reloads the grid with the most up to date information.
                reloadGrid();


             }
        

        //method that reloads the grid.
        private void reloadGrid()
        {


            //get data
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members WHERE Surname LIKE  '" + txtUpdate.Text.ToString() + "%'";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridUpdate.DataSource = ds.Tables["Member"];
            myConn.Close();


        }


        //method that pulls the plan information from the plan table and displays it in a combobox.
        private void frmChange_Load(object sender, EventArgs e)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            String strSQL = "SELECT * FROM Plans ";

            myConn.Open();


            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                txtPlan.Items.Add(read.GetInt32(0).ToString("0") + " " + read.GetInt32(1).ToString("00") + " " + read.GetString(2).Trim() + " " + read.GetString(3).Trim());


            }

            myConn.Close();
        }
    }
    }


