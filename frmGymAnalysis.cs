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
    public partial class frmAnalysis : Form
    {
        frmAdmin parent;
        Plans newPlan = new Plans();
        Member newMember = new Member();

        public frmAnalysis(frmAdmin Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }

        private void frmAnalysis_Load(object sender, EventArgs e)
        {

            //invokes methods to display the counts.

            txtNoMembers.Text = newPlan.showMember().ToString("000");
            txtMemberProfiles.Text = newPlan.showProfiles().ToString("000");
            txtFemale.Text = newPlan.showFemale().ToString("000");
            txtMale.Text = newPlan.showMale().ToString("000");



            //connect to database

            OracleConnection myConn = new OracleConnection(DBConnect.oradbITT);

            //define the sql query

            String strSQL = "SELECT Date_Registered ,Surname,Forename FROM Members ORDER BY DATE_REGISTERED";

            //oracle command 

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            myConn.Open();

            //create an OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Members");
            grpAnalysis.DataSource = ds.Tables["Members"];
            myConn.Close();


        }

      
    }
}
