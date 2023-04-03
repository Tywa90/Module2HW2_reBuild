using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class ArrayProducts
    {
        private static string[] names;
        private static double[] price;
        public const int arrlength = 5;

        
        public ArrayProducts()
        {
            names = new string[arrlength] { "Батон горчичиный", "Пицца Буфет", "Яблоко Вкусное", "Яйцо С1", "Масло Маргарин" };
            price = new double[arrlength] { 21.20, 75.10, 300.10, 12.99, 55.10 };
        }
        public static string[] ArrayListNames()
        {
            return names;
        }
        public static double[] ArrayListPrice()
        {
            return price;
        }
        public static void ArrayDisplay()
        {
            int j = 1;
            for (int i = 0; i < arrlength; i++)
            {
                Console.WriteLine($"{j}. {names[i]} {price[i]:C}");
                j++;
            }
        }
    }
}
