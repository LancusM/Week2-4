using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates values for each ATM function, and states option outside of while statement
            int balance = 1000;
            int deposit = 0;
            int withdraw = 0;
            int option = 0;
            //while statement, creates menu and continues the program as long as the number entered is NOT 4
            while (option != 4) {
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            option = Convert.ToInt32(Console.ReadLine());
                //switch to hold the cases of each option but 4
            switch (option)
                    { 
                    //option 1 simply writes out balance value
                    case 1:
                        Console.WriteLine("Your balance is " + balance);
                        break;
                    //option 2 adds deposit amount to the balance, then makes that equal the new balance. simple enough
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        balance = balance + deposit;
                        Console.WriteLine("Deposit successful.");
                        break;
                    //similar to option 2, but removes the number given instead of adding
                    case 3:
                        Console.WriteLine("Enter withdrawal amount: ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        balance = balance - withdraw;
                        Console.WriteLine("Withdrawal successful.");
                        break;
                    }          
            }
            //printed when option equals 4, telling program to finish running
            Console.WriteLine("Exiting ATM.");
            Console.Read();
        }
    }
}
