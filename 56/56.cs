// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] RandomAr(int m, int n, int minVal, int maxVal) //функция создания массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr) // ф-я для печати
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void SumRowMin(int[,] arr2) // ищет строку с минимальной суммой
{
    
    int numRow = 0;
    int sumRow = 0;
    int min = 0;
    for(int j=0; j < arr2.GetLength(1); j++)//считает сумму элементов в 1 строке для последующего сравнения
        {
            min += arr2[0, j];
        }
        
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for(int j=0; j < arr2.GetLength(1); j++)//считает сумму элементов в строке
        {
            sumRow += arr2[i, j];
        }
        Console.WriteLine(sumRow);
        if (sumRow < min)
        {
            min = sumRow;
            numRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {numRow+1} строка  ");
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine()!);

if (row == col) //проверка на прямоугольник
{
    Console.Write("Данные числа представляют собой квадрат, введите числа для прямоугольника, например 5 и 7, 3 и 4...");
    return;
}

int[,] userArray = RandomAr(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine();
SumRowMin(userArray);
