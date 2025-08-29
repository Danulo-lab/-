using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class PowerLineWire
    {

        public string Brand;
        public string Material;


        private double CrossArea;
        private double Resistivity;

        public PowerLineWire(string brand, double crossArea, double resistivity, string material)
        {
            Brand = brand;
            CrossArea = crossArea;
            Resistivity = resistivity;
            Material = material;
        }


        public void SetCrossArea(double area)
        {
            if (area > 0)
                CrossArea = area;
            else
                Console.WriteLine("Помилка: площа перерізу повинна бути більшою за нуль!");
        }

        public double GetCrossArea()
        {
            return CrossArea;
        }

        public void SetResistivity(double resistivity)
        {
            if (resistivity > 0)
                Resistivity = resistivity;
            else
                Console.WriteLine("Помилка: питомий опір повинен бути додатнім!");
        }

        public double GetResistivity()
        {
            return Resistivity;
        }

        public override string ToString()
        {
            return $"Марка: {Brand}\n" +
                   $"Площа перерізу: {CrossArea} мм²\n" +
                   $"Питомий активний опір: {Resistivity} Ом·мм²/м\n" +
                   $"Матеріал: {Material}\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PowerLineWire wire1 = new PowerLineWire("АС-70", 70, 0.0283, "Алюміній зі сталевим сердечником");
            PowerLineWire wire2 = new PowerLineWire("М-25", 25, 0.0171, "Мідь");


            wire1.SetCrossArea(75);
            wire2.SetResistivity(0.018);

            Console.WriteLine(wire1.ToString());
            Console.WriteLine(wire2.ToString());

            Console.ReadKey();
        }
    }
}