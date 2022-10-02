Console.Clear();
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a>b)
{max = a;
Console.WriteLine($"Max = {max}");
}
if (a<b)
{max = b;
Console.WriteLine($"Max = {max}");
}