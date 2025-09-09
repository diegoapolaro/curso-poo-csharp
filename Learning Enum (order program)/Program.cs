using Learning_Enum__order_program_.Entities;
using Learning_Enum__order_program_.Entities.enums;
using System;


namespace Learning_Enum__order_program_
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);
        }
    }
}