// 11. Напишите программу, которая 
// 1. выводит случайное трёхзначное число 
// 2. и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100 - 999 => {number}");

int firstDigit = number / 100; // 456 / 100 = 4.56 -> 4
int secondDigit = number % 10; // 456 % 10 = 6 - остаток
Console.WriteLine($"Двухзначное число без среднего = {firstDigit}{secondDigit}");

// еще можно так:
// int twoDigits = firstDigit * 10 + secondDigit;
// Console.WriteLine($"Двухзначное число без среднего = {twoDigits}");