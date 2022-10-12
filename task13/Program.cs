// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа 
// 2. или сообщает, что третьей цифры нет. 
// 3. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    int thirdDigit = number % 10;
    Console.WriteLine($"Третья цифра от введеного числа: {thirdDigit}");
}