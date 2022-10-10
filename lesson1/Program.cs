/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] elements = CreatArray();
int countMoreZero = FindMoreZero(elements);

int[] CreatArray()
{
    Console.WriteLine("Введите количество элементов M массива:");
    int elementsCount = int.Parse(Console.ReadLine()!);
    int[] array = new int[elementsCount];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива c индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    System.Console.WriteLine();
}

int FindMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    return count;
}

PrintArray(elements);
Console.WriteLine($"Количество чисел больше нуля равно {countMoreZero}");
