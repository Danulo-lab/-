using System;

namespace Lab3
{

    class PowerLineWire
    {

        private string Brand;        
        private string Material;     
        private double CrossArea;  
        private double Resistivity;

    
        public PowerLineWire()
        {
            Brand = "Невідомо";
            Material = "Невідомо";
            CrossArea = 1.0;
            Resistivity = 0.01;
        }

        public PowerLineWire(string brand, string material)
        {
            Brand = brand;
            Material = material;
            CrossArea = 1.0;
            Resistivity = 0.01;
        }

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

        public double GetCrossArea() => CrossArea;

        public void SetResistivity(double resistivity)
        {
            if (resistivity > 0)
                Resistivity = resistivity;
            else
                Console.WriteLine("Помилка: питомий опір повинен бути додатнім!");
        }

        public double GetResistivity() => Resistivity;

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

            PowerLineWire wire1 = new PowerLineWire();  
            PowerLineWire wire2 = new PowerLineWire("АС-70", "Алюміній зі сталевим сердечником"); 
            PowerLineWire wire3 = new PowerLineWire("М-25", 25, 0.0171, "Мідь");

            Console.WriteLine("Провід 1 (без параметрів):");
            Console.WriteLine(wire1.ToString());

            Console.WriteLine("Провід 2 (2 параметри):");
            Console.WriteLine(wire2.ToString());

            Console.WriteLine("Провід 3 (усі параметри):");
            Console.WriteLine(wire3.ToString());

            Console.ReadKey();
        }
    }
}
