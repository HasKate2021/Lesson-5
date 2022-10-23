// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GetArray(int a, int b)
{
    int[,] result = new int[a, b];

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }

    return result;
}

// ф-я печати массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t "); 
        }
        Console.WriteLine(); 
    }
}

//нахождение среднего арифметического
void SrArifmetic (int[,] array2)
{
    for (int l = 0; l < array2.GetLength(1); l++)
    {
        double sum = 0;
        for (int i=0; i<array2.GetLength(0); i++)
        {
            sum += array2 [i,l];
        }
        Console.Write($"сумма столбца {l+1} = {sum}  ");
        Console.Write($"среднее арифметическое: {sum/array2.GetLength(1):F2}  ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер строк: ");
int stroki = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер столбцов: ");
int stolbci = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(stroki,stolbci);
PrintArray(array);
SrArifmetic (array);
