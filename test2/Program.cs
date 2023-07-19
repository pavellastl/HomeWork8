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
int plusRow(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
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

int minSumm = -1;
int result = 0;
for (int i = 0; i < rows; i++)
{
    int[] rowAr = GetRow(matrix, i);
    int summ = plusRow(rowAr);

    if(summ < minSumm || minSumm == -1)
    {
        minSumm = summ;
        result = i;
    }

}
WriteLine(result);



