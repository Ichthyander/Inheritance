using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    sealed class MultiBuilding:Building
    {
        public int Storey { get; set; }

        public MultiBuilding(string address, double length, double width, double heigth, int storey)
            :base (address, length, width, heigth)
        {
            Storey = storey;
        }

        public string Print()
        {
            return base.Print() + "\n" + $"Количество этажей: {Storey}";
        }
    }
}
