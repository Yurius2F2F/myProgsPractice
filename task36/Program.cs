﻿// Задача 36. 
// 1. Задайте одномерный массив, 
// 2. заполненный случайными числами. 
// 3. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumOddIndex(int[] array)
{
    int sum = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(6, 0, 100);
PrintArray(arr);

int sumOddIndex = SumOddIndex(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {sumOddIndex}");