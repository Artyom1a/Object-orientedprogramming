using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {

        public string Name;

        public virtual void makeSound()
        {
            Console.WriteLine("sound");
        }
    }
}
//1.
//Создайте класс Animal с полем name. Добавьте метод makeSound(), который выводит на
//консоль звук, издаваемый животным. Создайте классы Dog и Cat, которые наследуются от
//Animal и переопределяют метод MakeSound() для воспроизведения соответствующих звуков.
