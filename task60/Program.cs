// Задача 60. 
// 1. Сформируйте трёхмерный массив 
// 2. из неповторяющихся двузначных чисел. 
// 3. Напишите программу, которая будет построчно выводить массив, 
// 4. добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k] ,4} ({i},{j},{k}) ");
            else Console.Write($"{matrix[i, j, k],4} ({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}


int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 1, 100);
PrintMatrix(array3D);