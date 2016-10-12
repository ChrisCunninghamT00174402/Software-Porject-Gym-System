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
    public partial class frmCancel : Form
    {
        frmMembers parent;
        Member newMember = new Member();
        FitnessProfile newFitnessProfile = new FitnessProfile();

        public frmCancel(frmMembers Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }


        //display the members who do not have a fitness profile.
        private void frmCancel_Load(object sender, EventArgs e)
        {
            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT M.MemberID, Surname, Forename, Date_of_Birth  FROM Members M LEFT JOIN Fitness_Profile F ON M.MemberID = F.MemberID WHERE Weight IS NULL";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridMemberShip.DataSource = ds.Tables["Member"];
            myConn.Close();


        }


        //Order by surname but not including members who have a fitness profile.
        private void optSurname_CheckedChanged(object sender, EventArgs e)
        {
            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT M.MemberID, Surname, Forename, Date_of_Birth  FROM Members M LEFT JOIN Fitness_Profile F ON M.MemberID = F.MemberID WHERE Weight IS NULL ORDER BY SURNAME";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridMemberShip.DataSource = ds.Tables["Member"];
            myConn.Close();
        }


        //Order by memberId but not including members who have a fitness profile.
        private void optMemberId_CheckedChanged(object sender, EventArgs e)
        {
            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT M.MemberID, Surname, Forename, Date_of_Birth  FROM Members M LEFT JOIN Fitness_Profile F ON M.MemberID = F.MemberID WHERE Weight IS NULL ORDER BY MEMBERID";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridMemberShip.DataSource = ds.Tables["Member"];
            myConn.Close();
        }


        //When a cell in the grid is selected the members id is displayed in a text box.
        private void gridMemberShip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            String strSno = gridMemberShip.Rows[gridMemberShip.CurrentCell.RowIndex].Cells[0].Value.ToString();

            newMember.getMemberId(int.Parse(strSno));

            txtMemberId.Text = newMember.getMemberId().ToString();


            grpMember.Visible = true;




        }

        //cancel member on button press.
        private void btnCancel_Click(object sender, EventArgs e)
        {

         
           
            newMember.cancelMember();

            MessageBox.Show("Member Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //reloads the grid with updated members.
            gridMemberShip.DataSource = null;
            gridMemberShip.Rows.Clear();
            gridMemberShip.Refresh();

            grpMember.Visible = false;


            

        }


    }
}
