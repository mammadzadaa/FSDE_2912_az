using System.Linq;

namespace Chain_of_Responsibility
{
    class OperationFinish : IBankOperationHandeler
    {
        public IBankOperationHandeler Next { get; set; }

        public void Handle(string cardNumber, string cardPin, decimal amount)
        {
            var account = AccountDataBase.Accounts.FirstOrDefault(x => x.CardNumber == cardNumber);
            account.Amount -= amount;
            Next?.Handle(cardNumber, cardPin, amount);
        }
    }

}
