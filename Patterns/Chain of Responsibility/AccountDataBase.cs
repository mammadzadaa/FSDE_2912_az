using System.Collections.Generic;

namespace Chain_of_Responsibility
{
    static class AccountDataBase
    {
        public static List<Account> Accounts { get; private set; }
        static AccountDataBase()
        {
            Accounts = new List<Account>()
            {
                new Account(){CardHolderName = "Muradxan", CardNumber = "1111", Pin = "1111", Amount = 1000},
                new Account(){CardHolderName = "Maga", CardNumber = "2222", Pin = "2222", Amount = 800},
                new Account(){CardHolderName = "Zabil", CardNumber = "3333", Pin = "3333", Amount = 1200},
            };
               
        }
    }

}
