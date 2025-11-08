using System;
using System.Data;
using System.Threading.Channels;
using inheritance_test.Entities;

namespace inheritance_test
{
    class program
    {
        static void Main(string[] args) 
        {
            Account acc1 = new Account(1001, "José", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.withdraw(5.0);
            acc2.withdraw(5.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}