using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading;

namespace Lesson_17_09_20_Event
{
    delegate void Delegate();

    class Zara
    {
        public event Delegate MehsulGeldi;
        public void MehsulunGelmeyi()
        {
            MehsulGeldi?.Invoke();
        }
    }

    //class Timer
    //{
    //    public event Action TimeOut;

    //    private event Action myEvent;

    //    public event Action MyEvent
    //    {
    //        add
    //        {
    //            Console.WriteLine("Event been Added");
    //            myEvent += value;
    //        }
    //        remove
    //        {
    //            Console.WriteLine("Event been removed");
    //            myEvent -= value;
    //        }
    //    }

    //    public void TimerStart(int seconds)
    //    {
    //        for (int i = 0; i < seconds; i++)
    //        {
    //            Thread.Sleep(1000);
    //            Console.WriteLine(i + 1);
    //        }
    //        TimeOut?.Invoke();
    //    }
    //}

        enum Action
        {
            Withdraw,
            Deposit
        }
    class BalanceChangedArg : EventArgs
    {
        public BalanceChangedArg(Action action, decimal amount)
        {
            Action = action;
            Amount = amount;
        }

        public Action Action { get; set; }
        public decimal Amount { get; set; }
    }
    class BankAccount
    {
        public BankAccount(string accountHolder, decimal money, string accountHolderNumber, string email)
        {
            AccountHolder = accountHolder;
            Money = money;
            AccountHolderNumber = accountHolderNumber;
            AccountHolderEmail = email;
        }

        public event EventHandler BalanceChange;

        public string AccountHolder { get; }
        public decimal Money { get; private set; } = 0;
        public string AccountHolderNumber { get;  }
        public string AccountHolderEmail { get; }

        public void WithdrawMoney(decimal amount)
        {
            if (amount <= Money)
            {
                Money -= amount;
                BalanceChange?.Invoke(this,new BalanceChangedArg(Action.Withdraw,amount));
            }
        }

        public void DepositMoney(decimal amount)
        {
            Money += amount;
            BalanceChange?.Invoke(this, new BalanceChangedArg(Action.Deposit, amount));
        }

    }

    class Program
    {
        static void PrintOnTimeOut()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Time Out");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Samur",500.0m,"+994 99 999 9999","samur@gmail.com");
            
            account.BalanceChange += SendSMS;
            account.BalanceChange += EmailNotify;

           
            account.WithdrawMoney(150.70m);
            Console.WriteLine();
            account.DepositMoney(172.48m);



            //ObservableCollection<int> numbers = new ObservableCollection<int>();

            //numbers.CollectionChanged += WriteToFile;
            //numbers.CollectionChanged += PrintToScreen;
            //numbers.CollectionChanged += PrintAddedNumber;
            
            //while (true)
            //{
            //    Console.Write("Enter Number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    numbers.Add(number);
            //    Console.WriteLine("Press ESC to finish, or any other button to continue");
            //    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            //        break;
            //}
            //Console.WriteLine();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Timer timer = new Timer();

            //timer.TimeOut += PrintOnTimeOut;

            //timer.TimerStart(10);

            //timer.MyEvent += () => Console.WriteLine() ;
            //timer.MyEvent += Timer_MyEvent;
            //timer.MyEvent -= Timer_MyEvent;


                    //Zara t = new Zara();
                    //        //t.MehsulGeldi += () => Console.WriteLine("Hi");
                    //        ////t.Event += Print;
                    //        ////t.Event -= Print;
                    //        //t.MehsulGeldi += () => Console.WriteLine("Hello");
                    //t.MehsulGeldi += MehsulGedAl;

            //t.MehsulunGelmeyi();
            ////t.Event = null;  // not working
            ////t.Event = () => Console.WriteLine("Hi"); // not working




            //TranslateRequest translate = new TranslateRequest() { source = "en", target = "az", format = "text" };

            //Console.Write("Enter your text: ");
            //translate.q = Console.ReadLine();

            //WebClient web = new WebClient();
            //string url = "https://translation.googleapis.com/language/translate/v2?key=AIzaSyCqwaXLLd9JraElDHNGKFIN2zfbSAgAHms";

            //string answer = web.UploadString(url, JsonSerializer.Serialize(translate));
            ////Console.WriteLine(answer);

            //var response = JsonSerializer.Deserialize<TranslateResponse>(answer);
            //Console.Write("\nYour Translation: ");
            //Console.WriteLine(response.data.translations[0].translatedText);

        }

        private static void EmailNotify(object sender, EventArgs e)
        {
            if (sender is BankAccount account && e is BalanceChangedArg arg)
            {
                Console.WriteLine($"Sent To Mail {account.AccountHolderEmail}:\n"+
                                  $"Dear {account.AccountHolder},\nYour Balance was {arg.Action}ed by {arg.Amount} AZN" + 
                                  $"\nYour Balance is {account.Money}\n\n");
            }
        }

        private static void SendSMS(object sender, EventArgs e)
        {
            if (sender is BankAccount account && e is BalanceChangedArg arg)
            {
                Console.WriteLine($"To number {account.AccountHolderNumber}:" +
                                  $"\n{arg.Amount} been {arg.Action} from {account.AccountHolder}"+
                                  $"\nBalance: {account.Money}\n\n");
            }
        }

        private static void PrintAddedNumber(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintToScreen(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine(e.Action);
        }

        private static void WriteToFile(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var item in e.NewItems)
                {
                    File.AppendAllText("Numbers.txt",item.ToString() + " ");
                }
               
            }
        }

        private static void Timer_MyEvent()
        {
            throw new NotImplementedException();
        }

        static void MehsulGedAl()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Shopping");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}