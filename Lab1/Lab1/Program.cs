using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{

    namespace PowerLineApp
    {
        class PowerLineWire
        {
            public string Brand;
            public double CrossArea;
            public double Resistivity;
            public string Material;

            public PowerLineWire(string brand, double crossArea, double resistivity, string material)
            {
                Brand = brand;
                CrossArea = crossArea;
                Resistivity = resistivity;
                Material = material;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Марка: {Brand}");
                Console.WriteLine($"Площа перерізу: {CrossArea} мм²");
                Console.WriteLine($"Питомий активний опір: {Resistivity} Ом·мм²/м");
                Console.WriteLine($"Матеріал: {Material}");
                Console.WriteLine(new string('-', 35));
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                PowerLineWire wire1 = new PowerLineWire("АС-70", 70, 0.0283, "Алюміній зі сталевим сердечником");
                PowerLineWire wire2 = new PowerLineWire("М-25", 25, 0.0171, "Мідь");

                wire1.PrintInfo();
                wire2.PrintInfo();

                Console.ReadKey();
            }
        }
    }

}
