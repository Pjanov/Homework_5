/* =====> Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2     */


void FillArray(int[] collection) // Этот метод заполняет массив случайными числами от 100 до 999
{
    int length = collection.Length; // Команда, узнать кол-во элементов в массиве
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
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

void EvenNumbers(int[] array) // Этот метед выводит кол-во четных чисел в массиве.
{
    int even = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    Console.Write($" -> {even}");
}

int[] array = new int[5];

FillArray(array); 
PrintArray(array); 
EvenNumbers(array);