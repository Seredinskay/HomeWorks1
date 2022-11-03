//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

/*
Console.Write("Enter a number: ");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
  if (number[0]==number[4] && number[1]==number[3])
  {
    Console.WriteLine($"your number: {number} - palindrome ");
  }
  else Console.WriteLine($"your number: {number} - not a palindrome ");
}
if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"enter the correct number ");
*/



//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
   return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
Console.WriteLine("Input x1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input z2:");
double z2 = Convert.ToDouble(Console.ReadLine());
double findDistance = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Distance ={findDistance} ");
*/


//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
void cube (int num)
{
    int step = 1;
    while (step <= num)
    {
      Console.WriteLine($"cube numbers { step } equal {step * step * step}");
      step ++;
    } 
}
Console.WriteLine("input num");
int num = Convert.ToInt32(Console.ReadLine());
cube(num); 
*/