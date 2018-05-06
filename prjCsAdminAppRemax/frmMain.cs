using System;
using System.Drawing;
using System.Windows.Forms;

using prjCsAdminAppRemax.App_Code;
using DAL;

namespace prjCsAdminAppRemax
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void hideMenu()
        {
            if ((int)clsGlobals.curEmployee.Employeetype == 2)
                employeeToolStripMenuItem.Enabled = false;
            if ((int)clsGlobals.curEmployee.Employeetype == 1)
                messageToolStripMenuItem.Enabled = false;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            statusInfo.Items[0].Text += ": " + Application.ProductVersion.ToString();
            statusInfo.Items[1].Text += "User type:" + clsGlobals.curEmployee.Employeetype.ToString().PadLeft(10);
            tileUser.Text = "Welcome back to Remax " + ((int)clsGlobals.curEmployee.Gender == 1 ? "Ms. " : 
                            (int)clsGlobals.curEmployee.Gender == 2 ? "Mr. " : "") + clsGlobals.curEmployee.Fullname;
            if (clsGlobals.curEmployee.Pic.Length != 0)
                picEmployee.Image = Image.FromFile(@clsGlobals.curEmployee.Pic);
            else
                picEmployee.Visible = false;
            hideMenu();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin frl = new frmLogin();
                this.Hide();
                frl.ShowDialog();
                this.Close();
            }

        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageHouse frmf = new frmManageHouse();
            frmf.MdiParent = this;
            frmf.Show();
        }

        private void findHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindHouse frmfh = new frmFindHouse();
            frmfh.MdiParent = this;
            frmfh.Show();
        }

        private void searchAgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageClient frmmc = new frmManageClient();
            frmmc.MdiParent = this;
            frmmc.Show();
        }

        private void linkToHouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkClientHouse frml = new frmLinkClientHouse();
            frml.MdiParent = this;
            frml.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales frml = new frmSales();
            frml.MdiParent = this;
            frml.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageEmployee frme = new frmManageEmployee();
            frme.MdiParent = this;
            frme.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindEmployee frmfe = new frmFindEmployee();
            frmfe.MdiParent = this;
            frmfe.Show();
        }

        private void readMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReadMessages frmrm = new frmReadMessages();
            frmrm.MdiParent = this;
            frmrm.Show();
        }
    }
}
