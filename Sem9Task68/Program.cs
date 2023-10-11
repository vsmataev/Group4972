// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int CalculateAckermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Для вычисления функции значения m  и n должны быть положительными.");
        Environment.Exit(0);
    }
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalculateAckermann(m - 1, 1);
    }
    else
    {
        return CalculateAckermann(m - 1, CalculateAckermann(m, n - 1));
    }
}

int m = ReadData("Предупреждение: значения m больше 3 могут привести к переполнению стека или долгому времени вычисления. \nВведите m: ");
int n = ReadData("Введите n: ");
int result = CalculateAckermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
