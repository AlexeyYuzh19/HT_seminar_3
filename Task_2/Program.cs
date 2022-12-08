/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Hello, World!");

Console.Clear();
Console.WriteLine("Hello, World!");

int[] Array = new int[6];

Console.ForegroundColor = ConsoleColor.Yellow;

System.Console.WriteLine("Введите координату X1: ");
Array[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y1: ");
Array[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Z1: ");
Array[2] = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;

System.Console.WriteLine("Введите координату X2: ");
Array[3] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Y2: ");
Array[4] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату Z2: ");
Array[5] = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

System.Console.WriteLine("Расстояние между точками равно: " + Math.Sqrt(Math.Pow(Array[3]-Array[0], 2) + Math.Pow(Array[4]-Array[1], 2) + Math.Pow(Array[5]-Array[2], 2)));

Console.ResetColor();