// Класс Singer
// наследует Name, Surname, также состоит из свойств Years, Birth, Style и метода
// GetMoreInfo(), который выводит информацию о певце: Years, Birth, Style.
// Необходимо вызвать метод GetMoreInfo

using WorkerWork;
namespace SingerWork;

public class Singer : Worker
{
    public int Years;
    public string Birth;
    public string Style;

    public Singer(int years, string birth, string style, string name, string surname) : base(name, surname)
    {
        Years = years;
        Birth = birth;
        Style = style;
    }
    public void GetMoreInfo()
    {
        System.Console.WriteLine($"{Name},{Surname}, -{Birth}- {Years}, {Style}");
    }
}

