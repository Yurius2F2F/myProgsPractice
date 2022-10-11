// Задача 12. Напишите программу, которая 
// 1. будет принимать на вход два числа 
// 2. и выводить, является ли второе число кратным первому. 
// 3. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int ostatok = number1 % number2 ;
if (ostatok == 0)
    Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно, иди, попей чаёк и подумай ещё");