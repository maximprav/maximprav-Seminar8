// Задача 57: 
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();
Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine()!)!;
Console.WriteLine("Введите количество столбцов массива:");
int columns = int.Parse(Console.ReadLine()!)!;

int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
CheckArray(array);


int CheckArray(int[,] inArray)
{
    int maxNumber = 10;
    int minNumber = 1;
    int count = 0;
    while (minNumber <= maxNumber)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                if (minNumber == inArray[i, j])
                {
                    count++;
                }
            }
        }
        if (count == 0)
        {
            Console.Write("");
        }
        else if (count > 1 && count < 5)
        {
        Console.WriteLine($"Значение {minNumber} встречается {count} раза");
        }
        else
        {
        Console.WriteLine($"Значение {minNumber} встречается {count} раз");
        }
        minNumber++;
        count = 0;
    }
    return count;
}

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

