using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    sealed class Singletone
    {
        private static Singletone instance;
        private Singletone() {}

        public static Singletone Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singletone();
                }
                return instance;
            }
        }

        public int Count { get; set; }
        public void CountPlus()
        {
            Count++;
        }
    }
}
