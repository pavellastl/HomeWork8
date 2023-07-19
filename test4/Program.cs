using System;
using static System.Console;
int[,,] GetArray(int m, int n, int b, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, b];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < b; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
            
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k]} ({i},{j},{k}); ");
            }
            
        }
        WriteLine();
    }
}
WriteLine("Введите колличество строк");
int rows = int.Parse(ReadLine());
WriteLine("Введите колличество Столбцов");
int colomns = int.Parse(ReadLine());
WriteLine("Введите колличество строк в глубь");
int shapeRows = int.Parse(ReadLine());
int[,,] cubeMatrix = GetArray(rows, colomns, shapeRows, 0, 9);
PrintArray(cubeMatrix);

