using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Heigth { get; set; }

        public Building(string address, double length, double width, double heigth)
        {
            Address = address;
            Length = length;
            Width = width;
            Heigth = heigth;
        }

        public string Print()
        {
            return $"Адрес: {Address}" + "\n" + $"Длина здания: {Length} м" + "\n" + $"Ширина здания: {Width} м" + "\n" + $"Высота здания: {Heigth} м";
        }
    }
}
