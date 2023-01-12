
// +Создать класс Tiles (кафель), который будет содержать свойства с открытым
// +доступом: B rand , S ize H , S ize W , P rice,
// +метод класса G etData() возвращающий
// полную информацию о плитке и 
//метод класса G et CountTiles () принимающий
// площадь и возвращающий количество клиток необходимое для данной площади.
// В главном методе объявить пару объектов класса и внести данные в поля. Затем
// отобразить их, вызвав методы G etData () и G et CountTiles ().

namespace Incapsulation;

public class Tiles
{
    public string Brand { get; set; }
    public double SizeH { get; set; }
    public double SizeW { get; set; }
    public double Price { get; set; }

    public Tiles(string brand, double sizeH, double sizeW, double price)
    {
        Brand = brand;
        SizeH = sizeH;
        SizeW = sizeW;
        Price = price;
    }

    public void Vyvod()
    {
        System.Console.WriteLine($"Brand-{Brand}SizeH-{SizeH}SizeW-{SizeW},pice-{Price}");
    }

    public string GetData()
    {
        return $"Brand-{Brand}SizeH-{SizeH}SizeW-{SizeW},pice-{Price}";
    }

    public double GetCounTitles(double square)
    {
        double kol;
        return kol = square / (SizeH * SizeW);
    }
}

