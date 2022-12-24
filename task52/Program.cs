/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
double[] averValue(int[,] aV, int rw, int col)
{

    double[] res = new double[col];
    for (int i = 0; i < aV.GetLength(0); i++)
    {
        for (int j = 0; j < aV.GetLength(1); j++)
        {
            res[j] = res[j] + aV[i, j];
        }
    }
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = Math.Round(res[i] / rw, 2);
    }

    return res;
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] result = averValue(array, rows, columns);
Console.WriteLine();
Console.WriteLine(string.Join(" ", result)!);