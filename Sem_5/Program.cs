int[] GetArray(int size, int start, int stop)
{
    int[] arr = new int [size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(start, stop+1);
    }

    return arr;
}

/*
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

int[] array = GetArray(11, 99, 1000);

int GetEvenNumbers(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Массив: " +  string.Join(", ", array));
Console.WriteLine($"Количество четных чисел в массиве: {GetEvenNumbers(array)}");
*/

/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = GetArray(11, -22, 30);

int GetSum(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }

    return sum;
}

Console.WriteLine("Массив: " +  string.Join(", ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {GetSum(array)}");