Console.Clear();
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    if(a>c)
    {
        Console.WriteLine(a);
    }
    else 
    {Console.WriteLine(c);}
    
}
if (a<b);
{
    if(b>c)
    {
        Console.WriteLine(b);
    }
    else
    {Console.WriteLine(c);}
}