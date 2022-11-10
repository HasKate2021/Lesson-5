//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortAr(int[,] UserArr)
{
    for (int i = 0; i < UserArr.GetLength(0); i++)
    {
        for (int j = 0; j < UserArr.GetLength(1); j++)
        {
            for (int s = j+1; s <  UserArr.GetLength(1); s++)
                if (UserArr[i,j] < UserArr[i,s])
                {
                    int k = UserArr[i,j];
                    UserArr[i,j] = UserArr[i,s];
                    UserArr[i,s] = k;
                }
        }
    }
    return UserArr;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int col = int.Parse(Console.ReadLine()!);

int[,] userArray = RandomAr(row, col, 0, 10);
PrintArray(userArray);
Console.WriteLine();
int[,] sortedUserArray = SortAr(userArray);
PrintArray(sortedUserArray);
