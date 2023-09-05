// Задание 2: Является ли первое число квадрвтом второго

Console.WriteLine("Введите первое  число ");

int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число ");

int num2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет"); // тернарный оператор

// <условие>? <вариант1> : <вариант2> 
//эквивалентно:
// if(num1 == Math.Pow(num2, 2))
// {

//     Сonsole.WriteLine("Да");

// }
// else