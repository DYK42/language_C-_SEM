/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Реализовать функцию возведения в степень самостоятельно!

Console.Write("Введите число первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число второе число: ");
int num2 = int.Parse(Console.ReadLine());

int GetPowerNumber(int a, int b)
{
    int num = a;
    for (int i = 0; i < b - 1; i++)
    {
        num *= a;
    }
    return num;
}

Console.Write($"Число {num1} в степени {num2} равно: {GetPowerNumber(num1, num2)}");
*/

/*
Задача 27:
Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

int GetSumNumber(int num)
{
    int sum = 0;
    
    do
    {
        sum += num % 10;
        num /= 10;
    }
    while(num != 0);
    return sum;
}
Console.Write("Введите число число: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"Сумма чисел числа {number} равна: {GetSumNumber(number)}");
*/

/*
Задача 29:
Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) 
и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33]

void GetArray(ref int []arr, int numbers, int start, int end)
{
    Array.Resize<int>(ref arr, numbers);

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end);    
    }
}

Console.Write("Введите размер массива: ");
int sizeArray = int.Parse(Console.ReadLine());
Console.Write("Введите число начала диапазона случайных чисел: ");
int numStartRandom = int.Parse(Console.ReadLine());
Console.Write("Введите число окончания диапазона случайных чисел: ");
int numEndRandom = int.Parse(Console.ReadLine());

int[] array = new int[1];

GetArray(ref array, sizeArray, numStartRandom, numEndRandom);

Console.Write($"[{string.Join(", ", array)}]");
*/

/*
Задача “со звездочкой”: (необязательное) 
Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
*/

Console.Clear();
Console.Write("Введите высоту елочки: ");
int size = int.Parse(Console.ReadLine());
int x = size;
int y = 1;
int numbers = 1;

for (int i = 0; i < size; i++)
{
    int x1 = x;
    for (int j = 0; j < numbers; j++)
    {
        Console.SetCursorPosition(x1, y);
        Console.WriteLine("+");
        x1++;
    }
    numbers += 2;
    x--;
    y++;
}