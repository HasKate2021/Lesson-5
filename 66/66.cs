// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int GetSumPrint(int start, int end)
{
    int sum = 0;
    if (start>end)
    {
        return sum;
    }
    Console.WriteLine($"{start}"); // визуальный вывод чисел в промежутке
    sum = start + GetSumPrint (start + 1, end);  
    return sum;
}

Console.Clear();
Console.Write("Введите число начала отсчета: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число конца отсчета: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма элементов в промежутке от {m} до {n}: {GetSumPrint(m,n)}"); 