// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Поменяем местами первую и последнюю строку:");
Console.WriteLine();
int[,] array88 = ChangeArray(array);
PrintArray(array88);

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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ChangeArray(int[,] inArray)
{
    int[,] newArray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < inArray.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i != 0)
            {
                newArray[i, j] = inArray[i, j];
            }
            else
            {
                temp = inArray[i, j];
                newArray[i, j] = inArray[inArray.GetLength(0) - 1, j];
                newArray[inArray.GetLength(0) - 1, j] = temp;
            }
        }
    }
    return newArray;
}