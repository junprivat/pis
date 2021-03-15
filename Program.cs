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
                List<Kvitancia> counts = new List<Kvitancia>();
                do
                {
                    Console.WriteLine("1. Добавить квитанцию");
                    Console.WriteLine("2. Посмотреть квитанцию");
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Введите номер квитанции");
                            int number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите дату квитанции");
                            string date = Console.ReadLine();
                            Console.WriteLine("Введите сумму квитанции");
                            double symma = Convert.ToDouble(Console.ReadLine());
                            counts.Add(new Kvitancia(number, date, symma));
                            break;
                        case 2:
                            Console.Write("Квитанция");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Number);
                            }
                            Console.WriteLine();
                            Console.Write("Дата");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Date);
                            }
                            Console.WriteLine();
                            Console.Write("Сумма");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].Symma);
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
