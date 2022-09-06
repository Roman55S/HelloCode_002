Console.WriteLine ("Введите любое целое число ");
int num1 = Convert.ToInt32 (Console.ReadLine());
if (num1 < 100) Console.WriteLine ("В введенном числе третья цифра отсутствует ");
else if (num1 < 1000)
    {
        int num2 = num1%10;
        Console.WriteLine($"Третья цифра в вашем числе {num2} ");
    }
    else
    {
        int num3 = num1;
       while (num3 > 1000)
       {
       num3 = num3/10;
       }
       num3 = num3%10;
       Console.WriteLine($"Третья цифра в вашем числе {num3} ");
    }
        
        
    