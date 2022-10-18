// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. и проверяет, является ли оно палиндромом.
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// вот решение для пятизначных чисел
Console.WriteLine("Введите пятизначное число для проверки на палиндромность: ");
int number = Convert.ToInt32(Console.ReadLine());
int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number / 1000 % 10;
int a5 = number / 10000 % 10;
int temp = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
if (temp == number)
{
    Console.WriteLine($"ДА, число {temp} является палиндромом");
}
else Console.WriteLine($"НЕТ, число {temp} НЕ является палиндромом");

// вот решение для любых чисел:

// Console.WriteLine("Введите любое число для проверки на палиндромность: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int ostatok = 0;
// int sum = 0;
// int temp = number;

// while (number > 0)
// {    
//     ostatok = number % 10;
//     sum = (sum * 10) + ostatok;
//     number = number / 10;
// }
// if (temp == sum)
// {
//     Console.WriteLine($"ДА, число {temp} является палиндромом");
// }
// else Console.WriteLine($"НЕТ, число {temp} НЕ является палиндромом");