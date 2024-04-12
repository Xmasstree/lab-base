using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moya_pervaya_prog_a_na_c_sharp
{
    class Base
    {
        private string name;
        private List<Route> routes = new List<Route>();

        public Base(string name)
        {
            this.name = name;
        }

        public Base()
        {
            name = "Дворец Читос";
        }


        public void addRoute()
        {
            Console.Write("Введите номер маршрута: ");
            string number = Console.ReadLine();
            Console.Write("Введите начальный пункт маршрута: ");
            string start_point = Console.ReadLine();
            Console.Write("Введите конечный пункт маршрута: ");
            string finish_point = Console.ReadLine();
            Route point = new Route(start_point, finish_point, number);
            routes.Add(point);
        }

        public void show()
        {
            if (routes.Count > 0)
            {
                Console.Write("Введите конечный пункт маршрута: ");
                string search = Console.ReadLine();
                bool flag = false;
                foreach (Route point in routes)
                    if (point.FINISH_POINT == search)
                    {
                        Console.WriteLine($"Номер маршрута: {point.NUMBER} | Пункт отправления: {point.START_POINT} | Пункт конечный: {point.FINISH_POINT}");
                        flag = true;
                    }
                if (!flag)
                {
                    Console.WriteLine("Таких маршрутов нет");
                }
            }
            else
            {
                Console.WriteLine("Нет маршрутов");
            }
        }

        public List<Route> sort(Base baza)
        {
                for (int i = 1; i < baza.routes.Count; i++)
                {
                    Route curr = baza.routes[i];
                    int j = i;
                    while (j > 0 && String.Compare(baza.routes[i].START_POINT.ToUpper(), baza.routes[j-1].START_POINT.ToUpper()) < 0)
                    {
                        baza.routes[j] = baza.routes[j - 1];
                        j--;
                    }
                    baza.routes[j] = curr;
                }
                return baza.routes;

            //public static bool operator>(Route point1, Route point2)
            //{
            //    return point1.START_POINT > point2.START_POINT;
            //}
            //public static bool operator<(Route point1, Route point2)
            //{
            //    return point1.START_POINT < point2.START_POINT;
            //}

            //var sos = from i in routes
            //          orderby i.START_POINT, i.FINISH_POINT, i.NUMBER
            //          select i;
            //foreach(var i in sos)
            //    Console.WriteLine($"Номер маршрута: {i.NUMBER} | Пункт отправления: {i.START_POINT} | Пункт конечный: {i.FINISH_POINT}");
        }

        public void print()
        {
            if (routes.Count > 0)
            {
                foreach (Route point in routes)
                    Console.WriteLine($"Номер маршрута: {point.NUMBER} | Пункт отправления: {point.START_POINT} | Пункт конечный: {point.FINISH_POINT}");
            }
            else
                Console.WriteLine("Нет маршрутов.");
        }

       
    }
}
