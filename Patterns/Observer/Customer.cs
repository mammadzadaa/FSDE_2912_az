namespace Observer
{
    class Customer : ICustomer
    {
        public Customer(string name, decimal budget, TypeOfItem interest)
        {
            Name = name;
            Budget = budget;
            Interest = interest;
        }

        public string Name { get ; set; }
        public decimal Budget { get ; set; }
        public TypeOfItem Interest { get; set; }

        public void Update(AbstractStore sender, StoreItem item)
        {
            if (item.Type == Interest)
            {
                if (Budget >= item.Price)
                {
                    sender.Buy(this, item);
                    Budget -= item.Price;
                }
            }
        }
    }
    

}
