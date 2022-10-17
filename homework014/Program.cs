// Задача 22: Напишите программу, которая
// 1. принимает на вход число (N)
// 2. и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите количество чисел, которые необходимо возвести в квадрат: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    Console.WriteLine(Square(count));
    count++;
}
string Square(int number)
{
    return ($"|{number, 4} | -> |{number * number, 5}|");
}