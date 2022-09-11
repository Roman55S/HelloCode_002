

string KubN(int x)
{
    string result =string.Empty;
    for (int i = 1; i <= x; i++)
    {
        double y;
        y = Math.Pow(i,3);
        result = result + " " + y;
        
    }
    return result;
}    
Console.WriteLine("Введите любое число от 1 до N ");
int x = Convert.ToInt32 (Console.ReadLine());
string res = KubN(x);
Console.WriteLine($"Таблица кубов чисел от 1 до N {res}");