int PowXtoY(int x, int y)
{
    int PowXtoY = x;
    if (y == 0) PowXtoY = 1;
    else for (int i = 1; i < y; i++)
        {
            PowXtoY =  PowXtoY * x ;
        }
        return PowXtoY;
}
try
{
Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число А в степени В равно {PowXtoY(A, B)}");
}
catch
{
    Console.WriteLine("Нужно вводить целое число ");
}