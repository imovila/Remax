using System.Collections.Generic;
using System.Linq;

namespace BAL
{
    public class clsListEmployees
    {
        private Dictionary<string, clsEmployee> myList;

        public clsListEmployees()
        {
            myList = new Dictionary<string, clsEmployee>();
        }

        public int GetCount
        {
            get
            {
                return myList.Count();
            }

        }

        public Dictionary<string, clsEmployee>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        public bool Add(clsEmployee obj, string code)
        {
            if (Exist(code))
                return false;
            else
            {
                myList.Add(code, obj);
                return true;
            }
        }

        public bool Update(clsEmployee obj, string code)
        {
            if (!Exist(code))
                return false;
            else
            {
                if (Delete(code))
                {
                    myList.Add(code, obj);
                    return true;
                }
                else
                    return false;
            }
        }

        public bool Delete(string code)
        {
            return myList.Remove(code);
        }

        public clsEmployee Find(string code)
        {
            if (Exist(code))
                return myList[code];
            else
                return null;
        }

        public clsEmployee Find(string uname, string pwd)
        {
            foreach (KeyValuePair<string, clsEmployee> item in myList)
            {
                if (item.Value.Username == uname && item.Value.Password == pwd)
                    return item.Value;
            }
            return null;
        }

        public bool Exist(string code)
        {
            return myList.ContainsKey(code);
        }
    }
}