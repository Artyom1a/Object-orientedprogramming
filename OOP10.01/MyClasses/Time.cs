// +Составить описание класса для представления времени. +Предусмотреть
// +возможности установки времени и изменения его отдельных полей (час, минута,
// +секунда) с проверкой допустимости вводимых значений. В случае недопустимых
// +значений полей выбрасываются исключения. Создать методы изменения
// времени на заданное количество часов, минут и секунд.


namespace Times;

public class Time
{

    protected int Hour;
    protected int Minute;
    protected int Sec;


    public Time(int hour, int minute, int sec)
    {
        if (hour <= 24 && hour >= 0 && minute <= 60 && minute >= 0 && sec <= 60 && sec >= 0)
        {
            Hour = hour;
            Minute = minute;
            Sec = sec;
        }
        else
        {
            System.Console.WriteLine("Error");
        }
    }

    internal int TimeCorrectHour(int correcthour)
    {
        Hour = correcthour + Hour;
        if (Hour <= 24 && Hour >= 0)  // можно ли это в поле куда-то кинуть или конструктор, чтобы 
        // чтобы дубля не было
        {
            return Hour;
        }
        return default;
    }

    public string TimeNow()
    {
        return $"Time now is {Hour}:{Minute}:{Sec}";
    }

}