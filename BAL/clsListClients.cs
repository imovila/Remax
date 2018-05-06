using System.Collections.Generic;
using System.Linq;

namespace BAL
{
    public class clsListClients
    {
        private Dictionary<int, clsClient> myList;

        public clsListClients()
        {
            myList = new Dictionary<int, clsClient>();
        }

        public int GetCount
        {
            get
            {
                return myList.Count();
            }

        }

        public Dictionary<int, clsClient>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        public bool Update(clsClient obj, int ID)
        {
            if (!Exist(ID))
                return false;
            else
            {
                if (Delete(ID))
                {
                    myList.Add(ID, obj);
                    return true;
                }
                else
                    return false;
            }
        }

        public bool Add(clsClient obj, int ID)
        {
            if (Exist(ID))
                return false;
            else
            {
                myList.Add(ID, obj);
                return true;
            }
        }

        public bool Delete(int ID)
        {
            return myList.Remove(ID);
        }

        public clsClient Find(int ID)
        {
            if (Exist(ID))
                return myList[ID];
            else
                return null;
        }

        public bool Exist(int ID)
        {
            return myList.ContainsKey(ID);
        }
    }
}