using System;
using System.Linq;

namespace Chain_of_Responsibility
{
    class AmountCheck : IBankOperationHandeler
    {
        public IBankOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string cardPin, decimal amount)
        {
            var account = AccountDataBase.Accounts.FirstOrDefault(x => x.CardNumber == cardNumber);
            if (account.Amount >= amount)
            {
                Next?.Handle(cardNumber, cardPin, amount);
            }
            else
            {
                Console.WriteLine("Not enough money!");
            }
        }
    }

}
