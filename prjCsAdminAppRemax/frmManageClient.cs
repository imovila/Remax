using System;
using System.Drawing;
using System.Windows.Forms;

using BAL;
using prjCsAdminAppRemax.App_Code;
using System.Linq;

namespace DAL
{
    public partial class frmManageClient : MetroFramework.Forms.MetroForm
    {

        private int curRow;
        private string action = "";
        private clsListClients Clients = new clsListClients();

        public frmManageClient()
        {
            InitializeComponent();
        }

        private void ctrlEnabled(bool enabled)
        {
            txtFullName.Enabled = txtPhone.Enabled = txtEmail.Enabled = cboType.Enabled = enabled;
        }

        private void btnEnabled(bool btnaction = true, bool btncommit = false)
        {
            btnAdd.Enabled = btnDelete.Enabled = btnModify.Enabled = btnaction;
            btnCancel.Enabled = btnSave.Enabled = btncommit;
        }

        private void frmManageClient_Load(object sender, EventArgs e)
        {
            foreach (clsHouse house in clsGlobals.curEmployee.Houses.Elements)
                if (house.Client != null)
                    Clients.Add(house.Client, house.Client.ID);
            getData();
            btnFirst.PerformClick();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridClient.Rows[curRow].Selected = true;
            showCurClient();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridClient.Rows[curRow].Selected = true;
            showCurClient();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridClient.Rows.Count)
                curRow--;
            gridClient.Rows[curRow].Selected = true;
            showCurClient();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridClient.Rows.Count - 1;
            gridClient.Rows[curRow].Selected = true;
            showCurClient();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            action = "modify";
            ctrlEnabled(true);
            btnEnabled(false, true);
        }

        private void getData()
        {
            gridClient.DataSource = Clients.Elements.AsEnumerable().ToList();
            gridClient.ClearSelection();
            gridClient.Columns["id"].Visible = false;
            gridClient.Columns["houses"].Visible = false;

            if ((int)clsGlobals.curEmployee.Employeetype == 2)
                titleClientCount.Text = "You have " + Clients.GetCount.ToString() + " clients";
            else
                titleClientCount.Text = "Total number of clients: " + Clients.GetCount.ToString();

            cboType.DataSource = Enum.GetValues(typeof(enumClientType));

            ctrlEnabled(false);
            btnEnabled();
        }

        private void showCurClient()
        {
            if (gridClient.Rows.Count > 0)
            {
                txtFullName.Text = gridClient.Rows[curRow].Cells["fullname"].Value.ToString();
                txtPhone.Text = gridClient.Rows[curRow].Cells["phone"].Value.ToString();
                txtEmail.Text = gridClient.Rows[curRow].Cells["email"].Value.ToString();
                cboType.Text = gridClient.Rows[curRow].Cells["type"].Value.ToString().TrimEnd();
            }
            else
            {
                gridClient.DataSource = null;
                clearCtrl(panClient);
            }
        }

        private void clearCtrl(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
            }
            cboType.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEnabled();
            ctrlEnabled(false);
            action = "";
            showCurClient();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this item ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsDataSource.deleteClient(Convert.ToInt32(gridClient.Rows[curRow].Cells["id"].Value.ToString()));
                Clients.Delete(Convert.ToInt32(gridClient.Rows[curRow].Cells["id"].Value.ToString()));
                getData();
                curRow = 0;
                if (gridClient.Rows.Count > 0)
                    gridClient.Rows[curRow].Selected = true;
                showCurClient();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "add";
            ctrlEnabled(true);
            btnEnabled(false, true);
            clearCtrl(panClient);
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                clsClient tmpClient = new clsClient();
                if (action != "add")
                    tmpClient.ID = (int)gridClient.Rows[curRow].Cells["id"].Value;
                tmpClient.Fullname = txtFullName.Text;
                tmpClient.Email = txtEmail.Text;
                tmpClient.Phone = txtPhone.Text;
                tmpClient.Type = (enumClientType)Enum.Parse(typeof(enumClientType), cboType.SelectedItem.ToString());

                if (action == "add")
                {
                    Clients.Add(tmpClient, tmpClient.ID);
                    clsDataSource.insertClient(tmpClient.toInsert());
                    curRow = gridClient.Rows.Count;
                }
                if (action == "modify")
                {
                    Clients.Update(tmpClient, tmpClient.ID);
                    clsDataSource.updateClient(tmpClient.ID, tmpClient.toUpdate());
                }

                tmpClient = null;

                getData();
                gridClient.Rows[curRow].Selected = true;
                showCurClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nPlease check you have entered the data correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridClient.Rows.Count > 0)
            {
                curRow = gridClient.CurrentRow.Index;
                showCurClient();
            }
        }
    }
}
