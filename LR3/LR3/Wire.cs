using System;

namespace LR3
{
    public class Wire
    {
        // --- Приватні поля ---
        private string marka;
        private string material;
        private double area;
        private double resistivity;

        // --- Конструктори ---
        // 1. Конструктор без параметрів
        public Wire()
        {
            marka = "Невідомо";
            material = "Невідомо";
            area = 1.0;
            resistivity = 0.01;
        }

        // 2. Конструктор з двома параметрами
        public Wire(string marka, string material)
        {
            this.marka = marka;
            this.material = material;
            this.area = 1.0;
            this.resistivity = 0.01;
        }

        // 3. Конструктор з усіма параметрами
        public Wire(string marka, string material, double area, double resistivity)
        {
            this.marka = marka;
            this.material = material;
            this.area = area;
            this.resistivity = resistivity;
        }

        // --- Методи доступу до закритих полів ---
        public void SetArea(double value)
        {
            if (value > 0) area = value;
            else throw new ArgumentException("Площа повинна бути більше 0!");
        }

        public double GetArea() => area;

        public void SetResistivity(double value)
        {
            if (value > 0) resistivity = value;
            else throw new ArgumentException("Опір повинен бути більше 0!");
        }

        public double GetResistivity() => resistivity;

        // --- Перевизначення ToString() ---
        public override string ToString()
        {
            return $"Марка: {marka}, Площа: {area} мм², Опір: {resistivity}, Матеріал: {material}";
        }
    }
}
