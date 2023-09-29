//Задача №39
//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]

// Решение двумя разными методами
// Генерация массива
int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++) { array[i] = rnd.Next(minValue, maxValue + 1); }
    return array;
}

// Вывод массива
void PrintArray(string msg, int[] array)
{
    Console.Write(msg + "[");
    for (int i = 0; i < array.Length - 1; i++) { Console.Write(array[i] + ", "); }
    Console.WriteLine(array[array.Length - 1] + "]");
}



int[] SwapNewArray(int[] arr) //способ 1 - создает новый массив и заполняет его в обратном порядке
{
    int[] outArr = new int[arr.Length]; // новый массив длинной равный входному
    for(int i =0;i<arr.Length;i++)
    {
        outArr[arr.Length-1 - i] = arr[i];
    }
    return outArr;
}


void SwapArray(int[] arr) // способ 2 - переворачивает исходный массив,
//закоментирован код с использованием промежуточного элемента
{
   // int buferElement = 0;
    for(int i =0; i<arr.Length/2;i++)
    {
        (arr[arr.Length-1 - i],arr[i])=(arr[i], arr[arr.Length-1 - i]); //буферная переменная не инциилизуется, 
                                                                        //но атоматически создается
        // buferElement = arr[arr.Length-1 - i];
        // arr[arr.Length-1 - i]=arr[i];
        // arr[i] = buferElement;
    }
}

int[] arr = GenerateRandomArray(15,1,100);
PrintArray("",arr);
int[] swapArr = SwapNewArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);
Console.WriteLine("Перевернутый массив");
PrintArray("",swapArr);

SwapArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);