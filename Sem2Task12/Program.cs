// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.

void Variant1()
{
int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
if(numB%numA == 0)
{

Console.WriteLine("второе число кратно первому");

}
else
{
    Console.WriteLine("второе число не кратно первому, остаток от деления " +numB%numB);
}
}

void Varian2()
{
int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");
Console.WriteLine ((numB%numA == 0)?true: numB%numA);

}

void Variant3()
{
Console.WriteLine("Введите первое  число ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(num2%num1==0? "Второе число кратно первому":"остаток от деления: " + (num2%num1));
}

// Variant1();
// Varian2();
Variant3();