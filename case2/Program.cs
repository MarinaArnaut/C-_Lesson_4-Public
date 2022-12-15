// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;
int abs = 0;
int GetSumNumb(int num)
{
    for (int i = 0; num >= 10; i++)
    {
        abs = num / 10;
        abs = abs % 10;
        sum = sum + abs;
        num--;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе = {GetSumNumb(sum)}");