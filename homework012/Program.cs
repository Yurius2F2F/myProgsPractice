// Задача 18: Напишите программу, которая 
// 1. по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: ");
string num = Console.ReadLine();

string result = Range(num);
Console.WriteLine(result);

string Range(string number)
{
    if (number == "1") return "x > 0 и y > 0";
    if (number == "2") return "x < 0 и y > 0";
    if (number == "3") return "x < 0 и y < 0";
    if (number == "4") return "x > 0 и y < 0";
    return "Ошибка ввода - нет такой четверти!";
}