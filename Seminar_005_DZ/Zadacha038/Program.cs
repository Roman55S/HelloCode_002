// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
double [] RandomArray (int size)
    {
        double[] array = new double[size];

        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().NextDouble();
            }
        Console.WriteLine($"[{string.Join(",", array)}]");    
        return array;
    }
double [] SortMaxMinArr(double[]arr)
{
    double[] array = new double[2];
    double Max = arr[0];
    double Min = arr[0];
    for (int j = 1; j < arr.Length; j++)
    {
       if(arr[j]> Max) Max = arr[j];
       else if (arr[j]<Min) Min = arr[j];
    }
    array[0] = Math.Round(Max,3);
    array[1] = Math.Round(Min,3);
    Console.WriteLine($"[{string.Join(",", array)}]");//массивы выводил в консоль для зрительного контроля
    return array;                                // работы программы, для себя, округлил в тех же целях
}

Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
double[]NewArray = RandomArray(N);
double[]DiffArray = SortMaxMinArr(NewArray);
double Diff = DiffArray[0] - DiffArray[1];
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Diff}");