// Задача 25: 
// 1. Напишите цикл, который 
// 2. принимает на вход два числа (A и B) и 
// 3. возводит число A в **натуральную** степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите возводимое в степень число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно возвести число:");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == 0 || numA == 0 && numB == 0)
    Console.WriteLine($"Число {numA} в степени 0 равна 1");

else if (numA == 0)
    Console.WriteLine($"0 в степени {numB} -> 0");

else if (numB < 0)
{
    double negativedegreeOfNum = Math.Round(NegativeDegreeOfNum(numA, numB), 10, MidpointRounding.ToZero);
    Console.WriteLine($"Число {numA} в степени {numB} -> {negativedegreeOfNum}");
}
else
{
    int degreeOfNum = DegreeOfNum(numA, numB);
    Console.WriteLine($"Число {numA} в степени {numB} равно {degreeOfNum}");
}


int DegreeOfNum(int num, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * num;
    }
    return result;
}


double NegativeDegreeOfNum(int num, int degree)
{
    int temp = System.Math.Abs(degree);
    double result = 1;
    for (int i = 1; i <= temp; i++)
    {
        result = result * num;
    }
    result = 1 / result;
    return result;
}