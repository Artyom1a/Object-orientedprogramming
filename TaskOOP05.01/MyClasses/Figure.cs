// Реализовать следующие классы Круг, Треугольник и Квадрат. Каждый экземпляр
// +класса должен содержать свойства Площадь, Периметр и Имя (свойства
// родительского класса). Создвать массив из фигур и вывести всю информацию о
// фигурах в консоль. Площадь и периметр должны рассчитываться по
// математическим формулам

namespace FigureWork;

public class Figure
{
    public string Name { get; private set; }
    // public double Perimeter { get; set; }
    // public double Area { get; set; }
    public Figure(string name)
    //, double perimeter, double area
    {
        Name = name;
        // Perimeter = perimeter;
        // Area = area;
    }
    public virtual void Square()
    {
        System.Console.WriteLine($"{Name} error square");
    }
}