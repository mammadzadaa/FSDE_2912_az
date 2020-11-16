using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork();
            unitOfWork.CardRepository.Create(new Card());
        }
    }

    class UnitOfWork
    {
        public CustomerRepository CustomerRepository { get; set; } = new CustomerRepository();
        public CardRepository CardRepository { get; set; } = new CardRepository();
        void Save()
        {

        }
        void Load()
        {

        }
    }

    // CRUD (Create, Read, Update, Delete)
    interface IRepository<T> where T : class
    {
        // Create
        void Create(T item);

        // Read
        T GetItem(string id);
        IEnumerable<T> GetAll();

        // Update
        void Update(string id, T item);

        // Delete
        void Delete(string id);
    }

    abstract class Repository<T> : IRepository<T> where T : class
    {
        protected static Dictionary<string, T> storage = new Dictionary<string, T>();
        public abstract void Create(T item);

        public IEnumerable<T> GetAll()
        {
            return storage.Select(x => x.Value);
        }

        public T GetItem(string id)
        {
            storage.TryGetValue(id, out T item);
            return item;
        }

        public void Update(string id, T item)
        {
            storage[id] = item;
        }

        public void Delete(string id)
        {
            storage.Remove(id);
        }
    }

    class CustomerRepository : Repository<Customer>
    {
        public override void Create(Customer item)
        {
            storage.Add(item.Id, item);
        }
    }

    class CardRepository : Repository<Card>
    {
        public override void Create(Card item)
        {
            storage.Add(item.Number, item);
        }
    }

    class Customer
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }

    class Card
    {
        public string OwnerId { get; set; }
        public string Number { get; set; }
        public string Pin { get; set; }
        public decimal Balance { get; set; }
    }

}
