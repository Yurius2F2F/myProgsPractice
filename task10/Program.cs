// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число 
// 2. и на выходе показывает вторую цифру этого числа. 
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int tmp = number / 10;
    int middleDigit = tmp % 10;
    Console.WriteLine($"Средняя цифра числа {number} это - {middleDigit}");
}
else Console.WriteLine($"Число {number} не трёхзначное!");