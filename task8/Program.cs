// Задача 8: Напишите программу, которая 
// 1. на вход принимает число (N), 
// 2. а на выходе показывает все чётные числа 
// 3. от 1 до N.

Console.WriteLine("Введите целое число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Все целые числа от 1 до {number}: ");
int counter = 1;
while (counter <= number)
{
    if (counter % 2 == 0)
    {
        Console.Write($"{counter} ");
        counter += 2;
    }
    else counter++;
}