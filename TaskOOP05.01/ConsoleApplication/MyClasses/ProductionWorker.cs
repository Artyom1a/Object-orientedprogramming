// +Затем напишите класс ProductionWorker (Рабочий), который является подклассом
// +класса Ernployee. Класс ProductionWorker должен содержать атрибуты
// +приведенных ниже данных:
// +• номер смены (целое число, к примеру, 1, 2 или 3);
// +• ставка почасовой оплаты труда.
// +Рабочий день разделен на две смены: дневную и вечернюю. Атрибут смены будет
// +содержать целочисленное значение, представляющее смену, в которую
// +сотрудник работает. Дневная смена является сменой 1, вечерняя смена –
// +сменой 2.
// Напишите соответствующие методыполучатели и методы-модификаторы для
// каждого класса.
// После того как эти классы будут написаны, напишите программу, которая создает
// объект класса ProductionWorker и предлагает пользователю ввести данные по
// каждому атрибуту данных этого объекта. Сохраните данные в объекте и
// примените в этом объекте методы получатели, чтобы получить эти данные и
// вывести их на экран. 
namespace ProductionWorkerWork;
using EmployeeWork;

public class ProductionWorker : Employee
{
    public int IdSmen;
    public int StavkaHr;

    public ProductionWorker[] array;
    // public Employee[] array;
    public ProductionWorker(int id, int idsmen, string name, int stavkahr)
    {
        Name = name;
        Id = id;
        IdSmen = idsmen;
        StavkaHr = stavkahr;
    }

    public ProductionWorker()
    {
        array = new ProductionWorker[2];
        array[0] = new ProductionWorker(Id = 1, IdSmen = 1, Name = "Artyom", StavkaHr = 7);
        array[1] = new ProductionWorker(Id = 2, IdSmen = 2, Name = "Stepan", StavkaHr = 5);
    }


    public ProductionWorker[] Giveinarray(int id, string name, int idsmen, int stavkahr)
    {
        ProductionWorker[] arraynew = new ProductionWorker[array.Length + 1];
        Array.Copy(array, arraynew, array.Length);
        arraynew[array.Length] = new ProductionWorker(Id = id, IdSmen = idsmen, Name = name, StavkaHr = stavkahr);
        array = arraynew;
        return array;
    }
    public void Vyvod()
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine($"{array[i].Id}, {array[i].IdSmen}, {array[i].Name}, {array[i].StavkaHr}");
        }
    }

}