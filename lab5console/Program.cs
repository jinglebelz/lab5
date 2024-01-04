using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Ввести А");
                Console.WriteLine("2. Ввести В");
                Console.WriteLine("3. «+»");
                Console.WriteLine("4. «-»");
                Console.WriteLine("5. «*»");
                Console.WriteLine("6. «/»");
                Console.WriteLine("7. Выход");

                Console.Write("\nВыберите действие: ");
                string x = Console.ReadLine();

                void GetA()
                {
                    Console.Write("Введите значение для А: ");
                    A = Convert.ToDouble(Console.ReadLine());
                }
                void GetB()
                {
                    Console.Write("Введите значение для В: ");
                    B = Convert.ToDouble(Console.ReadLine());
                }
                void Add()
                {
                    Console.WriteLine("Ответ: " + (A+B));
                }
                void Sub()
                {
                    Console.WriteLine("Ответ: " + (A - B));
                }
                void Mul()
                {
                    Console.WriteLine("Ответ: " + (A * B));
                }
                void Div()
                {
                    if (B != 0)
                    {
                        Console.WriteLine("Ответ: " + (A / B));
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                }

                switch (x)
                {
                    case "1":
                        GetA();
                        break;
                    case "2":
                        GetB();
                        break;
                    case "3":
                        Add();
                        break;
                    case "4":
                        Sub();
                        break;
                    case "5":
                        Mul();
                        break;
                    case "6":
                        Div();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}
