namespace consoleapplication.MyClasses;  // Note: actual namespace depends on the project name.

public class CustomCalculator
{
    private int e;
    public int w = 48;
    public int SumNumbers(int x, int y)
    {
        return x + y;
    }
    public double SumNumbers(double x, double y)
    {
        return x + y;
    }
    public void SetE(int e)
    {
        this.e = 41;
        e = 51;  // 1. Почему оно не хватает 51? Мы берём private int e закидываем его в сет, но с помощью this оно только преобразовывает
    }
    public int GetE()
    {
        e = 61;
        return e;
    }

    private int b;

    public int B
    {
        get
        {
            return b;
        }
        set
        {
            if (value < 1)
            {
                b = 1;
                return;
            }
            if (value > 5)
            {
                b = 5;
                return;
            }
            b = value;
        }
    }
    //2. Вся логика get set в том, чтобы создавать копию переменной работать с переменной, а потом присвоить,
    //    что получилось обратно переменной?  
    //3. get set для private ?
    public int R { get; set; }

    public int Proverka()
    {
        int d=-41;
        d= this.w +d;     //4. Смысл от this, без него такая же логика или тут логика (Передача параметров. Класс != метод). Передавая переметр в конструктор вы создаете поле класса, к которому можно
// обратиться из всей области видимости класса через this. 
// https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/this  Для передачи другим методам объекта в качестве параметра, например: CalcTax(this);
// (передается такая же переменная, которая была условно задана изначально?)

// 5. Если модификатор доступа не указан, по умолчанию используется internal. (Раньше было private?)

        return d;
    }

}

