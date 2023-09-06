// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

Console.WriteLine("Enter number");
int num = int.Parse(Console.ReadLine ()??"0");
if(num > 100 && num < 1000); // проверка на трехзначность через логическое "или"(&&)(введенное число должно быть больше 100 и меньше 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine("Последняя цифра" + num + "это" + lastDigit);
}
else
{
    Console.WriteLine("Число не трехзначное");
}