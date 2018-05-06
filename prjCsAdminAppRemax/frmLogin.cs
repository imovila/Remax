using System;
using System.Linq;
using System.Windows.Forms;

using BAL;
using prjCsAdminAppRemax.App_Code;

namespace prjCsAdminAppRemax
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private bool required()
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || cboUserType.SelectedIndex == 0)
            {
                MessageBox.Show("Incorrect field validation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (required())
            {
                //Get Remax Employees
                clsGlobals.remax = new clsCompany("Remax Real Estate", clsDataSource.GetEmployees());
                //Get current employee
                clsEmployee curEmp = clsGlobals.remax.Employees.Find(txtUsername.Text, txtPassword.Text);

                if (curEmp != null)
                {
                    if ((int)curEmp.Employeetype == 2)
                        foreach (clsHouse house in clsDataSource.getHouses(curEmp.ID).Elements)
                            curEmp.Houses.Add(house);
                    if ((int)curEmp.Employeetype == 1)
                        foreach (clsHouse house in clsDataSource.getHouses().Elements)
                            curEmp.Houses.Add(house);

                    clsGlobals.curEmployee = curEmp;

                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                    lblErrorLogin.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboUserType.Items.Add("-- Choose user type --");
            foreach (string item in Enum.GetNames(typeof(enumEmployeeType)).ToList())
                cboUserType.Items.Add(item);
            cboUserType.SelectedIndex = 0;
        }


    }
}
