﻿Console.WriteLine("Введите первое целое число");
int a=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int b=Convert.ToInt32 (Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Первое число больше! Это "+a);
}
else Console.WriteLine("Второе число больше! Это "+b);