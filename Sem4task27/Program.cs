// 27 Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int ReadData(string msg) 
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int GetSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            int digit = number % 10; // Получаем последнюю цифру числа
            sum += digit; // Добавляем цифру к сумме
            number /= 10; // Убираем последнюю цифру из числа
        }

        return sum;

//вариант через строку (теоретически должен работать быстрее)
// int GetSum(int number)
// {
//     int sum = 0;
//     string numberStr = number.ToString();

//     for (int i = 0; i < numberStr.Length; i++)
//     {
//         sum += int.Parse(numberStr[i].ToString());
//     }

//     return sum;
// }
    }

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
int number = ReadData("Введите число");
int res = GetSum(number);
PrintResult($"Сумма всех цифр числа {number} равна {res}");