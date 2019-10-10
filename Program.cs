using System;

namespace DM_assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            System.Console.WriteLine("Attempting to Deposit : 10");
            account.Deposit(10);

            System.Console.WriteLine($"Balance after deposit : {account.printAmount()}"); 

            System.Console.WriteLine("Attempting to withdraw : 5");
            account.WithDraw(5);

            System.Console.WriteLine($"Balance after withdraw : {account.printAmount()}"); 

            System.Console.WriteLine("Attempting to withdraw : 15");
            account.WithDraw(15);
         
        }
    }
}
