// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, 
// 2. обозначающую день недели, 
// 3. и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
switch(numberOne)
{
    case 1:
        Console.WriteLine("Нет"); //Понедельник
        break;
    case 2:
        Console.WriteLine("Нет"); //Вторник
        break;
    case 3:
        Console.WriteLine("Нет"); //Среда
        break;
    case 4:
        Console.WriteLine("Нет"); //Четверг
        break;
    case 5:
        Console.WriteLine("Нет"); //Пятница
        break;
    case 6:
        Console.WriteLine("Да"); //Суббота
        break;
    case 7:
        Console.WriteLine("Да"); //Воскресенье
        break;
    default:
        Console.WriteLine("Нет такого дня недели");
        break;
}