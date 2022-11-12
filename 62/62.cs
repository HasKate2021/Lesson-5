//  Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] RandomAr(int s, int minVal, int maxVal) //функция создания массива
{
    int[,] array = new int[s, s];
    int i = 0, j = 0;
    int size = s;

    for (int num = 1;num < (s * s);num++)
    {
        int k = 0;
        for (k = 0; k < size - 1; k++) array[i, j++] = num++;
        for (k = 0; k < size - 1; k++) array[i++, j] = num++;
        for (k = 0; k < size - 1; k++) array[i, j--] = num++;
        for (k = 0; k < size - 1; k++) array[i--, j] = num++;
        ++i; ++j;
        if(size>2)size=size-2;
    }
    return array;
}

void PrintArray(int[,] arr) // ф-я для печати
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < 10)
            {
                Console.Write("0" + $"{arr[i, j]}\t");
            }
            else Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int size = 4;
int[,] userArray = RandomAr(size, 1, 20);
PrintArray(userArray);


