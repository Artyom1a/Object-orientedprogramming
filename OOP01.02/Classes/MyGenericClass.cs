using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    // Обобщенный класс
    public class MyGenericClass<T>
    {
        // Обобщенные переменные
        private T a, b;

        // Конструктор
        public MyGenericClass()
        {
            // Присвоение значения по умолчанию переменным a, b
            a = default(T);
            b = default(T);
        }
    }
}
