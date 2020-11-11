using System;

namespace Observer
{
    interface ICustomer
    {
        public string Name { get; set; }
        public decimal Budget { get; set; }
        void Update(AbstractStore sender, StoreItem item);
    }
    

}
