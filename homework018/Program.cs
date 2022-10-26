// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами 
// 3. в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] array = new int[8];
int [] FillArray(int[] arr)
{
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0,2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

int[] myArray = FillArray(array);
PrintArray(myArray);

// int[] FillArray(int num)
// {
// int[] array = new int[num];
// Random rnd = new Random();
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = rnd.Next(0, 2);
// }
// return array;
// }

// void PrintArray(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// Console.Write($"{arr[i]}, ");
// }
// }

// int[] myArr = FillArray(8);
// PrintArray(myArr);