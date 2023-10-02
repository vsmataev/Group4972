// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// N=5 ->  1 2 3 4 5

void GenLineRec(int num)
{
    if (num < 1)
    {
    }
    else
    {
        GenLineRec(num - 1); // Рекурсия с уменьшением num
        Console.Write(num + " ");
    }
}

int num = ReadData("Введите целое положительное число: ");
GenLineRec(num);