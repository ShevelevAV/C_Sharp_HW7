/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Search(int[,] arr, int a, int b)
{
    if (a <= arr.GetLength(0)-1)
    {
        if (b <= arr.GetLength(1) - 1)
        {
            Console.WriteLine($"{a} {b} -> {arr[a, b]}");
        }
    }
    else
    {
        Console.WriteLine($"{a} {b} -> такого числа нет");
    }
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите строку: ");
int rx = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец: ");
int cy = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Search(array, rx, cy);