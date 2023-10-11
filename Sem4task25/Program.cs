// 25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.



double ReadData(string msg) 
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}
double CalculatePower(double baseNum, double exponent) // задаем основание и степень
    {
        double result = 1.0;

        for (double i = 0; i < exponent; i++)
        {
            result *= baseNum; //умножаем нужное число раз
        }

        return result;
    }
    void PrintResult(double msg)
{
    Console.WriteLine(msg);
}
double numberA = ReadData("Введите основание");
double numberB = ReadData("Веедите степень");
double result = CalculatePower(numberA, numberB);
PrintResult(result);