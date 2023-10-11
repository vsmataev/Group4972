// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int ReadData(string msg) 
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


void PrintResult(int msg)
{
    Console.WriteLine(msg);
}

int NumDigit (int num)
// решение через логарифм - добавить отдельный метод
// {
//     return Convert.ToInt32(Math.Log(num,10)+1);
// }

{
int count = 0;
while (num >0)
{
    count ++;
    num = num/10;
}

    return count;
}
int number = ReadData("Введите число");
int res = NumDigit(number);

PrintResult(res);