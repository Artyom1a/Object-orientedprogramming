// Реализовать следующие классы Круг, Треугольник и Квадрат. Каждый экземпляр
// +класса должен содержать свойства Площадь, Периметр и Имя (свойства
// родительского класса). Создвать массив из фигур и вывести всю информацию о
// фигурах в консоль. Площадь и периметр должны рассчитываться по
// математическим формулам

namespace FigureWork;

public class Circle : Figure
{
    private double Radius;

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }
    public override void Square()
    {
        double square = Math.PI * Radius * Radius;
        System.Console.WriteLine($"Circle {Name} square = {square:N2}");
    }
    public override string ToString()
    {
        return $"Circle {Name}";
    }
}