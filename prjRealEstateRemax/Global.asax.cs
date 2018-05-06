using System;

using BAL;

namespace prjRealEstateRemax
{
    public class Global : System.Web.HttpApplication
    {
        public static clsListEmployees Agents = new clsListEmployees();
        public static clsListHouses Houses;
        public static string path = @"assets\img\";
        public static clsEmployee curEmployee;

        protected void Application_Start(object sender, EventArgs e)
        {
            //Get Remax Employees
            clsCompany remax = new clsCompany("Remax Real Estate", clsDataSource.GetEmployees());

            //Get all houses
            Houses = clsDataSource.getHouses();

            foreach (clsEmployee emp in clsDataSource.GetEmployees().Elements)
                if (emp.Employeetype == enumEmployeeType.Agent)
                {
                    foreach (clsHouse house in Houses.Elements)
                        if (emp.ID == house.EmployeeID)
                            emp.Houses.Add(house, house.Code);
                    Agents.Add(emp, emp.Code);
                }
        }
    }
}