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
    public partial class frmSales : MetroFramework.Forms.MetroForm
    {

        private int curRow;

        public frmSales()
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
            dateSale.Value = DateTime.Today;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridForSales.Rows[curRow].Selected = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridForSales.Rows[curRow].Selected = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridForSales.Rows.Count)
                curRow--;
            gridForSales.Rows[curRow].Selected = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridForSales.Rows.Count - 1;
            gridForSales.Rows[curRow].Selected = true;
        }

        private void gridSales_MouseClick(object sender, MouseEventArgs e)
        {
            if (gridForSales.Rows.Count > 0)
                curRow = gridForSales.CurrentRow.Index;
        }

        private void getData()
        {
            clsListHouses Houses;
            if ((int)clsGlobals.curEmployee.Employeetype == 2)
                Houses = clsDataSource.getHousesForSales(clsGlobals.curEmployee.ID);
            else
                Houses = clsDataSource.getHousesForSales();

            gridForSales.DataSource = Houses.Elements.ToList();

            if (gridForSales.Rows.Count > 0)
            {
                gridForSales.Columns["id"].Visible = false;
                gridForSales.Columns["pic"].Visible = false;
                gridForSales.Columns["client"].Visible = false;
                gridForSales.Columns["employeeID"].Visible = false;
            }
            else
            {
                clearCtrl(panSale);
                gridForSales.DataSource = null;
            }
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set sales:\nHouse code: " + gridForSales.Rows[curRow].Cells["code"].Value.ToString() + 
                "\nFinal price: " + txtLastPrice.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsSale sale = new clsSale(0, Convert.ToSingle(txtEmpCommision.Text), Convert.ToSingle(txtLastPrice.Text), dateSale.Value.Date);
                clsDataSource.insertSale(sale.toInsert() + "," + gridForSales.Rows[curRow].Cells["id"].Value.ToString() + "," + clsGlobals.curEmployee.ID);
                sale = null;
                getData();
            }
        }
    }
}
