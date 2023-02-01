using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class DoubleTypes<T1,T2>
    {
        private T1 Var1;
        private T2 Var2;

        public DoubleTypes(T1 var1, T2 var2)
        {
            Var1 = var1;
            Var2 = var2;
        }
        public void Print()
        {
            Console.WriteLine("var1 = {0}", Var1);
            Console.WriteLine("var2 = {0}", Var2);
        }
    }
}

//+Объявляется класс DoubleTypes<T1, T2>, который получает параметрами два типа с именами T1, T2.
//+В классе объявляются следующие элементы:

//+внутренние поля var1, var2 соответственно типов T1, T2;
//+конструктор;
//метод Print(), выводящий значения полей var1, var2.