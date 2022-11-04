// Задача 41. 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int i = 1;
while (i - 1 < number)
{
    Console.WriteLine($"Введите {i}-е число:");
    array[i - 1] = Convert.ToInt32(Console.ReadLine());
    i++;
}

int AboveZero(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }

    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int result = AboveZero(array);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 -> {result}");