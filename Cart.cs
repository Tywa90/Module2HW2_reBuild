using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Cart
    {
        private static string[] _cartS = new string[1];
        private static double[] _cartI = new double[1];
        private static int[] _cartQuntity = new int[1];
        private static double[] _cartForlot = new double[1];
        private static int i = 0;
        private static int j = 1;
        public static int Quantity { get; set; }
        public static double FullPrice { get; set; }
        public static void AddToCart(string strName, double dblPrice)
        {
            Array.Resize(ref _cartS, j);
            Array.Resize(ref _cartI, j);
            Array.Resize(ref _cartQuntity, j);
            Array.Resize(ref _cartForlot, j);

            _cartS[i] = strName;
            _cartI[i] = dblPrice;

            QuantProd();
            _cartQuntity[i] = Quantity;

            FullPrice = dblPrice * Quantity;
            _cartForlot[i] = FullPrice;

            i++;
            j++;

        }
        public static int QuantProd()
        {
            while (true)
            {
                Console.Write("Введите количество: ");
                string? text = Console.ReadLine();
                if (int.TryParse(text, out int number))
                {
                    if (number > 0)
                    {
                        Quantity = number;
                        Console.WriteLine($"Вы добавили в корзину {Quantity} шт.");
                        break;
                    }

                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
            }
            return Quantity;
        }

        public static void DisplayCart()
        {
            Console.WriteLine("Корзина:");
            for (int k = 0; k < _cartS.Length; k++)
            {
                Console.WriteLine($"{_cartS[k]} {_cartI[k]:C} -- {_cartQuntity[k]}шт.");
                Console.WriteLine($"{_cartForlot[k]:C}");
            }
            Console.WriteLine($"Сумма к оплате: {_cartForlot.Sum():C}") ;
        }

    }
}
