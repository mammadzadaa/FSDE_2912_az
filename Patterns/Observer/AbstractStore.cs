using System.Collections.Generic;

namespace Observer
{
    abstract class AbstractStore
    {
        public string Name { get; set; }
        protected List<ICustomer> Customers { get; set; } = new List<ICustomer>();
        public abstract void Buy(ICustomer customer, StoreItem item);
        public void Subscribe(ICustomer customer)
        {
            Customers.Add(customer);
        }
        public void Unsubscribe(ICustomer customer)
        {
            Customers.Remove(customer);
        }

        public void NotifyCustomers(StoreItem item)
        {
            foreach (var customer in Customers)
            {
                customer.Update(this, item);
            }
        }
    }
    

}
