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

    
    public partial class MemberList : Form
    {

        frmMembers parent;

        public MemberList(frmMembers Parent)
        {
            InitializeComponent();
            parent = Parent;
           
        }


        //Order by surname method.
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members ORDER BY SURNAME";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridMember.DataSource = ds.Tables["Member"];
            myConn.Close();

        }


        //Select all members from the member table.
        private void frmMemberList_Load(object sender, EventArgs e)
        {
            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridMember.DataSource = ds.Tables["Member"];
            myConn.Close();




        }

        //Order by member id.
        private void optMemberId_CheckedChanged(object sender, EventArgs e)
        {

            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT * FROM Members ORDER BY MEMBERID";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Member");
            gridMember.DataSource = ds.Tables["Member"];
            myConn.Close();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            parent.Visible = true;
            this.Close();

        }

 
    }
}
