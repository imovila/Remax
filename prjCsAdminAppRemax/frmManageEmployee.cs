using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using BAL;
using prjCsAdminAppRemax.App_Code;
using System.IO;

namespace prjCsAdminAppRemax
{
    public partial class frmManageEmployee : MetroFramework.Forms.MetroForm
    {

        private int curRow;
        private string action = "", pic = "";

        public frmManageEmployee()
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
            cboCityZone.SelectedIndex = 0;
            cboGender.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            cboLang.SelectedIndex = 0;
            picEmployee.Image = null;
        }

        private void getData()
        {
            //Refresh list of Employees
            clsGlobals.remax = new clsCompany("Remax Real Estate", clsDataSource.GetEmployees());

            gridEmployee.DataSource = clsGlobals.remax.Employees.Elements.AsEnumerable().ToList();
            gridEmployee.ClearSelection();
            gridEmployee.Columns["id"].Visible = false;
            gridEmployee.Columns["pic"].Visible = false;
            gridEmployee.Columns["houses"].Visible = false;

            titleHouseCount.Text = "Total number of employees : " + clsGlobals.remax.Employees.GetCount.ToString();

            ctrlEnabled(false);
            btnEnabled();
        }

        private void ctrlEnabled(bool enabled)
        {
            if (action != "modify")
                txtCode.Enabled = enabled;
            txtFullName.Enabled = txtPassword.Enabled = txtUserName.Enabled =
            cboCityZone.Enabled = cboGender.Enabled = cboLang.Enabled = cboType.Enabled = enabled;
        }

        private void btnEnabled(bool btnaction = true, bool btncommit = false)
        {
            btnAdd.Enabled = btnDelete.Enabled = btnModify.Enabled = btnaction;
            btnCancel.Enabled = btnSave.Enabled = btncommit;
        }

        private void showCurHouse()
        {
            if (gridEmployee.Rows[curRow].Cells["pic"].Value.ToString().Length != 0)
                picEmployee.Image = Image.FromFile(@gridEmployee.Rows[curRow].Cells["pic"].Value.ToString());
            else
                picEmployee.Image = null;
            txtCode.Text = gridEmployee.Rows[curRow].Cells["code"].Value.ToString();
            txtFullName.Text = gridEmployee.Rows[curRow].Cells["fullname"].Value.ToString();
            cboCityZone.Text = gridEmployee.Rows[curRow].Cells["cityzone"].Value.ToString().TrimEnd();
            cboGender.Text = gridEmployee.Rows[curRow].Cells["gender"].Value.ToString().TrimEnd();
            cboLang.Text = gridEmployee.Rows[curRow].Cells["lang"].Value.ToString().TrimEnd();
            cboType.Text = gridEmployee.Rows[curRow].Cells["Employeetype"].Value.ToString().TrimEnd();
            txtUserName.Text = gridEmployee.Rows[curRow].Cells["username"].Value.ToString();
            txtPassword.Text = gridEmployee.Rows[curRow].Cells["password"].Value.ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            curRow = 0;
            gridEmployee.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            curRow--;
            if (curRow < 0)
                curRow++;
            gridEmployee.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            curRow++;
            if (curRow == gridEmployee.Rows.Count)
                curRow--;
            gridEmployee.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            curRow = gridEmployee.Rows.Count - 1;
            gridEmployee.Rows[curRow].Selected = true;
            showCurHouse();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            action = "modify";
            ctrlEnabled(true);
            btnEnabled(false, true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            action = "add";
            ctrlEnabled(true);
            btnEnabled(false, true);
            clearCtrl(panEmpoyee);
            txtCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Employee (code: " + txtCode.Text + ") ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clsDataSource.deleteEmployee(clsGlobals.remax.Employees.Find(txtCode.Text).ID);
                clsGlobals.remax.Employees.Delete(txtCode.Text);
                getData();
                curRow = 0;
                gridEmployee.Rows[curRow].Selected = true;
                showCurHouse();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEnabled();
            ctrlEnabled(false);
            action = "";
            showCurHouse();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pic == "" && action == "add")
                    pic = @"..\..\..\DAL\App_Data\emppic\Noimage.jpg";
                if (pic == "" && action == "modify")
                    pic = gridEmployee.Rows[curRow].Cells["pic"].Value.ToString();

                clsEmployee tmpEmployee = new clsEmployee();
                tmpEmployee.ID = (int)gridEmployee.Rows[curRow].Cells["id"].Value;
                tmpEmployee.Code = txtCode.Text;
                tmpEmployee.Fullname = txtFullName.Text;
                tmpEmployee.Username = txtUserName.Text;
                tmpEmployee.Password = txtPassword.Text;
                tmpEmployee.Cityzone = (enumCityzone)Enum.Parse(typeof(enumCityzone), cboCityZone.SelectedItem.ToString());
                tmpEmployee.Lang = (enumLang)Enum.Parse(typeof(enumLang), cboLang.SelectedItem.ToString());
                tmpEmployee.Gender = (enumGender)Enum.Parse(typeof(enumGender), cboGender.SelectedItem.ToString());
                tmpEmployee.Employeetype = (enumEmployeeType)Enum.Parse(typeof(enumEmployeeType), cboType.SelectedItem.ToString());
                tmpEmployee.Pic = pic;

                if (action == "add")
                {
                    clsGlobals.remax.Employees.Add(tmpEmployee, txtCode.Text);
                    clsDataSource.insertEmployee(tmpEmployee.toInsert());
                    curRow = gridEmployee.Rows.Count;
                }
                if (action == "modify")
                {
                    clsGlobals.remax.Employees.Update(tmpEmployee, txtCode.Text);
                    clsDataSource.updateEmployee(tmpEmployee.ID, tmpEmployee.toUpdate());
                }

                tmpEmployee = null;
                pic = "";

                getData();
                gridEmployee.Rows[curRow].Selected = true;
                showCurHouse();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nPlease check you have entered the data correctly !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFind.Text))
            {
                foreach (DataGridViewRow row in gridEmployee.Rows)
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

        private void frmManageEmployee_Load(object sender, EventArgs e)
        {
            cboCityZone.DataSource = Enum.GetValues(typeof(enumCityzone));
            cboGender.DataSource = Enum.GetValues(typeof(enumGender));
            cboType.DataSource = Enum.GetValues(typeof(enumEmployeeType));
            cboLang.DataSource = Enum.GetValues(typeof(enumLang));

            getData();
            btnFirst.PerformClick();
        }

        private void gridEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridEmployee.Rows.Count > 0)
            {
                curRow = gridEmployee.CurrentRow.Index;
                showCurHouse();
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
                    File.Copy(@openFilePic.FileName, @"..\..\..\DAL\App_Data\emppic\" + pic);
                    //For Web
                    File.Copy(@openFilePic.FileName, @"..\..\..\prjRealEstateRemax\assets\img\emppic\" + pic);

                    pic = @"..\..\..\DAL\App_Data\emppic\" + pic;
                    picEmployee.Image = Image.FromFile(@pic);
                }
                catch
                {
                    MessageBox.Show("The file '" + pic + "' already exists. Rename file !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
