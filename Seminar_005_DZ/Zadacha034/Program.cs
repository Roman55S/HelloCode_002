// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
int [] RandomPositivArr (int size)
    {
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(100, 1000);
            }
        Console.WriteLine($"[{string.Join(",", array)}]");    
        return array;
    }

int CountNubers (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;        
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int[]NewArray = RandomPositivArr(N);
int result = CountNubers(NewArray);
Console.WriteLine($"Количество четных чисел равно {result}");