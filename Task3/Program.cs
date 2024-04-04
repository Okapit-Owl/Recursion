// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


void PrintArray(int[] array, int i)
{
    if (i < 0 || array.Length == 0) return;
    Console.WriteLine($"{array[i]}");
    PrintArray(array, i-1);
}

int[] array = new int[] {1,2,3,4,5};
PrintArray(array, array.Length-1);