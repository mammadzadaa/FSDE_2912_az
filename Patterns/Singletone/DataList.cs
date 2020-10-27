using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singletone
{
    class DataList
    {
        private static DataList instance;
        private DataList() { ListOfItems = new List<string>(); }
        public static DataList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataList();
                }
                return instance;
            }
        }
        public List<string> ListOfItems;
    }
}
