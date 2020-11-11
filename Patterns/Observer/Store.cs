using System;
using System.Collections.Generic;

namespace Observer
{
    class Store : AbstractStore
    {
        protected List<StoreItem> items = new List<StoreItem>();
        public Store(string name)
        {
            Name = name;
        }
        public void AddItem(StoreItem item)
        {
            items.Add(item);
            NotifyCustomers(item);
        }

        public override void Buy(ICustomer customer, StoreItem item)
        {
            Console.WriteLine($"{customer.Name} bought from {Name} the {item.Name} for {item.Price}$");
        }
    }
    

}
