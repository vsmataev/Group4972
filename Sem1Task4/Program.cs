// ДЗ №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.
Console.Write("ведите первое число: ");
int? firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int? secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int? thirdNum = Convert.ToInt32(Console.ReadLine());
int? max = firstNum;
if(firstNum == secondNum && firstNum == thirdNum)
{
    Console.WriteLine($"все числа равны {max}");
}
    else
{
        if(max < secondNum)
{      
             max = secondNum;
}
        if(max < thirdNum)
{    
            max = thirdNum;
}
Console.WriteLine($"наибольшее число {max}");
}