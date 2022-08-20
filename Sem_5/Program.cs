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
*/

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