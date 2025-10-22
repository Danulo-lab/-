using System;

namespace LR1
{
    class Wire
    {
        private string marka;
        private double area;
        private double resistivity;
        private string material;

        // 🔹 Конструктор без параметрів
        public Wire()
        {
            marka = "АС-95/16";
            area = 95.0;
            resistivity = 0.306;
            material = "Алюміній/Сталь";
        }

        // 🔹 Конструктор з 2 параметрами
        public Wire(string marka, double area)
        {
            this.marka = marka;
            this.area = area;
            resistivity = 0.3;
            material = "Невідомо";
        }

        // 🔹 Конструктор з усіма параметрами
        public Wire(string marka, double area, double resistivity, string material)
        {
            this.marka = marka;
            this.area = area;
            this.resistivity = resistivity;
            this.material = material;
        }

        // 🔹 ToString для виводу
        public override string ToString()
        {
            return $"Марка: {marka}, Площа: {area} мм², Опір: {resistivity}, Матеріал: {material}";
        }
    }
}
