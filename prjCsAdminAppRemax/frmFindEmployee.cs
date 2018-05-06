using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BAL;
using prjCsAdminAppRemax.App_Code;

namespace prjCsAdminAppRemax
{
    public partial class frmFindEmployee : MetroFramework.Forms.MetroForm
    {
        private static DataTable empTable;
        private int curRow;

        public frmFindEmployee()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridEmployee.Rows[curRow].Selected = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridEmployee.Rows[curRow].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridEmployee.Rows.Count)
                curRow--;
            gridEmployee.Rows[curRow].Selected = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridEmployee.Rows.Count - 1;
            gridEmployee.Rows[curRow].Selected = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filter = "";
            bool check = false;

            if (txtCode.Text != "")
            {
                filter = "code = " + txtCode.Text;
                check = true;
            }
            if (txtFullName.Text != "")
            {
                filter += (check ? " and " : "") + " fullname Like '%" + txtFullName.Text + "%'";
                check = true;
            }
            if (cboGender.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " gender = " + (int)cboGender.SelectedItem;
                check = true;
            }
            if (cboLanguage.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " lang = " + (int)cboLanguage.SelectedItem;
                check = true;
            }
            if (cboCityZone.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " cityzone = " + (int)cboCityZone.SelectedItem;
                check = true;
            }
            if (cboType.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " type = " + (int)cboType.SelectedItem;
                check = true;
            }

            DataRow[] rEmp = empTable.Select(filter);
            if (rEmp.Count() > 0)
                gridEmployee.DataSource = rEmp.CopyToDataTable();
            else
                gridEmployee.DataSource = null;

            curRow = 0;
        }

        private void dicToTable(clsListEmployees listEmp)
        {
            empTable = new DataTable();

            empTable.CaseSensitive = false;

            empTable.Columns.Add("Code", listEmp.Elements.First().Code.GetType());
            empTable.Columns.Add("Fullname", listEmp.Elements.First().Fullname.GetType());
            empTable.Columns.Add("Gender", listEmp.Elements.First().Gender.GetType());
            empTable.Columns.Add("Lang", listEmp.Elements.First().Lang.GetType());
            empTable.Columns.Add("CityZone", listEmp.Elements.First().Cityzone.GetType());
            empTable.Columns.Add("Type", listEmp.Elements.First().Employeetype.GetType());
            empTable.Columns.Add("Username", listEmp.Elements.First().Username.GetType());
            empTable.Columns.Add("Password", listEmp.Elements.First().Password.GetType());

            foreach (clsEmployee row in listEmp.Elements)
                empTable.Rows.Add(row.Code, row.Fullname, row.Gender, row.Lang, row.Cityzone, row.Employeetype, row.Username, row.Password);
        }

        private void frmFindEmployee_Load(object sender, EventArgs e)
        {
            cboCityZone.DataSource = Enum.GetValues(typeof(enumCityzone));
            cboGender.DataSource = Enum.GetValues(typeof(enumGender));
            cboLanguage.DataSource = Enum.GetValues(typeof(enumLang));

            cboType.Items.Add("Unspecified");
            foreach (var item in Enum.GetValues(typeof(enumEmployeeType)))
                cboType.Items.Add(item);
            cboType.SelectedIndex = 0;
            dicToTable(clsGlobals.remax.Employees);
        }
    }
}