using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Multibuilding multibuilding = new Multibuilding("Бутлерова 9к2", 45, 24, 60, 20);
            multibuilding.Print();
            Console.ReadKey();

        }
        class Building
        {
            public string Adress { get; set; }
            public double Length { get; set; }
            public double Width { get; set; }
            public double Height { get; set; }

            public Building(string adress, double length, double width, double height)
            {
                Adress = adress;
                Length = length;
                Width = width;
                Height = height;
            }
            public void Print()
            {
                Console.WriteLine("Адрес здания: ул. {0}", Adress);
                Console.WriteLine("Длина здания: {0} м", Length);
                Console.WriteLine("Ширина здания: {0} м", Width);
                Console.WriteLine("Высота здания: {0} м", Height);

            }

        }
        sealed class Multibuilding : Building
        {
            public int Floors { get; set; }
            public Multibuilding(string adress, double length, double width, double height, int floors)
                : base(adress, length, width, height)
            {
                Floors = floors;

            }
            public new void Print()
            {
                base.Print();
                Console.WriteLine("Количество этажей: {0}", Floors);
            }

        }

    }
}





