// Задача 6: Напишите программу, которая 
// 1. на вход принимает число 
// 2. и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");