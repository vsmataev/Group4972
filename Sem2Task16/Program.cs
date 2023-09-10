// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
void Variant1 ()
{
Console.WriteLine("Введите первое  число ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
bool test1 = (num1==num2*num2);//аналогично if, проверяем является ли первое число квадратом второго
bool test2 = (num2==num1*num1);
    if(test1) Console.WriteLine("1-е квадрат 2-го");
    if(test2) Console.WriteLine("2-e квадрат 1-го");
    if ((!test1||test2)) //логическое "ИЛИ" - оба теста = false
    {
        Console.WriteLine("числа не являются квадратами друг друга");
    }
}

void Variant2() //разобрать позже и выбрать интересный
{

}

//Variant1 ();
Variant2 ()