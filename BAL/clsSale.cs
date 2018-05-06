using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class clsSale
    {
        private int vID;
        private float vEmpCommision;
        private float vLastPrice;
        private DateTime vSaleDate;

        public int ID
        {
            get
            {
                return vID;
            }

            set
            {
                vID = value;
            }
        }

        public float EmpCommision
        {
            get
            {
                return vEmpCommision;
            }

            set
            {
                vEmpCommision = value;
            }
        }

        public float LastPrice
        {
            get
            {
                return vLastPrice;
            }

            set
            {
                vLastPrice = value;
            }
        }

        public DateTime SaleDate
        {
            get
            {
                return vSaleDate;
            }

            set
            {
                vSaleDate = value;
            }
        }

        public clsSale(int ID, float EmpCommision, float LastPrice, DateTime SaleDate)
        {
            this.ID = ID;
            this.EmpCommision = EmpCommision;
            this.LastPrice = LastPrice;
            this.SaleDate = SaleDate;
        }

        public string toInsert()
        {
            StringBuilder list = new StringBuilder();
            list.Append(EmpCommision.ToString() + ",");
            list.Append(LastPrice.ToString() + ",");
            list.Append("'" + SaleDate.ToString() + "'");
            return list.ToString();
        }

    }
}
