Console.Clear();
Console.WriteLine("Введи число от 1 до 7");
int a = Convert.ToInt32(Console.ReadLine());
if ((a < 1) || (a > 7))
{
    Console. WriteLine("Не корректное число, введи от 1 до 7");
}
if ((a==1)||(a==2)||(a==3)||(a==4)||(a==5))
{
  Console. WriteLine("Нет");  
} 
if ((a==6) || (a==7))
{
  Console. WriteLine("Да");  
} 