using System;

namespace PowerLineApp
{
    class PowerLineWire
    {
        private string Brand;
        private double CrossArea;

        public string Material { get; set; }
        public double Resistivity { get; set; }

        public string Insulation { get; set; }
        public int VoltageLevel { get; set; }

        public double ResistancePerMeter
        {
            get { return Resistivity / CrossArea; }
        }

        public string BrandName
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public double CrossSection
        {
            get { return CrossArea; }
            set
            {
                if (value > 0)
                    CrossArea = value;
            }
        }

        public PowerLineWire()
        {
            BrandName = "Невідомо";
            CrossSection = 1.0;
            Resistivity = 0.01;
            Material = "Невідомо";
            Insulation = "Невідомо";
            VoltageLevel = 0;
        }

        public PowerLineWire(string brand, string material)
        {
            BrandName = brand;
            Material = material;
            CrossSection = 1.0;
            Resistivity = 0.01;
            Insulation = "Невідомо";
            VoltageLevel = 0;
        }

        public PowerLineWire(string brand, double crossArea, double resistivity, string material, string insulation, int voltage)
        {
            BrandName = brand;
            CrossSection = crossArea;
            Resistivity = resistivity;
            Material = material;
            Insulation = insulation;
            VoltageLevel = voltage;
        }

        public void IncreaseCrossArea(double addValue)
        {
            CrossSection += addValue;
        }

        public void ChangeVoltageLevel(ref int newVoltage)
        {
            VoltageLevel = newVoltage;
        }

        public override string ToString()
        {
            return $"Марка: {BrandName}\n" +
                   $"Площа перерізу: {CrossSection} мм²\n" +
                   $"Питомий опір: {Resistivity} Ом·мм²/м\n" +
                   $"Матеріал: {Material}\n" +
                   $"Ізоляція: {Insulation}\n" +
                   $"Рівень напруги: {VoltageLevel} кВ\n" +
                   $"Опір на метр: {ResistancePerMeter} Ом/м\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PowerLineWire wire1 = new PowerLineWire();
            PowerLineWire wire2 = new PowerLineWire("АС-70", "Алюміній");
            PowerLineWire wire3 = new PowerLineWire("М-25", 25, 0.0171, "Мідь", "ПВХ", 10);

            Console.WriteLine("Об'єкт 1:");
            Console.WriteLine(wire1.ToString());

            Console.WriteLine("Об'єкт 2:");
            wire2.CrossSection = 70;
            wire2.Resistivity = 0.0283;
            wire2.Insulation = "Поліетилен";
            wire2.VoltageLevel = 35;
            Console.WriteLine(wire2.ToString());

            Console.WriteLine("Об'єкт 3:");
            Console.WriteLine(wire3.ToString());

            wire2.IncreaseCrossArea(5);
            Console.WriteLine("Після збільшення площі перерізу на 5 мм²:");
            Console.WriteLine(wire2.ToString());

            int newVoltage = 110;
            wire3.ChangeVoltageLevel(ref newVoltage);
            Console.WriteLine("Після зміни рівня напруги через ref:");
            Console.WriteLine(wire3.ToString());

            Console.ReadKey();
        }
    }
}
