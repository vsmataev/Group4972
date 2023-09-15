// №13 Напишите программу, 
// которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.WriteLine("Введите число от 1 до 9999999999"); // пусть будет 7654
 int? number = Convert.ToInt32(Console.ReadLine());
 //int[] numbers = new int[10];
  List<int> numbers = new List<int>();
  int temp1 = (int)number%10;//4
  int temp2 = (int)number / 10; //765
  int i = (int)temp1; //4
 bool test = (number<100);
if (test) Console.WriteLine("Число не трехзначное");
else if (number > 99)
{
    numbers.Add(i);
}
Count i;
if (temp1%10==0)
{
temp1 /= (int)temp2%10; //5,6
i = (int)temp1; //5,4
temp2 /= (int)temp2/10; //76,7
numbers.Add(i);
temp1 = (int)temp2; //76,7
}
return //temp2; //7

Console.WriteLine(numbers.Count);
