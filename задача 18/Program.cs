// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// AB = √(xb - xa)2 + (yb - ya)2 
// Math.Sqrt()
// Math.Pow()

Console.Clear();
Console.Write("Введите X точки A: ");
double XA = double.Parse(Console.ReadLine());
Console.Write("Введите Y точки A: ");
double YA = double.Parse(Console.ReadLine());
Console.Write("Введите X точки B: ");
double XB = double.Parse(Console.ReadLine());
Console.Write("Введите Y точки B: ");
double YB = double.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((XB - XA),2) + Math.Pow((YB - YA), 2));

Console.Write($"растояние между двумя точками = {AB}");


