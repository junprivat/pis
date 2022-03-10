using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int menu = 0;
                List<Product> counts = new List<Product>();
                do
                {
                    Console.WriteLine("1. Добавить товар");
                    Console.WriteLine("2. Посмотреть товар");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Введите название товара");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите количество товара");
                            int number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите сумму товара");
                            float price = Convert.ToSingle(Console.ReadLine());
                            counts.Add(new Product(name, number, price));
                            break;
                        case 2:
                            Console.Write("Товар");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Name);
                            }
                            Console.WriteLine();
                            Console.Write("Количество");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Number);
                            }
                            Console.WriteLine();
                            Console.Write("Сумма");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Price);
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (menu < 3);
                Console.ReadKey();
            }
            catch { }
        }
    }
}
