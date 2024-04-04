// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int AckermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermanFunction(n - 1, 1);
    return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

int a = AckermanFunction(3,11);
Console.WriteLine(a);