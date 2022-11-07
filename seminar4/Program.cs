//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
double Ciferka (double a, double b)
{
    return Math.Pow (a , b);
}
Console.WriteLine("Input a");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b");
double b = Convert.ToInt32(Console.ReadLine());
double result = Ciferka(a, b);
Console.WriteLine($" Deegre is {result}");
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12
/*
int diggitOfSum(int num)
{   
    int size = Convert.ToString(num).Length;
    int ed = 0;
    int diggitsSum = 0;
    for(int i = 0; i < size; i++)
    {   
        ed = num - num % 10;
        diggitsSum = diggitsSum + (num - ed);
        num = num / 10;
    }
    return diggitsSum;
}
Console.WriteLine("Input number ");
int num = Convert.ToInt32(Console.ReadLine());
int DiggitOfSum = diggitOfSum(num);
Console.WriteLine($"the sum of the digits in a number is -> {DiggitOfSum}");
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }                                                                                                               
    return myArray;
}
void ShowArray(int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
*/