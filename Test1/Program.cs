using System;
using static System.Console;
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
int[] SortArray(int[] array)
{
    bool founded_unsorted = false;
    do
    {
        founded_unsorted = false;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                int k = array[i];
                array[i] = array[i + 1];
                array[i + 1] = k;
                founded_unsorted = true;
            }
        }

    } while (founded_unsorted);



    return array;
}


int[] GetRow(int[,] matr, int row)
// Возвращет строку из двумерного массива под номером row 
{
    if (matr.GetLength(0) <= row)
        return new int[0];

    int[] row_res = new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        row_res[i] = matr[row, i];
    }

    return row_res;
}

WriteLine("Введите колличество строк");
int rows = int.Parse(ReadLine());
WriteLine("Введите колличество столбцов");
int colomns = int.Parse(ReadLine());
int[,] matrix = GetArray(rows, colomns, 0, 9);
PrintArray(matrix);
WriteLine();
int[,] result = new int[rows, colomns];
for (int i = 0; i < rows; i++)
{
    int[] unsorted = GetRow(matrix, i);
    int[] sorted = SortArray(unsorted);
    for (int j = 0; j < colomns; j++)
    {
        int a = sorted[j];
        result[i, j] = a;
    }

}
PrintArray(result);



