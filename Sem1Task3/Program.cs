// Задание 2. Определить день недели по номеру
Console.WriteLine("Enter day");
int day = int.Parse(Console.ReadLine ()??"0");
string [] dayOfWeek = new string [7]; // создание массива dayOfWeek длинной 7
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресение";
Console.WriteLine(dayOfWeek [day-1]);