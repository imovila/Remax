using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class clsMessage
    {
        private int vID;
        private int vEmployee;
        private string vMessage;
        private Byte vStatus;
        private DateTime vMessageDate;

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

        public int Employee
        {
            get
            {
                return vEmployee;
            }

            set
            {
                vEmployee = value;
            }
        }

        public string Message
        {
            get
            {
                return vMessage;
            }

            set
            {
                vMessage = value;
            }
        }

        public byte Status
        {
            get
            {
                return vStatus;
            }

            set
            {
                vStatus = value;
            }
        }

        public DateTime MessageDate
        {
            get
            {
                return vMessageDate;
            }

            set
            {
                vMessageDate = value;
            }
        }

        public clsMessage(int ID, int Employee, string Message, byte Status, DateTime MessageDate)
        {
            this.ID = ID;
            this.Employee = Employee;
            this.Message = Message;
            this.Status = Status;
            this.MessageDate = MessageDate;
        }

        public clsMessage(int Employee, string Message)
        {
            this.Employee = Employee;
            this.Message = Message;
        }

        public string toInsert()
        {
            StringBuilder list = new StringBuilder();
            list.Append(Employee + ",");
            list.Append("'" + Message + "'");
            return list.ToString();
        }

    }
}
