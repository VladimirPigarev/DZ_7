// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using static System.Console;
using System.Linq;
Clear();

Write("Введите номер строки массива: ");
int i = Convert.ToInt32(ReadLine());
Write("Введите номер столбца массива: ");
int j = Convert.ToInt32(ReadLine());

int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);

if(i < matrix.GetLength(0) && j < matrix.GetLength(1))
{
    WriteLine($"{matrix[i, j]}");
}
else 
{
    WriteLine($"строка {i} столбец {j} -> такой позиции в массиве нет");
}

void FillMatrix(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 5);
        }
    }
}

void PrintMatrix(int[,] inArray)
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
