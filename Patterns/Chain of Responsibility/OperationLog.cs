using System;
using System.Linq;

namespace Chain_of_Responsibility
{
    class OperationLog : IBankOperationHandeler
    {
        public IBankOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string cardPin, decimal amount)
        {
            var account = AccountDataBase.Accounts.FirstOrDefault(x => x.CardNumber == cardNumber);
            Console.WriteLine($"{amount} azn been withdrawed from account of {account.CardHolderName}");
            Next?.Handle(cardNumber, cardPin, amount);
        }
    }

}
