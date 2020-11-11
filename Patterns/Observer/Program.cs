namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Store Apple = new Store("Apple");
            Store Walmart = new Store("Walmart");

            Customer customer1 = new Customer("Alex",123.34m,TypeOfItem.Electronics);
            Customer customer2 = new Customer("Maga", 243, TypeOfItem.Clothing);
            Customer customer3 = new Customer("Alisa", 345, TypeOfItem.Clothing);
            Customer customer4 = new Customer("Bob", 56.12m, TypeOfItem.Furniture);
            Customer customer5 = new Customer("Rick", 564, TypeOfItem.Electronics);

            Apple.Subscribe(customer1);
            Apple.Subscribe(customer2);
            Apple.Subscribe(customer3);
            Apple.Subscribe(customer4);
            Apple.Subscribe(customer5);

            Walmart.Subscribe(customer1);
            Walmart.Subscribe(customer2);
            Walmart.Subscribe(customer3);
            Walmart.Subscribe(customer4);
            Walmart.Subscribe(customer5);

            Apple.AddItem(new StoreItem() {Name = "Iphone 12", Price = 800, Type = TypeOfItem.Electronics});
            Walmart.AddItem(new StoreItem() { Name = "T-shirt", Price = 30, Type = TypeOfItem.Clothing });
            Walmart.AddItem(new StoreItem() { Name = "Underware", Price = 20, Type = TypeOfItem.Clothing });
            Apple.AddItem(new StoreItem() { Name = "AirPods", Price = 150, Type = TypeOfItem.Electronics });
            Walmart.AddItem(new StoreItem() { Name = "Chair", Price = 50, Type = TypeOfItem.Furniture });


        }
    }
    
}
