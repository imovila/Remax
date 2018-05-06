using System.Collections.Generic;
using System.Linq;

namespace BAL
{
    public class clsListMessages
    {
        private Dictionary<int, clsMessage> myList;

        public clsListMessages()
        {
            myList = new Dictionary<int, clsMessage>();
        }

        public int GetCount
        {
            get
            {
                return myList.Count();
            }

        }

        public Dictionary<int, clsMessage>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        public bool Update(clsMessage obj, int ID)
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

        public bool Add(clsMessage obj, int ID)
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

        public clsMessage Find(int ID)
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
