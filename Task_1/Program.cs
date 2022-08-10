using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задачи


Задан класс Building, который описывает здание. Класс содержит следующие элементы:

адрес здания;
длина здания;
ширина здания;
высота здания.
В классе Building нужно реализовать следующие методы:

конструктор с 4 параметрами;
свойства get/set для доступа к полям класса;
метод Print(), который выводит информацию о здании.
Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

конструктор с 5 параметрами – реализует вызов конструктора базового класса;
свойство get/set доступа к внутреннему полю класса;
метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
Класс MultiBuilding сделать таким, что не может быть унаследован.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Гагарина, 6", 72, 36, 50);
            Console.WriteLine(building.Print());
            //Console.WriteLine(building.Address);
            Console.WriteLine();

            MultiBuilding multiBuilding = new MultiBuilding("Ленина, 12", 54, 18, 15, 5);
            Console.WriteLine(multiBuilding.Print());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
