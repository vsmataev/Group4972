// квадрат числа

Console.WriteLine("введите число: "); //вводим число
string? InputNum = Console.ReadLine();//??"0"; // string? означает что сравнение с null будет ниже

if(InputNum!=null) // знак != означает неравенство
{

    int num = int.Parse(InputNum); // Parse - перевод значения в числовую форму

    int res = num*num; //вычисление квадрата числа

    Console.WriteLine(res); //результат
}

Console.WriteLine ($"квадрат числа {InputNum} равен "+Math.Pow(int.Parse(InputNum),2)); //через функцию Math.Pow