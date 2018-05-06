using System;
using System.Data;
using System.Linq;

using prjCsAdminAppRemax.App_Code;
using BAL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjCsAdminAppRemax
{
    public partial class frmFindHouse : MetroFramework.Forms.MetroForm
    {

        private static DataTable houseTable;
        private int curRow;

        public frmFindHouse()
        {
            InitializeComponent();
        }

        private void dicToTable(clsListHouses listHouses)
        {
            houseTable = new DataTable();

            houseTable.Columns.Add("Code", listHouses.Elements.First().Code.GetType());
            houseTable.Columns.Add("Aria", listHouses.Elements.First().Aria.GetType());
            houseTable.Columns.Add("Rooms", listHouses.Elements.First().Rooms.GetType());
            houseTable.Columns.Add("Bathrooms", listHouses.Elements.First().Bathrooms.GetType());
            houseTable.Columns.Add("CityZone", listHouses.Elements.First().CityZone.GetType());
            houseTable.Columns.Add("Price", listHouses.Elements.First().Price.GetType());
            houseTable.Columns.Add("Type", listHouses.Elements.First().Type.GetType());
            houseTable.Columns.Add("Status", listHouses.Elements.First().Status.GetType());
            if ((int)clsGlobals.curEmployee.Employeetype != 2)
                houseTable.Columns.Add("Employee", listHouses.Elements.First().EmployeeID.GetType());

            foreach (clsHouse row in listHouses.Elements)
            {
                if ((int)clsGlobals.curEmployee.Employeetype != 2)
                    houseTable.Rows.Add(row.Code, row.Aria, row.Rooms, row.Bathrooms, row.CityZone, row.Price, row.Type, row.Status, row.EmployeeID);
                else
                    houseTable.Rows.Add(row.Code, row.Aria, row.Rooms, row.Bathrooms, row.CityZone, row.Price, row.Type, row.Status);
            }
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
            if (txtAria.Text != "")
            {
                filter += (check ? " and " : "") + " aria = " + txtAria.Text;
                check = true;
            }
            if (txtRooms.Text != "")
            {
                filter += (check ? " and " : "") + " rooms = " + txtRooms.Text;
                check = true;
            }
            if (txtBathrooms.Text != "")
            {
                filter += (check ? " and " : "") + " bathrooms = " + txtBathrooms.Text;
                check = true;
            }
            if (cboCityZone.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " cityzone = " + (int)cboCityZone.SelectedItem;
                check = true;
            }
            if (txtPriceFrom.Text != "")
            {
                filter += (check ? " and " : "") + " price >= " + txtPriceFrom.Text;
                check = true;
            }
            if (txtPriceTo.Text != "")
            {
                filter += (check ? " and " : "") + " price <= " + txtPriceTo.Text;
                check = true;
            }
            if (cboType.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " type = " + (int)cboType.SelectedItem;
                check = true;
            }
            if (cboStatus.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " status = " + (int)cboStatus.SelectedItem;
                check = true;
            }
            if ((int)clsGlobals.curEmployee.Employeetype != 2 && cboAgent.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " employee = " + (int)cboAgent.SelectedValue;
                check = true;
            }

            DataRow[] rHouses = houseTable.Select(filter);
            if (rHouses.Count() > 0)
                gridAgentHouses.DataSource = rHouses.CopyToDataTable();
            else
                gridAgentHouses.DataSource = null;

            if ((int)clsGlobals.curEmployee.Employeetype == 1)
                gridAgentHouses.Columns["Employee"].Visible = false;
            curRow = 0;
        }

        private DataTable getComboEmpName()
        {
            DataTable tmp = new DataTable();
            tmp.Columns.Add("id", typeof(int));
            tmp.Columns.Add("fullname", typeof(string));
            tmp.Rows.Add(0, "Unspecified");
            foreach (clsEmployee emp in clsGlobals.remax.Employees.Elements)
                tmp.Rows.Add(emp.ID, emp.Fullname);
            return tmp;
        }

        private void frmFindHouse_Load(object sender, EventArgs e)
        {
            cboCityZone.DataSource = Enum.GetValues(typeof(enumCityzone));
            cboStatus.DataSource = Enum.GetValues(typeof(enumHouseStatus));
            cboType.DataSource = Enum.GetValues(typeof(enumHouseType));

            if ((int)clsGlobals.curEmployee.Employeetype == 2)
            {
                cboAgent.Items.Add(clsGlobals.curEmployee.Fullname);
                cboAgent.Enabled = false;
            }
            else
            {
                cboAgent.DisplayMember = "fullname";
                cboAgent.ValueMember = "id";
                cboAgent.DataSource = getComboEmpName();
                cboAgent.Enabled = true;
            }
            cboAgent.SelectedIndex = 0;
            dicToTable(clsGlobals.curEmployee.Houses);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridAgentHouses.Rows[curRow].Selected = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridAgentHouses.Rows[curRow].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridAgentHouses.Rows.Count)
                curRow--;
            gridAgentHouses.Rows[curRow].Selected = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridAgentHouses.Rows.Count - 1;
            gridAgentHouses.Rows[curRow].Selected = true;
        }
    }
}
