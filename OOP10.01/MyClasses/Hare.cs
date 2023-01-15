// 5. +Построить три класса (базовый и 3 потомка), описывающих некоторых хищных
// животных (один из потомков), всеядных(второй потомок) и травоядных (третий
// потомок). 
//+Описать в базовом классе метод для расчета количества и типа пищи,
// +необходимого для пропитания животного в зоопарке.
// * Упорядочить всю последовательность животных по убыванию количества пищи.
// При совпадении значений – упорядочивать данные по алфавиту по имени.
// Вывести идентификатор животного, имя, тип и количество потребляемой пищи
// для всех элементов списка.
// * Вывести первые 5 имен животных из полученного в пункте списка.
// * Вывести последние 3 идентификатора животных из полученного в пункте
// списка. 


namespace Animales;

public class Hare : Animal
{

    public Hare(int weightAnimal, int normaForWAnimal)
    {
        WeightAnimal = weightAnimal;
        NormaForWAnimal = normaForWAnimal;
    }

    protected override string AmountFood()
    {
        AmountMilk = NormaForWAnimal * WeightAnimal;
        return $"Hare require grass - {AmountMilk}";
    }

}