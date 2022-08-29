// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
using System.Linq;
Clear(); 

Write("Введите количество строк и столбцов через пробел :");
int[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(a=>int.Parse(a)).ToArray();

double[,] matrix = GetMatrixArray(parametrs[0], parametrs[1]);
PrintMatrixArray(matrix);



double[,] GetMatrixArray(int m, int n)
{
    double[,] result = new double [m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(-5, 10))/10;
        }
    }
    return result;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write(inArray[i, j] + " ");
        }
       Write("]");
       WriteLine("");
    }
}


