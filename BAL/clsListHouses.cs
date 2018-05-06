using System.Collections.Generic;
using System.Linq;

namespace BAL
{
    public class clsListHouses
    {
        private Dictionary<string, clsHouse> myList;

        public clsListHouses()
        {
            myList = new Dictionary<string, clsHouse>();
        }

        public int GetCount
        {
            get
            {
                return myList.Count();
            }

        }

        public Dictionary<string, clsHouse>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        public bool Update(clsHouse obj, string code)
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

        public bool Add(clsHouse obj, string code)
        {
            if (Exist(code))
                return false;
            else
            {
                myList.Add(code, obj);
                return true;
            }
        }

        public bool Add(clsHouse house)
        {
            if (Exist(house.Code))
                return false;
            else
            {
                myList.Add(house.Code, house);
                return true;
            }
        }

        public bool Delete(string code)
        {
            return myList.Remove(code);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public clsHouse Find(string code)
        {
            if (Exist(code))
                return myList[code];
            else
                return null;
        }

        public bool Exist(string code)
        {
            return myList.ContainsKey(code);
        }
    }
}
