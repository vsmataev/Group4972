//Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

// Console.WriteLine("Enter number");
// int numN = int.Parse(Console.ReadLine ()??"0");
// int evnumN = (-1)*numN;
// while(evnumN<numN)  //цикл работает от -N до N-1
// {
//     Console.Write(evnumN + ", "); // указываем + "," чтобы вывод был через запятую
//     evnumN = evnumN + 1;
// }
// Console.WriteLine(numN); // выводит последнее число (N) без запятой

// решение через for

Console.WriteLine("Enter number");
int numN = int.Parse(Console.ReadLine ()??"0");
int evnumN = (-1)*numN;
for(int i = evnumN; i <= numN; i++)
{
    Console.Write(i.ToString()+ ", ");
}
