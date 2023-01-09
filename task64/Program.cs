﻿// 1.Задайте значение N. 
// 2. Напишите программу, которая выведет все натуральные числа 
// 3. в промежутке от N до 1. 
// 4. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number <= 0)
{
    Console.WriteLine("Число должно быть натуральным. Повторите ввод:");
    number = Convert.ToInt32(Console.ReadLine());
}

void NaturalNumbers(int num)
{
    if (num == 0) return;
    if (num ==1)
    Console.Write($"{num} ");
    else
    Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
}

NaturalNumbers(number);