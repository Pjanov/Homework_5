/* =====> Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76     */

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
        Console.Write($"{col[i]}{(i != count - 1 ? " " : "")}");
        i++;
    }
    Console.Write("]");
}

void Difference(int[] collection) // Этот выводит разницу между max и min элементов массива
{
    int min = collection[0];
    int max = collection[0];
    foreach (int i in collection)  // Поиск максимального и минимального значения
    {
        if (min > i) min = i;
        if (max < i) max = i;
    }
    Console.WriteLine($" -> {max - min}");
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Difference(array);
