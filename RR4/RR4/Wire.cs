using System;

namespace LR4
{
    public class Wire : IWireProperties, IWireInfo
    {
        private string marka;
        private string material;
        private double area;
        private double resistivity;

        // Константи
        public const double MinArea = 0.1;
        public const double MinResistivity = 0.0001;

        // Конструктори
        public Wire()
        {
            marka = "Невідомо";
            material = "Невідомо";
            area = MinArea;
            resistivity = MinResistivity;
        }

        public Wire(string marka, string material)
        {
            this.marka = marka;
            this.material = material;
            this.area = MinArea;
            this.resistivity = MinResistivity;
        }

        public Wire(string marka, string material, double area, double resistivity)
        {
            this.marka = marka;
            this.material = material;
            SetArea(area);
            SetResistivity(resistivity);
        }

        // Реалізація інтерфейсу
        public void SetArea(double value)
        {
            if (value >= MinArea)
                area = value;
            else
                throw new ArgumentException($"Площа повинна бути ≥ {MinArea}");
        }

        public double GetArea() => area;

        public void SetResistivity(double value)
        {
            if (value >= MinResistivity)
                resistivity = value;
            else
                throw new ArgumentException($"Опір повинен бути ≥ {MinResistivity}");
        }

        public double GetResistivity() => resistivity;

        public override string ToString()
        {
            return $"Марка: {marka}, Площа: {area} мм², Опір: {resistivity}, Матеріал: {material}";
        }
    }
}
