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
using MetroFramework;

namespace prjCsAdminAppRemax
{
    public partial class frmLinkClientHouse : MetroFramework.Forms.MetroForm
    {

        private int curRow;
        private static clsListClients Clients;
        private static clsListHouses Houses;

        public frmLinkClientHouse()
        {
            InitializeComponent();
        }

        private void clearCtrl(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
            }
            cboClients.DataSource = null;
        }

        private void getData()
        {
            Clients = clsDataSource.getClientsNeedConnectToHouse();

            if ((int)clsGlobals.curEmployee.Employeetype == 2)
            {
                Houses = clsDataSource.getHousesNeedConnectToClient(clsGlobals.curEmployee.ID);
                titleHouseToLink.Text = "You have " + Houses.GetCount.ToString() + " houses to link";
            }
            else
            {
                Houses = clsDataSource.getHousesNeedConnectToClient();
                titleHouseToLink.Text = "Total houses requiring a link to client: " + Houses.GetCount.ToString();
            }

            gridHousesToClient.DataSource = Houses.Elements.AsEnumerable().ToList();
            gridHousesToClient.Columns["ID"].Visible = false;
            gridHousesToClient.Columns["Pic"].Visible = false;
            gridHousesToClient.Columns["Client"].Visible = false;

            cboClients.ValueMember = "id";
            cboClients.DisplayMember = "fullname";
            cboClients.DataSource = Clients.Elements.ToList();

            if (gridHousesToClient.Rows.Count == 0)
            {
                clearCtrl(panLink);
                if ((int)clsGlobals.curEmployee.Employeetype == 2)
                {
                    clsGlobals.curEmployee.Houses.Clear();
                    foreach (clsHouse house in clsDataSource.getHouses(clsGlobals.curEmployee.ID).Elements)
                        clsGlobals.curEmployee.Houses.Add(house);
                }
            }
        }

        private void frmLinkClientHouse_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void cboClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClients.SelectedIndex >= 0)
            {
                var clRes = from clsClient cl in Clients.Elements.ToList()
                            where cl.ID == Convert.ToInt32(cboClients.SelectedValue.ToString())
                            select cl;
                txtEmail.Text = clRes.First().Email;
                txtPhone.Text = clRes.First().Phone;
                txtType.Text = Enum.GetName(typeof(enumClientType), clRes.First().Type);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridHousesToClient.Rows[curRow].Selected = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridHousesToClient.Rows[curRow].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridHousesToClient.Rows.Count)
                curRow--;
            gridHousesToClient.Rows[curRow].Selected = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridHousesToClient.Rows.Count - 1;
            gridHousesToClient.Rows[curRow].Selected = true;
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are sure you want to join: \n\n\tClient: " + cboClients.SelectedItem.ToString() + 
                "\nto\n\n\tHouse: code " + gridHousesToClient.Rows[curRow].Cells["code"].Value.ToString(), 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsDataSource.joinHouseToClient(Convert.ToInt32(gridHousesToClient.Rows[curRow].Cells["id"].Value.ToString()),
                                                Convert.ToInt32(cboClients.SelectedValue.ToString()));
                getData();
            }
        }

        private void gridHousesToClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridHousesToClient.Rows.Count > 0)
                curRow = gridHousesToClient.CurrentRow.Index;
        }
    }
}
