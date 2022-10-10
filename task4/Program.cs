// Задача 4: Напишите программу, которая 
// 1. принимает на вход три числа 
// 2. и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"Число {number1} является максимальным");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"Число {number2} является максимальным");
}
else Console.WriteLine($"Число {number3} является максимальным");