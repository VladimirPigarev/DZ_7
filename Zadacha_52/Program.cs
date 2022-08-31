//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
using System.Linq;
Clear();

Write("Введите количество строк и столбцов массива через пробел :");
int[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(a=>int.Parse(a)).ToArray();
int[,] matrix = GetMatrixArray(parametrs[0], parametrs[1]);
PrintMatrixArray(matrix);
SumColumsArray(matrix);



int[,] GetMatrixArray(int m, int n)
{
    int[,] inArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(1, 10);
         }
    }
    return inArray;
}


void PrintMatrixArray(int[,] inArray1)
{
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            Write(inArray1[i, j] + " ");
        }
       Write("]");
       WriteLine("");
    }
}

void SumColumsArray(int[,] inArray2)
{
    for (int i = 0; i < inArray2.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < inArray2.GetLength(0); j++) sum += inArray2[j, i];
            {
                double averege = sum / inArray2.GetLength(0);
                WriteLine($" Сумма столбца = {sum}; Среднее арифмитическое {i+1} столбца = {averege}");
            }
    }
}