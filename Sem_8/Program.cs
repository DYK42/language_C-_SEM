/*
Задача 54: 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

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
/*
void SortRows(int[,] array)
{
    int temp = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i, j] < array[i, k])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
}

int[,] array = GetArray(5, 6, 0, 10);
PrintArray(array);
Console.WriteLine();
SortRows(array);
PrintArray(array);
*/

/*
Задача 56:
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int GetIndexRowMinSum(int[,] array)
{
    int minIndex = -1;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if(minSum > sum || minSum <= 0)
        {
            minSum = sum;
            minIndex = i;
        }
    }
    return minIndex;
}

int[,] array = GetArray(5, 6, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.Write($"Индекс строки двумерного массива с наименьшей суммой элементов: {GetIndexRowMinSum(array)}");
*/

/*
Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
2*3 + 4*3
Результирующая матрица будет:
18 20
15 18
если число столбцов первой матрицы совпадает с числом строк второй матрицы
*/

int[,] GetMultiMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

int[,] array1 = GetArray(4, 2, 0, 10);
int[,] array2 = GetArray(2, 5, 0, 10);

if(array1.GetLength(1) != array2.GetLength(0)) 
{
    Console.WriteLine("Найти произведение матриц невозможно, т.к. количество столбцов первой матрицы не равно количеству строк второй матрицы!");
}
else
{
    int[,] array3 = GetMultiMatrix(array1, array2);
    PrintArray(array1);
    Console.WriteLine();
    PrintArray(array2);
    Console.WriteLine();
    PrintArray(array3);
}