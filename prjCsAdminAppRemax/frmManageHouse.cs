using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using prjCsAdminAppRemax.App_Code;
using BAL;
using System.IO;

namespace prjCsAdminAppRemax
{
    public partial class frmManageHouse : MetroFramework.Forms.MetroForm
    {
        private int curRow;
        private string action = "", pic = "";

        public frmManageHouse()
        {
            InitializeComponent();
        }

        private void ctrlEnabled(bool enabled)
        {
            if (action != "modify")
                txtCode.Enabled = enabled;
            txtAria.Enabled = txtRooms.Enabled = txtBathrooms.Enabled =
            cboCityZone.Enabled = txtAddress.Enabled = txtPrice.Enabled = 
            txtDescription.Enabled = cboType.Enabled = cboStatus.Enabled =
            btnBrowse.Enabled = cboAgent.Enabled = enabled;
        }

        private void btnEnabled(bool btnaction = true, bool btncommit = false)
        {
            btnAdd.Enabled = btnDelete.Enabled = btnModify.Enabled = btnaction;
            btnCancel.Enabled = btnSave.Enabled = btncommit;
        }

        private void clearCtrl(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox && ((TextBox)ctrl).Name != "txtAgent")
                    ((TextBox)ctrl).Clear();
            }
            cboCityZone.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            cboAgent.SelectedIndex = 0;
            picHouse.Image = null;
        }

        private void getData()
        {
            gridAgentHouses.DataSource = clsGlobals.curEmployee.Houses.Elements.AsEnumerable().ToList();
            gridAgentHouses.ClearSelection();
            gridAgentHouses.Columns["id"].Visible = false;
            gridAgentHouses.Columns["pic"].Visible = false;
            gridAgentHouses.Columns["employeeID"].Visible = false;

            if ((int)clsGlobals.curEmployee.Employeetype == 2)
                titleHouseCount.Text = "You have " + clsGlobals.curEmployee.Houses.GetCount.ToString() + " houses";
            else
                titleHouseCount.Text = "Total number of houses : " + clsGlobals.curEmployee.Houses.GetCount.ToString();

            cboCityZone.DataSource = Enum.GetValues(typeof(enumCityzone));
            cboStatus.DataSource = Enum.GetValues(typeof(enumHouseStatus));
            cboType.DataSource = Enum.GetValues(typeof(enumHouseType));

            ctrlEnabled(false);
            btnEnabled();
        }

        private void frmFindHouse_Load(object sender, EventArgs e)
        {
            if ((int)clsGlobals.curEmployee.Employeetype == 2)
            {
                cboAgent.Visible = false;
                txtAgent.Visible = true;
            }
            else
            {
                cboAgent.DisplayMember = "fullname";
                cboAgent.ValueMember = "id";
                cboAgent.DataSource = clsGlobals.remax.Employees.Elements.ToList();
                cboAgent.Visible = true;
                txtAgent.Visible = false;
            }
            getData();
            btnFirst.PerformClick();
        }

        private void showCurHouse()
        {
            txtAgent.Text = clsGlobals.curEmployee.Fullname;

            if ((int)clsGlobals.curEmployee.Employeetype == 2 && clsGlobals.curEmployee.Pic.Length != 0)
                picAgent.Image = Image.FromFile(@clsGlobals.curEmployee.Pic);
            else
                picAgent.Image = Image.FromFile(@"..\..\..\DAL\App_Data\emppic\Noimage.jpg");

            if (gridAgentHouses.Rows[curRow].Cells["pic"].Value.ToString().Length != 0)
                picHouse.Image = Image.FromFile(@gridAgentHouses.Rows[curRow].Cells["pic"].Value.ToString());
            else
                picHouse.Image = Image.FromFile(@"..\..\..\DAL\App_Data\housepic\Noimage.jpg");

            txtCode.Text = gridAgentHouses.Rows[curRow].Cells["code"].Value.ToString();
            txtAria.Text = gridAgentHouses.Rows[curRow].Cells["aria"].Value.ToString();
            txtRooms.Text = gridAgentHouses.Rows[curRow].Cells["rooms"].Value.ToString();
            txtBathrooms.Text = gridAgentHouses.Rows[curRow].Cells["bathrooms"].Value.ToString();
            txtAria.Text = gridAgentHouses.Rows[curRow].Cells["aria"].Value.ToString();
            cboCityZone.Text = gridAgentHouses.Rows[curRow].Cells["cityzone"].Value.ToString().TrimEnd();
            txtAddress.Text = gridAgentHouses.Rows[curRow].Cells["address"].Value.ToString();
            txtPrice.Text = gridAgentHouses.Rows[curRow].Cells["price"].Value.ToString();
            txtDescription.Text = gridAgentHouses.Rows[curRow].Cells["description"].Value.ToString();
            cboType.Text = gridAgentHouses.Rows[curRow].Cells["type"].Value.ToString().TrimEnd();
            cboStatus.Text = gridAgentHouses.Rows[curRow].Cells["status"].Value.ToString().TrimEnd();

            if ((int)clsGlobals.curEmployee.Employeetype == 1)
            {
                string empPIC = "";
                foreach (clsEmployee emp in clsGlobals.remax.Employees.Elements)
                {
                    foreach (clsHouse h in clsGlobals.curEmployee.Houses.Elements)
                    {
                        if (emp.ID == h.EmployeeID && h.Code == txtCode.Text)
                        {
                            empPIC = emp.Pic;
                            cboAgent.SelectedValue = emp.ID;
                            break;
                        }
                    }
                }
                if (empPIC.ToString().Length > 0)
                    picAgent.Image = Image.FromFile(@empPIC.ToString());
                else
                    cboAgent.SelectedValue = -1;
            }
        }

        private void gridAgentHouses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridAgentHouses.Rows.Count > 0)
            {
                curRow = gridAgentHouses.CurrentRow.Index;
                showCurHouse();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridAgentHouses.Rows.Count - 1;
            gridAgentHouses.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridAgentHouses.Rows.Count)
                curRow--;
            gridAgentHouses.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridAgentHouses.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridAgentHouses.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                foreach (DataGridViewRow row in gridAgentHouses.Rows)
                {
                    if (row.Cells["code"].Value.ToString() == txtFind.Text)
                    {
                        row.Selected = true;
                        curRow = row.Index;
                        showCurHouse();
                        txtFind.Clear();
                        txtFind.Focus();
                        break;
                    }
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            action = "modify";
            ctrlEnabled(true);
            btnEnabled(false, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEnabled();
            ctrlEnabled(false);
            action = "";
            showCurHouse();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsDataSource.deleteHouse(clsGlobals.curEmployee.Houses.Find(txtCode.Text).ID);
                clsGlobals.curEmployee.Houses.Delete(txtCode.Text);
                getData();
                curRow = 0;
                gridAgentHouses.Rows[curRow].Selected = true;
                showCurHouse();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "add";
            ctrlEnabled(true);
            btnEnabled(false, true);
            clearCtrl(panHouse);
            txtCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pic == "" && action == "add")
                    pic = @"..\..\..\DAL\App_Data\housepic\Noimage.jpg";
                if (pic == "" && action == "modify")
                    pic = gridAgentHouses.Rows[curRow].Cells["pic"].Value.ToString();

                clsHouse tmpHouse = new clsHouse();
                tmpHouse.ID = (int)gridAgentHouses.Rows[curRow].Cells["id"].Value;
                tmpHouse.Code = txtCode.Text;
                tmpHouse.Aria = Convert.ToSingle(txtAria.Text);
                tmpHouse.Rooms = Convert.ToByte(txtRooms.Text);
                tmpHouse.Bathrooms = Convert.ToByte(txtBathrooms.Text);
                tmpHouse.CityZone = (enumCityzone)Enum.Parse(typeof(enumCityzone), cboCityZone.SelectedItem.ToString());
                tmpHouse.Address = txtAddress.Text;
                tmpHouse.Price = Convert.ToSingle(txtPrice.Text);
                tmpHouse.Description = txtDescription.Text;
                tmpHouse.Type = (enumHouseType)Enum.Parse(typeof(enumHouseType), cboType.SelectedItem.ToString());
                tmpHouse.Pic = pic;
                tmpHouse.Status = (enumHouseStatus)Enum.Parse(typeof(enumHouseStatus), cboStatus.SelectedItem.ToString());
                tmpHouse.Datein = DateTime.Today;

                if ((int)clsGlobals.curEmployee.Employeetype == 1)
                    tmpHouse.EmployeeID = Convert.ToInt32(cboAgent.SelectedValue.ToString());

                if (action == "add")
                {
                    clsGlobals.curEmployee.Houses.Add(tmpHouse, txtCode.Text);
                    clsDataSource.insertHouse(clsGlobals.curEmployee.ID, tmpHouse.toInsert());
                    curRow = gridAgentHouses.Rows.Count;
                }
                if (action == "modify")
                {
                    clsGlobals.curEmployee.Houses.Update(tmpHouse, txtCode.Text);
                    clsDataSource.updateHouse(tmpHouse.ID, tmpHouse.toUpdate());
                }

                tmpHouse = null;
                pic = "";

                getData();
                gridAgentHouses.Rows[curRow].Selected = true;
                showCurHouse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nPlease check you have entered the data correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFilePic.FileName = "";
            if (openFilePic.ShowDialog() == DialogResult.OK)
            {
                pic = Path.GetFileName(openFilePic.FileName);
                try
                {
                    //For Win
                    File.Copy(@openFilePic.FileName, @"..\..\..\DAL\App_Data\housepic\" + pic);
                    //For Web
                    File.Copy(@openFilePic.FileName, @"..\..\..\prjRealEstateRemax\assets\img\housepic\" + pic);

                    pic = @"..\..\..\DAL\App_Data\housepic\" + pic;
                    picHouse.Image = Image.FromFile(@pic);
                }
                catch
                {
                    MessageBox.Show("The file '" + pic + "' already exists. Rename file !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
