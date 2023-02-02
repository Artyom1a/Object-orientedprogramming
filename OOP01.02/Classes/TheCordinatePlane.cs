using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public struct TheCordinatePlane<T>
    {
        // Внутренние поля - координаты точек
        public T X1, X2, Y1, Y2;

        public TheCordinatePlane(T x1, T x2, T y1, T y2)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Y1 = y1;
            this.Y2 = y2;
        }

        public void Print(string message)
        {
            Console.Write(message + "   ");
            Console.WriteLine("x1 = {0}, y1 = {1}, x2 = {2}, y2 = {3}",
              X1, Y1, X2, Y2);
        }
    }

}


//Пример 1.Объявляется структура Line<T>, реализующая отрезок на координатной плоскости.
//Отрезок задан координатами точек (x1; y1), (x2; y2).

//В функции main() демонстрируется создание экземпляра структуры с параметрами типов double и
//long.
