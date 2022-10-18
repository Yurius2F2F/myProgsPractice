// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) 
// 2. и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите количество чисел, которые необходимо возвести в куб: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= num)
{
    Console.WriteLine(Cube(count));
    count++;
}
string Cube(int number)
{
    return ($"|{number, 4} | -> |{number * number * number, 5}|");
}