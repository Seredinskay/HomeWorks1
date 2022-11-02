
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
/*
int CutNumber (int num)
{
    int result = num /10 % 10 ;
     return result ;  
}
int RandomNumber = new Random().Next(100,1000);
int result = CutNumber(RandomNumber);
Console.WriteLine($"Second Digit Number of {RandomNumber} is {result} ");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
Console.WriteLine("Enter a number ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("the third digit -> " + anyNumberText[2]);
}
else {
Console.WriteLine("-> there is no third digit ");
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
/*
Console.WriteLine("Enter a number indicating the day of the week from 1 to 7 ");
int dayNumber=Convert.ToInt32(Console.ReadLine());
void checkTheDayOfTheWeek(int num)
{   
    if (dayNumber >=6 )
    Console.WriteLine($"{num} weekend ? -> yes ");
    else 
    Console.WriteLine($"{num} weekend ? ->  no ");
} 
checkTheDayOfTheWeek(dayNumber);
*/