using System;
using System.Reflection.Metadata;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankOperationHandeler accountCheck = new AccountCheck();
            IBankOperationHandeler amountChech = new AmountCheck();
            IBankOperationHandeler logging = new OperationLog();
            IBankOperationHandeler finishOperation = new OperationFinish();

            accountCheck.Next = amountChech;
            amountChech.Next = logging;
            logging.Next = finishOperation;

            string cardNumber;
            string cardPin;
            decimal amountToWithdraw;

            Console.Write("Enter Card Number: ");
            cardNumber = Console.ReadLine();
            Console.Write("Enter Card Pin: ");
            cardPin = Console.ReadLine(); 
            Console.Write("Enter Amount to withdraw: ");
            amountToWithdraw = decimal.Parse(Console.ReadLine());

            accountCheck.Handle(cardNumber, cardPin, amountToWithdraw);


        }
    }

}
