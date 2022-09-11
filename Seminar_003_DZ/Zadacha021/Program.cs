Console.Write("Введите точку х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите точку х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку z: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"Расстояние в 3D = {Math.Round(d,2)}");
Console.WriteLine($"Расстояние в 3D = {d:f3}");