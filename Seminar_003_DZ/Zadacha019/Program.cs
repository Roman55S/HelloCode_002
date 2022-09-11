Console.WriteLine("Введите любое пятизначное число");
try
{
int x = Convert.ToInt32(Console.ReadLine());
if (x/10000==x%10 && x/1000%10==x%100/10) Console.WriteLine("Введенное число палиндромом");
else Console.WriteLine("Введенное число не палиндромом");

}
catch
{
    Console.WriteLine("Введите целое число ");
}