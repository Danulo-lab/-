using System;

namespace LR1
{
    class Wire
    {
       
        private string marka;
        private double area;

     
        public double Resistivity { get; set; }
        public string Material { get; set; }

     
        public string Marka
        {
            get => marka;
            set => marka = value;
        }

        public double Area
        {
            get => area;
            set
            {
                if (value > 0) area = value;
            }
        }

       
        public double Mass => Area * Resistivity;

       
        public Wire()
        {
            Marka = "АС-95/16";
            Area = 95.0;
            Resistivity = 0.306;
            Material = "Алюміній/Сталь";
        }

        // 🔹 Конструктор з 2 параметрами
        public Wire(string marka, double area)
        {
            Marka = marka;
            Area = area;
            Resistivity = 0.3;
            Material = "Невідомо";
        }

       
        public Wire(string marka, double area, double resistivity, string material)
        {
            Marka = marka;
            Area = area;
            Resistivity = resistivity;
            Material = material;
        }

   
        public override string ToString()
        {
            return $"Марка: {Marka}, Площа: {Area} мм², Опір: {Resistivity}, Матеріал: {Material}, Маса: {Mass:F3}";
        }

      
        public void UpdateResistivity(double newValue)
        {
            if (newValue > 0) Resistivity = newValue;
        }

      
        public void IncreaseArea(ref double extra)
        {
            Area += extra;
        }
    }
}
