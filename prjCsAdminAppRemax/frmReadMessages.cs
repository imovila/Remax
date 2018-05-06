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
    public partial class frmReadMessages : MetroFramework.Forms.MetroForm
    {

        private static clsListMessages Messages;

        public frmReadMessages()
        {
            InitializeComponent();
        }

        private void getMessages()
        {
            Messages = clsDataSource.getMessages(clsGlobals.curEmployee.ID);

            gridMessages.DataSource = Messages.Elements.Select(msg => new
            {
                ID = msg.ID,
                Message = msg.Message,
                Date = msg.MessageDate,
                Status = msg.Status
            }).ToList();

            gridMessages.Columns["ID"].Visible = false;
            gridMessages.Columns["Status"].Visible = false;
        }

        private void frmReadMessages_Load(object sender, EventArgs e)
        {
            getMessages();
       
            titleMessageCount.Text = "You have " + Messages.GetCount + " unread messages";
        }

        private void gridMessages_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMessage.Text = gridMessages.Rows[e.RowIndex].Cells["Message"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridMessages.Rows.Count > 0)
            {
                if (MessageBox.Show("Delete this message ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    clsDataSource.deleteMessage(Convert.ToByte(gridMessages.Rows[gridMessages.CurrentCell.RowIndex].Cells["ID"].Value));
                    getMessages();
                    txtMessage.Clear();
                }
            }
            else
                MessageBox.Show("There are no messages to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
