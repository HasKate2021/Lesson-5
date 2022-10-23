//Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами

int[,] GetArray(int m, int n, int minValue, int maxValue) // мин и макс для интервала рандома чисел
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

// ф-я для печати красивой таблички на экран
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t "); // для красивого вывода строчки под строчкой добавили \t
        }
        Console.WriteLine(); // для красоты пробел
    }
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10); // 0 и 10 интервал для рандомных чисел
PrintArray(array);