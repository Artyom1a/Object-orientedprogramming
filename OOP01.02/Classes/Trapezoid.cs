using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    // Обобщенный класс, реализующий трапецию
    public class Trapezoid<T>
    {
        private T A; //lenght1
        private T B, C; //lenght2 // high

        // конструктор
        public Trapezoid(T _a,T _b,T _c)
            {
            this.A = _a;
            this.B = _b;
            this.C = _c;
            }
        // метод вовзвращающий площадь трапеции
        public double Area()
        {
            double A = Convert.ToDouble(this.A);
            double B = Convert.ToDouble(this.B);
            double C = Convert.ToDouble(this.C);
            return (A + B) * C / 2; ;
        }

    }
}

    

    

//+Объявить обобщенный класс, который описывает Трапецию. Класс должен быть обобщенным и
//+оперировать некоторым типом T (класс получает параметром тип T).

//+В классе реализовать следующие элементы:

//+внутренние поля a, b, h, определяющие соответственно длины сторон и высоту трапеции;
//+конструкторы;
//свойства A, B, H для доступа к внутренним полям;
//метод Area(), возвращающий площадь трапеции.