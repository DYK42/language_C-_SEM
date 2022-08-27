/*
Задача 47.
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


double[,] GetDoubleArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 2);
        }
    }

    return result;
}

void PrintArray(double[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetDoubleArray(rows, columns, -50, 50);
PrintArray(array);
*/

/*
Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetValueByIndex(int[,] array, int row, int column)
{
    if(row >= array.GetLength(0) || column >= array.GetLength(1) || row < 0 || column < 0)
        return int.MinValue;

    return array[row, column];
}

Console.Write("Введите количество строк : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите индекс строки : ");
int indexRow = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца : ");
int indexColumn = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 10, 100);
PrintArray(array);
int valueByIndex = GetValueByIndex(array, indexRow, indexColumn);
Console.Write($"Значение элемента : {(valueByIndex <= int.MinValue ? "Такой позиции в массиве нет!" : valueByIndex)}");
*/

/*
Задача 52.
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetAverageByColumns(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;

        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }

        result[i] = sum / array.GetLength(0);
    }

    return result;
}

Console.Write("Введите количество строк : ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] averageArray = GetAverageByColumns(array);
Console.Write($"Среднее арифметическое по столбцам: {string.Join(", ", averageArray)}");
*/

/*
Задача со звездочкой. 
Написать программу для перевода римских чисел в десятичные арабские.
III -> 3
LVIII -> 58
MCMXCIV -> 1994
1000 100 1000 10 100 1 5
*/

int GetArabicNumber(string romanNumber)
{
    romanNumber = romanNumber.ToUpper();
    int arabicNumber = 0;

    switch(romanNumber)
    {
        case "I":   arabicNumber = 1;     break;
        case "V":   arabicNumber = 5;     break;
        case "X":   arabicNumber = 10;    break;
        case "L":   arabicNumber = 50;    break;
        case "C":   arabicNumber = 100;   break;
        case "D":   arabicNumber = 500;   break;
        case "M":   arabicNumber = 1000;  break;
        default:    arabicNumber = 0;     break;
    }

    return arabicNumber;
}

int RomanToArabicNumber(string romanNumber)
{
    int result = 0;
    int prevNumber = 0;

    for (int i = romanNumber.Length - 1; i >= 0; i--)
    {
        int number = GetArabicNumber(romanNumber[i].ToString());

        if(number <= 0) continue;

        result += number < prevNumber ? -number : number;
        prevNumber = number;
    }

    return result;
}

Console.Write("Введите римское число: ");
string romanNumber = Console.ReadLine().ToUpper();
int arabicNumber = RomanToArabicNumber(romanNumber);
Console.Write($"Римское число {romanNumber} это арабское {arabicNumber}");