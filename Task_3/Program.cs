/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello, World! \n");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Введите число: ");
Console.ForegroundColor = ConsoleColor.Blue;

int number = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

System.Console.WriteLine($"\nТаблица кубов числа {number} : \n");

for (int i = 1; i < number; i++)
{
    System.Console.Write((Math.Pow (i, 3)) + ", ");
}
System.Console.Write(Math.Pow (number, 3)  + ".");

Console.ResetColor();
