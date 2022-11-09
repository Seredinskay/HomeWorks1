//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/*
int digitNumSum(int size)
{   
    int  digit = 0;
    for(int i = 0; i < size; i++)
    {
    Console.WriteLine("Input number ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0) digit++;
    }
    return digit; 
}
Console.WriteLine("Enter the size of the array");
int size = Convert.ToInt32(Console.ReadLine());
int result = digitNumSum(size);
Console.WriteLine($"The number of numbers is greater 0 -> {result} ");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
void FindNum(double b1, double k1, double b2, double k2)
{   
    double x = (b1 - b2) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / ( k2 - k1);
    if(k1 == k2) Console.WriteLine("The coordinates do not intersect ");
    else Console.WriteLine($"Coordinates intersect at points -> ({x};{y})");
}

Console.WriteLine("Input b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1 :");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2:");
double k2 = Convert.ToDouble(Console.ReadLine());
FindNum(b1, k1, b2, k2);
*/