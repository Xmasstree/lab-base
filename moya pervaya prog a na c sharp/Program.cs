//Смольников Илья Владимирович (вариант 11 базовый уровень)

using System;

namespace moya_pervaya_prog_a_na_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создание базы отдыха.");
            Console.Write("Введите название для базы отдыха: ");
            string name = Console.ReadLine();
            Base baza = new Base(name);
            Console.WriteLine($"\nБаза {name} создана");
            string x;
            do
            {
                Console.WriteLine("\nВведите");
                Console.WriteLine("1. Для дополнения списка маршрутов.");
                Console.WriteLine("2. Для просмотра информации о маршрутах, конечный пункт назаначения которых вы ввели вручную.");
                Console.WriteLine("3. Для просмотра всего списка маршрутов.");
                Console.WriteLine("4. Для сортировки массива по начальному пункту.");
                Console.WriteLine("0. Для завершения программы.");
                Console.Write("Ввод: ");
                x = Console.ReadLine();

                switch(x)
                {
                    case "1":
                        baza.addRoute();
                        break;
                    case "2":
                        baza.show();
                        break;
                    case "3":
                        baza.print();
                        break;
                    case "4":
                        baza.sort(baza);
                        break;
                    case "0":
                        Console.WriteLine("Good night!");
                        break;
                    default:
                        Console.WriteLine("Такой команды нет.");
                        break;
                }
            }
            while (x != "0");
        }

    }
}
