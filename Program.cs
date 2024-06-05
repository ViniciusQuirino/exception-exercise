using System;
using exception_exercise.Entities;
using exception_exercise.Entities.Exceptions;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter account data:");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Holder: ");
            string holder = Console.ReadLine();
            System.Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            System.Console.WriteLine();
            System.Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine());
            try
            {
                account.Withdraw(amountWithdraw);
                System.Console.WriteLine($"New balance: ${account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            catch (DomainException e)
            {
                System.Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}