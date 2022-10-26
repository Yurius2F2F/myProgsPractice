// Задача 28: Напишите программу, которая
// 1. принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiplication(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        // проверяем на переполнение перед выдачей результата
        checked
        {
        prod = prod * i;
        // prod *= i;
        }
    }
    return prod;
}

int multiplication = Multiplication(number);
Console.WriteLine($"Результат произведения от 1 до {number} = {multiplication}");

// решение от преподавателя

// long Factorial(long num)
// {
// long fact = 1;
// int i;
// for (i = 1; i <= num; i++)
// {
// try
// {
// checked
// {
// fact = fact * i;
// }
// }
// catch (Exception)
// {
// System.Console.WriteLine("Переполнение типа!");
// break;
// }
// }

// System.Console.WriteLine($"Факториал числа {i - 1} = {fact}");
// return fact;
// }