using System.Collections.Generic;
using System.Linq;

namespace BAL
{
    public class clsListSales
    {
        private Dictionary<int, clsSale> myList;

        public clsListSales()
        {
            myList = new Dictionary<int, clsSale>();
        }

        public int GetCount
        {
            get
            {
                return myList.Count();
            }

        }

        public Dictionary<int, clsSale>.ValueCollection Elements
        {
            get
            {
                return myList.Values;
            }
        }

        public bool Update(clsSale obj, int ID)
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

        public bool Add(clsSale obj, int ID)
        {
            if (Exist(ID))
                return false;
            else
            {
                myList.Add(ID, obj);
                return true;
            }
        }

        public bool Add(clsSale sale)
        {
            if (Exist(sale.ID))
                return false;
            else
            {
                myList.Add(sale.ID, sale);
                return true;
            }
        }

        public bool Delete(int ID)
        {
            return myList.Remove(ID);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public clsSale Find(int ID)
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

