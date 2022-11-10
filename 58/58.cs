// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

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

int [,] ProizvTwoArray (int [,] ar1 , int [,] ar2, int m, int n) //ф-ия подсчета произведения элементов массивов 
{
    int [,] proizvodnAray = new int [m,n];
    for (int i = 0; i < proizvodnAray.GetLength(0); i++)
    {
        for (int j = 0; j < proizvodnAray.GetLength(1); j++)
        {
            proizvodnAray[i,j]=ar1[i,j]*ar2[i,j];
        }
    }
    return proizvodnAray;
}

Console.Clear();
int row = 3;
int col = 3;
int[,] userArray = RandomAr(row, col, 0, 5);
PrintArray(userArray);
Console.WriteLine("------------------");
int[,] userArray2 = RandomAr(row, col, 0, 5);
PrintArray(userArray2);
Console.WriteLine("Производное двух матриц: ");
int[,] Proizv = ProizvTwoArray(userArray,userArray2,row,col);
PrintArray(Proizv);