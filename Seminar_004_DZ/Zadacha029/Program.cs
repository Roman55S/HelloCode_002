/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
N - вводится с клавиатуры. Элементы тоже вводятся с клавиатуры.
5
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
3
6, 1, 33 -> [6, 1, 33]*/
int [] AddArr(int n)
{
int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.WriteLine("Введите  элемент массива");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
return arr;
}

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
int [] NewArray = AddArr(N);
Console.WriteLine($"Результат: [ {String.Join("; ", NewArray)} ]");