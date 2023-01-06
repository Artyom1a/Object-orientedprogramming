// // 8.Реализуйте класс Conversion содерж метод +ToBinaryNumber, преобразующий все числа 10 системы
// // счисления в 2, метод ToHexadecimalNumber, преобразующий все числа 10 системы в 16, 
// // метод ToOctalNumber, преобразующий все числа 10 системы счисления в 8.

// // 9. Реализуйте класс Conversion содерж метод +ToDecimalNumber, преобразующий все числа 2 системы
// // счисления в 10, метод ToHexadecimalNumber1, преобразующий все числа 2 системы в 16, 
// // метод ToOctalNumber1, преобразующий все числа 2 системы счисления в 8.

// // 10. Реализуйте класс Conversion содерж метод +ToDecimalNumber, преобразующий все числа 16 системы
// // счисления в 10, метод ToBinaryNumber, преобразующий все числа 16 системы в 2, 


using NewCalculator;
namespace NewConversion;

public class Conversion
{

    public int chislo;

    //из 10 в другие
    public string ToBinaryNumber(int chislo)
    {
        object[] array = { 0, 1 };
        string numberin = "";

        while (chislo >= 1)
        {
            numberin += array[chislo % array.Length].ToString();
            chislo /= array.Length;
        }
        return new string(numberin.Reverse().ToArray());
    }
    public string ToHexadecimalNumber(int x)
    {
        object[] array16 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" };
        string numberin = "";
        while (x >= 1)
        {
            numberin += array16[x % array16.Length].ToString();
            x /= array16.Length;
        }
        return new string(numberin.Reverse().ToArray());
    }
    //из 2 в другие
    // 9. Реализуйте класс Conversion содерж метод +ToDecimalNumber, преобразующий все числа 2 системы
    // счисления в 10, метод ToHexadecimalNumber1, преобразующий все числа 2 системы в 16, 
    // метод ToOctalNumber1, преобразующий все числа 2 системы счисления в 8.

    public string ConvertOf2To16(params char[] array)
    {
        int chislov10 = 0;
        string str1 = string.Join("", array);
        System.Console.WriteLine(str1);
        chislov10 = Convert.ToInt32(str1, 2);
        str1 = Convert.ToString(chislov10, 16);
        return str1;
    }

    // static void Task8()
    // {
    //     System.Console.WriteLine("Task8");
    //     string? str = Console.ReadLine();
    //     char[] array = new char[str.Length - 1];
    //     if (!string.IsNullOrEmpty(str))
    //     {
    //         array = str.ToCharArray();
    //         // for (int i =0; i<array.Length;i++)
    //         // {
    //         // System.Console.WriteLine(array[i]);
    //         // }
    //         System.Console.WriteLine(ConvertOf2To16(array));
    //     }
    //     else
    //     {
    //         System.Console.WriteLine("Вы ввели пустоту или налл");
    //     }

}




