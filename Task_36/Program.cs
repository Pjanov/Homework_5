/* =====> Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0     */


void FillArray(int[] collection) // Этот метод заполняет массив случайными числами от 1 до 99
{
    int length = collection.Length; // Команда, узнать кол-во элементов в массиве
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col) // Этот метод выводит по порядку значения массива в терминал  
{
    int count = col.Length;
    int i = 0;
    Console.Write("[");
    while (i < count)
    {
        Console.Write($"{col[i]}{(i != count - 1 ? ", " : "")}"); // вывод в терминал
        i++;
    }
    Console.Write("]");
}

void EvenElements(int[] collection) // Этот метод выводит сумму нечетных элементов  
{
    int length = collection.Length;
    int sum = 0;

    for (int i = 0; i < length; i++)
    {
        if (i % 2 > 0) sum += collection[i];
    }

    Console.Write($" -> {sum}");
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
EvenElements(array);

