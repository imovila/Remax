using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BAL;

namespace prjRealEstateRemax.pages
{
    public partial class agentdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsEmployee selAgent = Global.Agents.Find(Request.QueryString["aCode"]);
                litCityZone.Text = litCityZoneTitle.Text = selAgent.Cityzone.ToString();
                litAgentName.Text = litAgentNameTitle.Text = selAgent.Fullname;
                litCode.Text = selAgent.Code;
                litGender.Text = selAgent.Gender.ToString();
                litLang.Text = selAgent.Lang.ToString();
                litPic.Text = "<img src='../" + Global.path + selAgent.Pic.Substring(21) + "' style='height: 250px; width: 250px; '/>";
                Global.curEmployee = selAgent;
            }

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            clsMessage msg = new clsMessage(Global.curEmployee.ID, txtMessage.Text.Replace("'", "''"));
            clsDataSource.insertMessage(msg.toInsert());
            txtMessage.Text = "";
        }
    }
}