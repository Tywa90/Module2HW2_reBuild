using ShoppingDay.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Start
    {
        public static void Run()
        {
            Console.WriteLine("Добро пожаловать в магазин!");

            Console.WriteLine("Список наших товаров: ");
            ArrayProducts arr = new ArrayProducts();


            while (true)
            {
                ArrayProducts.ArrayDisplay();

                Console.Write("Выберите товар: ");

                while (true)
                {
                    string? text = Console.ReadLine();
                    if (int.TryParse(text, out int number))
                    {
                        if (number > 0 && number <= ArrayProducts.arrlength)
                        {
                            Cart.AddToCart(ArrayProducts.ArrayListNames()[number - 1], ArrayProducts.ArrayListPrice()[number - 1]);
                            break;
                        }
                        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                    }
                }

                Console.WriteLine("Чтобы перейти к оформлению заказа нажмите \"N\"");
                Console.WriteLine("Чтобы продолжить покупки - нажмите любую другую клавишу");
                string? answer = Console.ReadLine();
                if (!String.IsNullOrEmpty(answer) && answer.Equals("n", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Переходим в корзину для оформления заказа");
                    break;
                }
            }
            Cart.DisplayCart();
            Order.OrderFinal();
        }
    }
}
