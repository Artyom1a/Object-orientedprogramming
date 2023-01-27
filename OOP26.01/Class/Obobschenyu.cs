// Задача
// Написать обобщенный класс (без ограничений)
// поле Items массив 
// метод добавления
// метод поиск индеса по значению
// удаления значения (по индексу, удаление по занчению)
// метод вывода 


// вопрос 1

// namespace Task;

// internal class Obobschenyu<T, K>
// {
//     private T A;
//     private K B;
//     public Obobschenyu(T a, K b)
//     {
//         if (A == null) throw new ArgumentNullException(nameof(A));

//         if (B == null) throw new ArgumentNullException(nameof(B));
//         A = a;
//         B = b;
//     }
//     public void Converter()
//     {
//         T C = A;
//         // Так нельзя?
//         if (int.TryParse(B.ToString(), out int D))
//         {

//         }
//         else if (int.TryParse(A.ToString(), out D))
//             A = Convert.ToInt32(B);
//         B = C;

//     }
// }


namespace Task;

internal class Obobschenyu<T, K, L>
{
    private T A;
    private K B;
    private L C;
    public Obobschenyu(T a, K b, L c)
    {
        if (A == null) throw new ArgumentNullException(nameof(A));

        if (B == null) throw new ArgumentNullException(nameof(B));
        if (C == null) throw new ArgumentNullException(nameof(C));
        // вопрос 2 так нельзя?
        // try
        // {
        //     C == 6;
        // }
        // catch(FormatException)
        // {
        //     System.Console.WriteLine("Format Exception");
        // }
        A = a;
        B = b;
        C = c;
    }
    // public void SetDataC(Func<>)
    // {

    // }
    public T Converter()
    {
        T D = A;
        return D;


    }
}