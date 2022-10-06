Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a >= 100)
{int b = a%10;
Console.WriteLine(b);
}
else 
{
   Console.WriteLine("третьей цифры нет");
}