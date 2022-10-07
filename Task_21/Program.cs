// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] A = new double[3];
double[] B = new double[3];

Console.Write("Введите координату Х точки А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
double z1 = Convert.ToDouble(Console.ReadLine());   

A[0] = x1;
A[1] = y1;
A[2] = z1;

Console.Write("Введите координату Х точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки А: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
double z2 = Convert.ToDouble(Console.ReadLine());   

B[0] = x2;
B[1] = y2;
B[2] = z2;

double distance = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2);
Console.Write($"Расстояние между точками A с координатами ({x1}, {y1}, {z1}) и B с координатами ({x2}, {y2}, {z2}) = {distance}");