namespace BAL
{
    public class clsCompany
    {
        private string vName;
        private clsListEmployees vEmployees;

        public string Name
        {
            get
            {
                return vName;
            }

            set
            {
                vName = value;
            }
        }

        public clsListEmployees Employees
        {
            get
            {
                return vEmployees;
            }

            set
            {
                vEmployees = value;
            }
        }

        public clsCompany(string vName, clsListEmployees vEmployees)
        {
            this.Name = vName;
            this.Employees = vEmployees;
        }
    }
}
