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
*/

/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

double[] GetDoubleArray(int size, int start, int stop)
{
    double[] arr = new double [size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().Next(start, stop) + new Random().NextDouble(), 2);
    }

    return arr;
}

double GetDiffMaxMin(double[] arr)
{
    int size = arr.Length;
    if(size < 1) return double.NaN;

    double max = arr[0];
    double min = arr[0];

    for (int i = 1; i < size; i++)
    {
        if(max < arr[i]) max = arr[i];
        if(min > arr[i]) min = arr[i];
    }

    Console.WriteLine($"Максимальный {max} и минимальный {min} элементы массива");
    return max - min;
}

double[] array = GetDoubleArray(10, 0, 50);
Console.WriteLine("Массив: " +  string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {GetDiffMaxMin(array)}");
*/

/*
Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
Реализовать невозрастающую сторировку.
[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
[1,2,2,3,2] -> [3, 2, 2, 2, 1]
*/

int[] GetBubbleSortRev(int[] arr)
{
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
             //Console.WriteLine(arr[i]);
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            //Console.WriteLine(string.Join(", ", arr));
        }
        //Console.WriteLine();
        //Console.WriteLine(string.Join(", ", arr));
    }
    return arr;
}

int[] array = GetArray(10, -20, 50);
Console.WriteLine($"Массив: {string.Join(", ", array)}");
Console.WriteLine($"Невозрастающая сторировка элементов массива: {string.Join(", ", GetBubbleSortRev(array))}");
