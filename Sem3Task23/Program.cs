// Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


using System;

public class Answer
{
    static void ShowCube(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i} в кубе равно {cube}");
        }
    }

    // Главный метод Main
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для тестирования
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}