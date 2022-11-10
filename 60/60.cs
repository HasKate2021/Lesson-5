// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

bool Clon(int[,,] array, int el) //ищет клон рандомного числа
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                if (array[i, j, l] == el) return true;
            }
        }
    }
    return false;
}    

int[,,] RandomAr(int m, int n, int p, int minVal, int maxVal) //функция создания массива
{
    int[,,] result = new int[m, n, p];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < p; l++)
            {

                int num = new Random().Next(minVal, maxVal + 1);
                if (Clon(result, num)) continue; //если есть похожий элемент - возвращается
                result[i, j, l] = num;
            }
        }
    }
    return result;
}

    void PrintArray(int[,,] arr) // ф-я для печати
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int l = 0; l < arr.GetLength(2); l++)
                {
                    Console.Write($"{arr[i, j, l]} ({i},{j},{l})\t");
                }
                Console.WriteLine();
            }
        }
    }

    Console.Clear();
    int row = 2;
    int col = 2;
    int pl = 2;
    int[,,] userArray = RandomAr(row, col, pl, 10, 100);
    PrintArray(userArray);


