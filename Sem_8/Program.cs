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
*/

/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)


int[,,] Get3DArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    int[] temp = new int[x * y * z];
    int count = 0;

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                while(true)
                {
                    int random = new Random().Next(minValue, maxValue + 1);
                    if(temp.Contains(random)) continue;
                    result[i, j, k] = random;
                    temp[count] = random;
                    count++;
                    break;
                }
            }
        }
    }

    return result;
}

void Print3DArrayByRows(int[,,] array)
{
    int xSize = array.GetLength(0);
    int ySize = array.GetLength(1);
    int zSize = array.GetLength(2);
    int xIndex = 0, yIndex = 0, zIndex = 0;

    while(true)
    {
        if(xIndex >= xSize && yIndex >= ySize && zIndex >= zSize) break;
        
        Console.Write($"{array[xIndex, yIndex, zIndex]} ({xIndex}, {yIndex}, {zIndex}) ");
        
        if(yIndex < ySize - 1)
        {
            yIndex++;
        }
        else
        {
            if(xIndex < xSize - 1)
            {
                xIndex++;
                yIndex = 0;
                Console.WriteLine();
            }
            else
            {
                if(zIndex < zSize - 1)
                {
                    zIndex++;
                    xIndex=0;
                    yIndex=0;
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}

Console.Write("Задайте размер массива по оси X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Задайте размер массива по оси Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Задайте размер массива по оси Z: ");
int z = int.Parse(Console.ReadLine());

if(x * y * z <= 100 - 10)
{
    int[,,] array = Get3DArray(x, y, z, 10, 99);
    Print3DArrayByRows(array);
}
else
{
    Console.Write("Размер трехмерного массива не позволяет заполнить его неповторяющимися двузначными числами!");
}
*/

/*
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] GetArraySpiralValue(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int count = 1;
    int countMax = rows * columns;
    int direction = 0;
    int start_rows = 0;
    int start_columns = 0;

    while (count <= countMax)
    {
        if (direction == 0)
        {
            for (int i = start_columns; i < columns; i++)
            {
                array[start_rows, i] = count++;
            }
            if(count > countMax) break;
            start_rows++;
            direction = 1;
        }
        if (direction == 1)
        {
            for (int i = start_rows; i < rows; i++)
            {
                array[i, columns - 1] = count++;
            }
            if(count > countMax) break;
            columns--;
            direction = 2;
        }
        if (direction == 2)
        {
            for (int i = columns - 1; i >= start_columns; i--)
            {
                array[rows - 1, i] = count++;
            }
            if(count > countMax) break;
            rows--;
            direction = 3;
        }
        if (direction == 3)
        {
            for (int i = rows - 1; i >= start_rows; i--)
            {
                array[i, start_columns] = count++;
            }
            if(count > countMax) break;
            start_columns++;
            direction = 0;
        }
    }
    Console.WriteLine();
    return array;
}

Console.Write("Задайте размер массива по оси X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Задайте размер массива по оси Y: ");
int y = int.Parse(Console.ReadLine());

int[,] array = GetArraySpiralValue(x, y);
PrintArray(array);