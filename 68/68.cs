// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int AnkerNumber(int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    else if (n == 0 && m > 0)
    {
        return AnkerNumber(m - 1, 1);
    }
    else 
    {
        return (AnkerNumber(m - 1, AnkerNumber(m, n - 1)));
    }
}

Console.Clear();
Console.Write("Введите положительное число m: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите положительное число n: ");
int b = int.Parse(Console.ReadLine()!);

if(a<0 || b<0) 
{
    Console.Write("Нужны положительные числа больше нуля!");
    return;
}    
int ank = AnkerNumber(a,b);
Console.WriteLine($"A({a},{b}) = {ank}");
