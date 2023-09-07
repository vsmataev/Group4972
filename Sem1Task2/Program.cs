// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
Console.Write("ведите первое число: ");
int? firstNum = Convert.ToInt32(Console.ReadLine());67
Console.Write("Введите второе число: ");
int? secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum < secondNum)
{
    Console.WriteLine($"{secondNum} больше {firstNum}");
} 
else if (firstNum > secondNum)
{
    Console.WriteLine($"{firstNum} больше {secondNum}");
}
else
{
    Console.WriteLine("оба числа равны");
}