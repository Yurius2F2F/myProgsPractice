// Задача 2: Напишите программу, которая 
// 1. на вход принимает два числа 
// 2. и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Число {number1} является большим, а число {number2} является меньшим");
}
else Console.WriteLine($"Число {number2} является большим, а число {number1} является меньшим");