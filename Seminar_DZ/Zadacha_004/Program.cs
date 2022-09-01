Console.WriteLine("Введите любое целое число");
int a=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите еще одно любое целое число");
int b=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("И еще одно целое число, пожалуйста");
int c=Convert.ToInt32 (Console.ReadLine());
int Max=0;
if (a>b)
{
    Max=a;
}
else Max=b;
if (Max>c)
{
    Max=Max;
}
else Max=c;
Console.WriteLine("Максимальное число "+Max);