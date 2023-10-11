// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N (Фактоиал).

//using System.Numerics - для подключения BigInteger
int ReadData(string msg) 
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long Factorial (int num) //через long получится посчитать только до 20
{
long fact = 1;

    for (int i = 2; i <= num; i++)
    {
        fact *= i; //с присвоением (чтоб не забыть)
    }
    return fact;

}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int number = ReadData("Введите число");
long res = Factorial(number);
PrintResult($"{number}!=" +res);