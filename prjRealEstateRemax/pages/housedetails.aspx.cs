using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BAL;

namespace prjRealEstateRemax.pages
{
    public partial class housedetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsHouse selHouse = Global.Houses.Find(Request.QueryString["hCode"]);
                litCityZone.Text = litCityZoneTitle.Text = selHouse.CityZone.ToString();
                litHouseType.Text = litHouseTypeTitle.Text = selHouse.Type.ToString();
                litAria.Text = selHouse.Aria.ToString();
                litHouseStatus.Text = selHouse.Status.ToString();
                litPrice.Text = selHouse.Price.ToString();
                litRooms.Text = selHouse.Rooms.ToString();
                litBathrooms.Text = selHouse.Bathrooms.ToString();
                litDescription.Text = selHouse.Description;
                litAddress.Text = selHouse.Address;
                litDate.Text = selHouse.Datein.ToShortDateString();
                litPic.Text = "<img src='../" + Global.path + selHouse.Pic.Substring(21) + "' style='height: 425px; width: 750px; '/>";

                foreach (clsEmployee emp in Global.Agents.Elements)
                    if (emp.Houses.Find(selHouse.Code) == selHouse)
                    {
                        litAgentPic.Text = "<img src = '../" + Global.path +  emp.Pic.Substring(21) + "' class='img-circle'>";
                        litAgenName.Text = emp.Fullname;
                        Global.curEmployee = emp;
                        break;
                    }
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