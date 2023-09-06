// Задание 2. Определить день недели по номеру
Console.WriteLine("Enter day");
// Решение через массив
//int day = int.Parse(Console.ReadLine ()??"0");
// string [] dayOfWeek = new string [7]; // создание массива dayOfWeek длинной 7
//     dayOfWeek[0] = "Понедельник";
//     dayOfWeek[1] = "Вторник";
//     dayOfWeek[2] = "Среда";
//     dayOfWeek[3] = "Четверг";
//     dayOfWeek[4] = "Пятница";
//     dayOfWeek[5] = "Суббота";
//     dayOfWeek[6] = "Воскресение";
// Console.WriteLine(dayOfWeek [day-1]);


// другое решение (через case) NB! в данном случае переводить введенные данные в числовые не нужно

string day = Console.ReadLine()??"0";
switch (day)
{
case "1" : Console.WriteLine("Monday"); break;
case "2" : Console.WriteLine("Monday"); break;
case "3" : Console.WriteLine("Monday"); break;
case "4" : Console.WriteLine("Monday"); break;
case "5" : Console.WriteLine("Monday"); break;
case "6" : Console.WriteLine("Monday"); break;
case "7" : Console.WriteLine("Monday"); break;
default: Console.WriteLine("There are only seven days in a week"); break; //выводится, если введено значение, выходящее за границы диапазона
}