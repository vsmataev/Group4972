// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным. через Dictionary

Console.WriteLine("введите день");
int day = Convert.ToInt32(Console.ReadLine() ?? "0");
if(day >7 || day <1)
{
    Console.WriteLine($"Число {day} не является днем недели");
}
else
{
    //инициализация словаря со значениями
    Dictionary<int, string> dayOfWeek = new Dictionary<int, string>
    {
        { 1, "Monday"} ,
        { 2, "Tuesday"} ,
        { 3, "среда"} ,
        { 4, "Thursday"} ,
        { 5, "friday"} ,
        { 6, "saturday"} ,
        { 7, "sunday"}
    };
    Console.WriteLine(dayOfWeek[day]);
}