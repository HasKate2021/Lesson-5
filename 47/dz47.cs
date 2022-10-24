//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//функция создания массива
double[,] RandomMassiv(int m, int n, int minValue, int maxValue)
{
    double[,] randomMas = new double[m, n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomMas[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue))/ 10;;
        }
    }    
    return randomMas;
}

// ф-я для печати
void PrintAr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t "); 
        }
        Console.WriteLine(); 
    }
}    

Console.Clear();

Console.Write("Введите количество строк в массиве: ");
int stroki = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int stolbci = int.Parse(Console.ReadLine()!);

double[,] vArray = RandomMassiv(stroki, stolbci, -10 , 21);
PrintAr(vArray);