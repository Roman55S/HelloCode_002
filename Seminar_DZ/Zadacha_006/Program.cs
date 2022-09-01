Console.WriteLine("Введите любое целое число");
int a=Convert.ToInt32 (Console.ReadLine());
int b=a/2;
if (a==b*2)
{
    Console.WriteLine("Введенное вами число четное!");
}
else Console.WriteLine("Вы ввели нечетное число");