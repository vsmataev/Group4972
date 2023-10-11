// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

// Анастасия Г.
// Вывод сообщения и вызов метода CheckingCoordinates
string Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";
    int quarter = Convert.ToInt32(values);
    //вызов метода из метода
    return CheckingCoordinates(quarter); //выдаваемое значение
                                        // должно соответствовать типу данных,
                                        // которые были введены в метод
}

// Проверка четверти
string CheckingCoordinates(int quarter)
{
    switch(quarter)
    {
        case 1: return "(X > 0 ; Y > 0)";
        case 2: return "(X < 0 ; Y > 0)";
        case 3: return "(X < 0 ; Y < 0)";
        case 4: return "(X > 0 ; Y < 0)";
        default: return "0";
    }
}

Console.WriteLine(Prompt("Введите номер четверти: "));