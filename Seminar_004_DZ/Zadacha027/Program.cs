/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int SummDigit(int A)
{
    int sum = 0;
    while (A>0)
    {
        sum = sum + A%10;
        A = A/10;
    }
    return sum;
}
Console.WriteLine("Введите число X ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {X} равна {SummDigit(X)}");