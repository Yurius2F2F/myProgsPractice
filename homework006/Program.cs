// Задача 9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] 
// 2. и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8

// Решение 1
int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");

// int firstDigit = number / 10; // 78 / 10 = 7.8 -> 7
// int secondDigit = number % 10; // 78 % 10 = 8 - остаток
// if (firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

// Решение 2
int MaxDigit(int number)
{
    int firstDigit = number / 10; // 78 / 10 = 7.8 -> 7
    int secondDigit = number % 10; // 78 % 10 = 8 - остаток
    if (firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
    // можно или так:
    // else if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    // или так:
    // return firstDigit > secondDigit ? firstDigit : secondDigit;
    // или вообще так:
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа = {maxDigit}");

// int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа = {res}");

