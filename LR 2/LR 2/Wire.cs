using System;

namespace LR2
{
    public class Wire
    {
        // Відкриті властивості
        public string Marka { get; set; }
        public string Material { get; set; }

        // Закриті поля
        private double area;        // площа перерізу
        private double resistivity; // питомий опір

        // Методи доступу (Set/Get)
        public void SetArea(double value)
        {
            if (value > 0)
                area = value;
            else
                throw new ArgumentException("Площа повинна бути більше 0!");
        }

        public double GetArea()
        {
            return area;
        }

        public void SetResistivity(double value)
        {
            if (value > 0)
                resistivity = value;
            else
                throw new ArgumentException("Опір повинен бути більше 0!");
        }

        public double GetResistivity()
        {
            return resistivity;
        }

        // Перевизначений метод ToString()
        public override string ToString()
        {
            return $"Марка: {Marka}, Площа: {area} мм², " +
                   $"Опір: {resistivity}, Матеріал: {Material}";
        }
    }
}
