// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
Console.Write("ведите число: ");
int? num = Convert.ToInt32(Console.ReadLine());
int oddNum = 2; // первое четное число после единицы

for(int i = oddNum; i <= num; i = i+2) // последовательно прибавляем двойку до "num"
{
    Console.Write(i.ToString()+ ", ");
}