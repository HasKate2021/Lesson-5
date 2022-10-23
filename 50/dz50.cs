// Напишите программу, которая на вход принимает число 
// и возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.

int[,] GetArray()
{
    int[,] result = new int[4, 3];

    for (int i = 0; i < 4; i++)
        for (int j = 0; j < 3; j++)
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
            Console.Write($"{inArray[i, j]}\t "); // для красивого вывода строчки под строчкой добавили \t
        }
        Console.WriteLine(); // для красоты пробел
    }
}

//ф-ия поиска числа в массиве
void Search(int n, int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (array2[i, j] == n)
            {
                Console.Write($"число {n} найдено в строке {i+1} столбце {j+1}  ");
                Console.WriteLine();
                return;
            }
            else 
            {
                if (i == array2.GetLength(0)-1 && j == array2.GetLength(1)-1)
                Console.Write("Число не найдено ");
            }    
        }  
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int[,] array = GetArray();
PrintArray(array);
Search(N, array);

