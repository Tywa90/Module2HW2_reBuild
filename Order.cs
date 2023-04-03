using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ShoppingDay.Test
{
    public class Order
    {
        private static int _orderID;

        public static int OrderNum()
        {
            int counter = 100012;
            counter++;
            _orderID = counter;
            return _orderID;
        }
       
        public static void OrderFinal()
        {
            Console.Write("Ваш заказ сформирован с номером: ");
            OrderNum();
            Console.WriteLine(_orderID);
            DateTime date1 = DateTime.Now;
            date1 = date1.AddDays(3);
            Console.WriteLine($"Ожидаемая дата доставки: {date1.DayOfWeek} {date1.ToShortDateString().ToString()}");
        }
    }
}
