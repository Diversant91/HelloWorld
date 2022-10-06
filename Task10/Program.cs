Console.Clear();
Console.Write("Введите число: ");
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int b = a%100;
int c = b/10;
Console.WriteLine(c);