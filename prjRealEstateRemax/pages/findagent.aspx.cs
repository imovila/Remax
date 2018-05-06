using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BAL;
using System.Data;

namespace prjRealEstateRemax.pages
{
    public partial class findagent : System.Web.UI.Page
    {

        public static DataTable tabAgent;
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int i;
                cboCityZone.DataSource = Enum.GetValues(typeof(enumCityzone));
                cboCityZone.DataBind();
                cboLanguage.DataSource = Enum.GetValues(typeof(enumLang));
                cboLanguage.DataBind();
                cboGender.DataSource = Enum.GetValues(typeof(enumGender));
                cboGender.DataBind();
                
                i = 0;
                foreach (var agent in Global.Agents.Elements)
                {
                    if (++i > 10)
                        break;
                    litInfoAgent.Text += "<div class='col-sm-6 col-md-3 p0'>";
                    litInfoAgent.Text += "<div class='box-two proerty-item'>";
                    litInfoAgent.Text += "<div class='item-thumb'>";
                    litInfoAgent.Text += "<a href = './agentdetails.aspx?aCode=" + agent.Code.ToString() + "'><img src='../" + Global.path + agent.Pic.Substring(21) + "' width: 355;/></a>";
                    litInfoAgent.Text += "</div><div class='item-entry overflow'>";
                    litInfoAgent.Text += "<h5><a href = './agentdetails.aspx?aCode=" + agent.Code.ToString() + "'>" + agent.Fullname.ToString() + "</a></h5>";
                    litInfoAgent.Text += "<div class='dot-hr'></div><span class='pull-left'><b>Language:&nbsp;&nbsp;</b>" + agent.Lang.ToString() + "</span>";
                    litInfoAgent.Text += "<span class='proerty-price pull-right'><b>Gender:&nbsp;&nbsp;</b>" + agent.Gender.ToString() + "</span></div></div></div>";
                }

                LitResTitle.Text = "Top Agents";

                dicToTable(Global.Agents);
            }
        }

        private void dicToTable(clsListEmployees listAgent)
        {
            tabAgent = new DataTable();
            tabAgent.Columns.Add("Code", listAgent.Elements.First().Code.GetType());
            tabAgent.Columns.Add("Fullname", listAgent.Elements.First().Fullname.GetType());
            tabAgent.Columns.Add("Gender", listAgent.Elements.First().Gender.GetType());
            tabAgent.Columns.Add("Lang", listAgent.Elements.First().Lang.GetType());
            tabAgent.Columns.Add("CityZone", listAgent.Elements.First().Cityzone.GetType());
            tabAgent.Columns.Add("Pic", listAgent.Elements.First().Pic.GetType());
            tabAgent.Columns.Add("ID", listAgent.Elements.First().ID.GetType());

            foreach (clsEmployee row in listAgent.Elements)
                tabAgent.Rows.Add(row.Code, row.Fullname, row.Gender, row.Lang, row.Cityzone, row.Pic, row.ID);
        }

        private void getFilterData()
        {
            string filter = "";
            bool check = false;
            litInfoAgent.Text = "";

            if (txtCode.Text != "")
            {
                filter += " code = '" + txtCode.Text + "'";
                check = true;
            }
            if (cboCityZone.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " cityzone = " + (int)Enum.Parse(typeof(enumCityzone), cboCityZone.SelectedItem.Text);
                check = true;
            }
            if (cboGender.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " gender = " + (int)Enum.Parse(typeof(enumGender), cboGender.SelectedItem.Text);
                check = true;
            }
            if (cboLanguage.SelectedIndex > 0)
            {
                filter += (check ? " and " : "") + " lang = " + (int)Enum.Parse(typeof(enumLang), cboLanguage.SelectedItem.Text);
                check = true;
            }

            DataRow[] rAgents = tabAgent.Select(filter);
            if (rAgents.Count() > 0)
            {
                LitResTitle.Text = "Number of agents found according to the criteria indicated: " + rAgents.Count().ToString();

                foreach (DataRow agent in rAgents)
                {
                    litInfoAgent.Text += "<div class='col-sm-6 col-md-3 p0'>";
                    litInfoAgent.Text += "<div class='box-two proerty-item'>";
                    litInfoAgent.Text += "<div class='item-thumb'>";
                    litInfoAgent.Text += "<a href = './agentdetails.aspx?aCode=" + agent["Code"].ToString() + "'><img src='../" + Global.path + agent["Pic"].ToString().Substring(21) + "'/></a>";
                    litInfoAgent.Text += "</div><div class='item-entry overflow'>";
                    litInfoAgent.Text += "<h5><a href = './agentdetails.aspx?aCode=" + agent["Code"].ToString() + "'>" + agent["Fullname"].ToString() + "</a></h5>";
                    litInfoAgent.Text += "<div class='dot-hr'></div><span class='pull-left'><b>Language:&nbsp;&nbsp;</b>" + (enumLang)Enum.Parse(typeof(enumLang), agent["Lang"].ToString()) + "</span>";
                    litInfoAgent.Text += "<span class='proerty-price pull-right'><b>Gender:&nbsp;&nbsp;</b>" + (enumGender)Enum.Parse(typeof(enumGender), agent["Gender"].ToString()) + "</span></div></div></div>";
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