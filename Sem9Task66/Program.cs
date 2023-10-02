// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int CalculateSumRec(int m, int n)
{
    return n >= m ? m + CalculateSumRec(m+1, n): 0;
}


int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
// защита от дурака - в случае чего - меняет значения.
int min = m < n ? m : n;
int max = m < n ? n : m;

int sum = CalculateSumRec(min, max);
Console.WriteLine($"Сумма чисел в интервале ({min};{max}) равна {sum}");