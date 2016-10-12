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
    public partial class frmMemberReg : Form
    {
          frmMembers parent;
          Member newMember = new Member();


        public frmMemberReg(frmMembers Parent)
        {
            InitializeComponent();
            parent = Parent;
            //Add gender types to the combobox
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }



        private void frmMemberReg_Load(object sender, EventArgs e)
        {
            //Set the memberID. 
            txtMemberId.Text = newMember.getNextMemberId().ToString("0000");

            //When the form loads select the fee plans from the plan table.
            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);


            String strSQL = "SELECT * FROM Plans ";

            myConn.Open();


            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            OracleDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                txtPlan.Items.Add(read.GetInt32(1).ToString("00") + "," + read.GetString(2).Trim() + "," + read.GetString(3).Trim());


            }

            myConn.Close();

            txtDate.Text = DateTime.Now.ToString("dd-MMM-yy");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Valadation for null values and for the use of wrong data types.
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




            if (cboGender.Text.Equals(""))

            {

                MessageBox.Show("Please select a gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cboGender.Focus();

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

                MessageBox.Show("Numbers only for Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            //insert a new member

            newMember.setMemberId(int.Parse(txtMemberId.Text));
            newMember.setSurname(txtSurname.Text.ToString());
            newMember.setForename(txtForename.Text.ToString());
            newMember.setGender(cboGender.Text.ToString());
            newMember.setAddress(txtAddress.Text.ToString());
            newMember.setDate(String.Format("{0:dd-MMM-yy}", dtpDOB.Value));
            newMember.setPhone(int.Parse(txtPhone.Text));
            newMember.setEmail(txtEmail.Text.ToString());
            newMember.setPlan(txtPlan.Text.ToString());
            newMember.setDateReg(txtDate.Text.ToString());

            newMember.insMember();



            MessageBox.Show("Member Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear member form for a new member.

            txtMemberId.Clear();
            txtSurname.Clear();
            txtForename.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            //increment the to next available member id when form is cleared.
            txtMemberId.Text = newMember.getNextMemberId().ToString("0000");

            //lets the user choose the available options in the combobox
            if (cboGender.SelectedIndex == 0)
            {

                cboGender.Text = "Male";


            }

            if (cboGender.SelectedIndex == 1)
            {

                cboGender.Text = "Female";

            }





        }


    }

}



