// №43 Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем




double ReadData(string msg)
{
    Console.Write(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

double[] FindIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[] { x, y };
}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
double k1, b1, k2, b2;
k1 = ReadData("Введите точку k1: ");
b1 = ReadData("Введите точку b1: ");
k2 = ReadData("Введите точку k2: ");
b2 = ReadData("Введите точку b2: ");

if(k1==k2)
{
Console.WriteLine("Заданы отрезки, принадлежащие параллельным прямым");
}

double[] intersection = FindIntersection(k1, b1, k2, b2);

PrintResult($"Точка пересечения: ({intersection[0]}, {intersection[1]})");