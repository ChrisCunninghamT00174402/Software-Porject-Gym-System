using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class frmMembers : Form
    {
        frmMainMenu parent;

        public frmMembers(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMemberReg frmNext = new frmMemberReg(this);

            this.Hide();
            frmNext.Show();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmChange frmNext = new frmChange(this);

            this.Hide();
            frmNext.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmCancel frmNext = new frmCancel(this);

            this.Hide();
            frmNext.Show();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            MemberList frmNext = new MemberList(this);

            this.Hide();
            frmNext.Show();

        }

        private void frmMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
