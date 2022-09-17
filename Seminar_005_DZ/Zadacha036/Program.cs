// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int [] RandomArray (int size)
    {
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next();
            }
        Console.WriteLine($"[{string.Join(",", array)}]");    
        return array;
    }

int SummElements (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[]NewArray = RandomArray(N);
int SUM = SummElements(NewArray);
Console.WriteLine($"сумму элементов массива, стоящих на нечётных позициях равно {SUM}");