// Задача 27. Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = default;
    int lastNumber = default;

    while (num > 0)
    {
        lastNumber = num % 10;
        sum = sum + lastNumber;
        num = num / 10;
    }
    return sum;
}