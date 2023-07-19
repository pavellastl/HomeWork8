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
int[] GetMerge(int[] array1, int[] array2)
{
    int[] result = new int[array1.Length];

    for (int i = 0; i < array1.Length; i++)
    {
        result[i] = array1[i] * array2[i];
    }

    return result;


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
int[,] matrix1 = GetArray(rows, colomns, 0, 9);
int[,] matrix2 = GetArray(rows, colomns, 0, 9);
PrintArray(matrix1);
WriteLine();
PrintArray(matrix2);
WriteLine();


int[,] result = new int[rows, colomns];
for (int i = 0; i < rows; i++)
{
    int[] rowAr1 = GetRow(matrix1, i);
    int[] rowAr2 = GetRow(matrix2, i);
    int[] resultRow = GetMerge(rowAr1, rowAr2);
    for (int j = 0; j < colomns; j++)
    {
        int a = resultRow[j];
        result[i, j] = a;
    }

}
WriteLine();
PrintArray(result);




