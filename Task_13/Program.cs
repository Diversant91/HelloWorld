Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a <100)
{
   Console.WriteLine("третьей цифры нет");
}

if(a < 1000)
{ a = a%10;
Console.WriteLine(a);
}

if (a>1000)
{
while (a>1000)
{
    a = a/10;
}
Console.WriteLine(a = a%10);
}