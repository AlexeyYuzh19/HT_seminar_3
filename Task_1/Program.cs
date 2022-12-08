/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.WriteLine("Hello, World!");
Console.ForegroundColor = ConsoleColor.Blue;
System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number_1 = Math.Abs(number); 

string num = Convert.ToString(number_1);

int n = num.Length;

if (n == 5)
{
    Console.ForegroundColor = ConsoleColor.Green;
    string resalt = (num[0] == num[4] && num[1] == num[3]) ? "заданное число является палиндромом" : "заданное число не палиндром";
    System.Console.WriteLine(resalt);
}
else
{
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine("задано не пятизначное число");
}
Console.ResetColor();
