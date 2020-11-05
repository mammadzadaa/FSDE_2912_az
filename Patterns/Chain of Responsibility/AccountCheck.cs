using System;
using System.Linq;

namespace Chain_of_Responsibility
{
    class AccountCheck : IBankOperationHandeler
    {
        public IBankOperationHandeler Next { get ; set ; }

        public void Handle(string cardNumber, string cardPin, decimal amount)
        {
            if (AccountDataBase.Accounts.Any(x => x.CardNumber == cardNumber && x.Pin == cardPin))
            {
                Next?.Handle(cardNumber, cardPin, amount);
            }
            else
            {
                Console.WriteLine("Invalid card number or pin!");
            }
        }
    }

}
