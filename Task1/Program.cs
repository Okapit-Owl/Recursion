// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers(int n, int m)
{
    if (m > 0 && n > 0)
    {
        if (m == n || n == m) return; // задачу точно не решила - не выводится первое число промежутка; 
        if (m > n)                    // вероятно, из-за условия с return; как правильно, не могу догадаться
        {
            PrintNaturalNumbers(n, m - 1);
            Console.WriteLine(m);
        }
        if (m < n)
        {
            PrintNaturalNumbers(n - 1, m);
            Console.WriteLine(n);
        }
    }
    else
    {
        Console.WriteLine("Введено некорректное число!");
    }

}

Console.WriteLine("Введите первое натуральное число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int num2 = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(num1, num2);