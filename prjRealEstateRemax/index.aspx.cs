using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BAL;
using System.IO;
using System.Data;

namespace prjRealEstateRemax
{
    public partial class index : System.Web.UI.Page
    {

        public static DataTable tabHouses;
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int i;
                cboHouseType.DataSource = Enum.GetValues(typeof(enumHouseType));
                cboHouseType.DataBind();
                cboCityZone.DataSource = Enum.GetValues(typeof(enumCityzone));
                cboCityZone.DataBind();
                cboStatus.DataSource = Enum.GetValues(typeof(enumHouseStatus));
                cboStatus.DataBind();
                cboStatus.Items.Remove("Sold");

                cboPriceFrom.Items.Add("Unspecified");
                for (i = 50000; i <= 1000000; i += 200000)
                    cboPriceFrom.Items.Add(i.ToString());
                cboPriceFrom.Items.Add("More");
                cboPriceTo.Items.Add("Unspecified");
                for (i = 50000; i <= 1000000; i += 200000)
                    cboPriceTo.Items.Add(i.ToString());

                cboRooms.Items.Add("Unspecified");
                for (i = 1; i <= 10; i++)
                    cboRooms.Items.Add(i.ToString());

                cboBathrooms.Items.Add("Unspecified");
                for (i = 1; i <= 10; i++)
                    cboBathrooms.Items.Add(i.ToString());

                foreach (var emp in Global.Agents.Elements)
                {
                    litInfoAgent.Text += "<div class='item'><div class='client-text'>";
                    litInfoAgent.Text += "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean congue consequat !</p>";
                    litInfoAgent.Text += "<h4><strong>" + emp.Fullname +", </strong><i>" + emp.Employeetype.ToString() + "</i></h4></div>";
                    litInfoAgent.Text += "<div class='client-face wow fadeInRight' data-wow-delay='.9s'>";
                    litInfoAgent.Text += "<img src = '" + Global.path + emp.Pic.Substring(21) + "' width='80' height='80'/></div></div>";
                }

                i = 0;
                foreach (var house in Global.Houses.Elements)
                {
                    if (++i > 10)
                        break;
                    litInfoHouse.Text += "<div class='col-sm-6 col-md-3 p0'>";
                    litInfoHouse.Text += "<div class='box-two proerty-item'>";
                    litInfoHouse.Text += "<div class='item-thumb'>";
                    litInfoHouse.Text += "<a href = 'pages/housedetails.aspx?hCode=" + house.Code + "'><img src='" + Global.path + house.Pic.Substring(21) + "'/></a>";
                    litInfoHouse.Text += "</div><div class='item-entry overflow'>";
                    litInfoHouse.Text += "<h5><a href = 'pages/housedetails.aspx?hCode=" + house.Code + "'> Super nice " + house.Type.ToString() + "</a></h5>";
                    litInfoHouse.Text += "<div class='dot-hr'></div><span class='pull-left'><b>Area:&nbsp;&nbsp;</b>" + house.Aria + "m</span>";
                    litInfoHouse.Text += "<span class='proerty-price pull-right'><b>Price:&nbsp;&nbsp;</b>" + house.Price + "&nbsp;CAD</span></div></div></div>";
                }

                LitResTitle.Text = "Top submitted property";

                dicToTable(Global.Houses);
            }

        }

        private void dicToTable(clsListHouses listHouses)
        {
            tabHouses = new DataTable();
            tabHouses.Columns.Add("Code", listHouses.Elements.First().Code.GetType());
            tabHouses.Columns.Add("Aria", listHouses.Elements.First().Aria.GetType());
            tabHouses.Columns.Add("Rooms", listHouses.Elements.First().Rooms.GetType());
            tabHouses.Columns.Add("Bathrooms", listHouses.Elements.First().Bathrooms.GetType());
            tabHouses.Columns.Add("CityZone", listHouses.Elements.First().CityZone.GetType());
            tabHouses.Columns.Add("Price", listHouses.Elements.First().Price.GetType());
            tabHouses.Columns.Add("Type", listHouses.Elements.First().Type.GetType());
            tabHouses.Columns.Add("Status", listHouses.Elements.First().Status.GetType());
            tabHouses.Columns.Add("Pic", listHouses.Elements.First().Pic.GetType());
            tabHouses.Columns.Add("Employee", listHouses.Elements.First().EmployeeID.GetType());

            foreach (clsHouse row in listHouses.Elements)
                tabHouses.Rows.Add(row.Code, row.Aria, row.Rooms, row.Bathrooms, row.CityZone, row.Price, row.Type, row.Status, row.Pic, row.EmployeeID);
        }

        private void getFilterData()
        {
            string filter = "";
            bool check = false;
            litInfoHouse.Text = "";

            if (cboCityZone.SelectedIndex > 0)
            {
                filter += " cityzone = " + (int)Enum.Parse(typeof(enumCityzone), cboCityZone.SelectedItem.Text);
                check = true;
            }
            if (cboRooms.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " rooms = " + Convert.ToInt32(cboRooms.SelectedItem.Text);
                check = true;
            }
            if (cboBathrooms.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " bathrooms = " + Convert.ToInt32(cboBathrooms.SelectedItem.Text);
                check = true;
            }
            if (cboPriceFrom.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " price >= " + (cboPriceFrom.SelectedItem.Text != "More" ? Convert.ToInt32(cboPriceFrom.SelectedItem.Text) : 1000000);
                check = true;
            }
            if (cboPriceTo.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " price <= " + Convert.ToInt32(cboPriceTo.SelectedItem.Text);
                check = true;
            }
            if (cboHouseType.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " type = " + (int)Enum.Parse(typeof(enumHouseType), cboHouseType.SelectedItem.Text);
                check = true;
            }
            if (cboStatus.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " status = " + (int)Enum.Parse(typeof(enumHouseStatus), cboStatus.SelectedItem.Text);
                check = true;
            }

            DataRow[] rHouses = tabHouses.Select(filter);
            if (rHouses.Count() > 0)
            {
                LitResTitle.Text = "Number of houses found according to the criteria indicated: " + rHouses.Count().ToString();

                foreach (DataRow house in rHouses)
                {
                    litInfoHouse.Text += "<div class='col-sm-6 col-md-3 p0'>";
                    litInfoHouse.Text += "<div class='box-two proerty-item'>";
                    litInfoHouse.Text += "<div class='item-thumb'>";
                    litInfoHouse.Text += "<a href = 'pages/housedetails.aspx?hCode=" + house["Code"].ToString() + "'><img src='" + Global.path + house["Pic"].ToString().Substring(21) + "'/></a>";
                    litInfoHouse.Text += "</div><div class='item-entry overflow'>";
                    litInfoHouse.Text += "<h5><a href = 'pages/housedetails.aspx?hCode=" + house["Code"].ToString() + "'>Super nice " + Enum.Parse(typeof(enumHouseType), house["Type"].ToString()) + "</a></h5>";
                    litInfoHouse.Text += "<div class='dot-hr'></div><span class='pull-left'><b>Area:&nbsp;&nbsp;</b>" + house["Aria"].ToString() + "m</span>";
                    litInfoHouse.Text += "<span class='proerty-price pull-right'><b>Price:&nbsp;&nbsp;</b>" + house["Price"].ToString() + "&nbsp;CAD</span>";
                    litInfoHouse.Text += "<div class='property-icon'>";
                    litInfoHouse.Text += "<img src = '../assets/img/icon/bed-orange.png'> (" + house["Rooms"].ToString() + ") |";
                    litInfoHouse.Text += "<img src='../assets/img/icon/shawer-orange.png'> (" + house["Bathrooms"].ToString() + "|</div></div></div></div>";
                }
            }
            else
                LitResTitle.Text = "No data was found according to the criteria specified.";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            getFilterData();
        }
    }
}