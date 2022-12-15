// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

int Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        // result = Math.Pow(a, b);
        result = Convert.ToInt32(Math.Pow(a, b));
    }
    return result;
}

Console.WriteLine($"Число {a} в степени {b} равно {Degree(a, b)}");
