﻿// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


//------------------------------------------------------------------------------------------------------------------
Console.Clear();
int n = ReadData("Введите количество чисел Фибоначчи (N): ");
PrintFibonacciNumbers(n);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------
// Ввод числа с клавиатуры
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печати чисел Фибоначчи
void PrintFibonacciNumbers(int n)
{
    int first = 0;
    int second = 1;

    Console.Write(first + " " + second + " ");

    for (int i = 2; i < n; i++)
    {
        int next = first + second;
        Console.Write(next + " ");

        first = second;
        second = next;
    }
}