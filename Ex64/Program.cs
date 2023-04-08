// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

string OutputNumber(int num)
{
    if (num == 1)
    {
        return 1.ToString();
    }
    return num.ToString() + ", " + OutputNumber(num - 1);
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write(OutputNumber(num));
Console.WriteLine();