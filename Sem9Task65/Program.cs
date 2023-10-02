// 65 Все натуральные элементы между m и n


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Формирование строки с числами
string SearchForNaturalElementsRec (int m, int n)
{
    return n >= m ? $"{m} " + SearchForNaturalElementsRec(m + 1, n) : "";
}

int m = Prompt("Введите m: ");
int n = Prompt("Введите n: ");
// защита от дурака - в случае чего, меняет значения
Console.WriteLine((m>n)?SearchForNaturalElementsRec(n, m):SearchForNaturalElementsRec(m, n));

// using System;

// class Program
// {
//     static int Prompt(string message)
//     {
//         Console.Write(message);
//         string input = Console.ReadLine();
//         int number = int.Parse(input);
//         return number;
//     }

//     static string SearchForNaturalElementsRec(int m, int n)
//     {
//         if (m <= n)
//         {
//             return m + " " + SearchForNaturalElementsRec(m + 1, n);
//         }
//         else
//         {
//             return "";
//         }
//     }

//     static void Main(string[] args)
//     {
//         int m = Prompt("Введите m: ");
//         int n = Prompt("Введите n: ");

//         if (m <= n)
//         {
//             Console.WriteLine(SearchForNaturalElementsRec(m, n));
//         }
//         else
//         {
//             Console.WriteLine(SearchForNaturalElementsRec(n, m));
//         }
//     }
// }
