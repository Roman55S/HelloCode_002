Console.WriteLine("Введите любое целое число от 1 до ...");
int N=Convert.ToInt32 (Console.ReadLine());
int i=2;
int j=i/2;
while (i<=N)
{
    if (i==j*2)
    {
        Console.WriteLine (i+" ");
        i=i+1;
    }
    else i=i+1;

}