// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Програма задает массив из 8 элементов и выводит их на экран");
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0, i < Array.Lenght; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0, i< Array.Lenght; i++)
    {
        Console.Write(array[i] + " , ");
    }
    Console.Write(array[7] + " . ");
}

Console.Write("Сгенерированный массив: ");
PrintArray(CreateArray(8));