/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


int GetPositiveNumbers()
{
    int count = 0;
    
    Console.WriteLine("Вводите любые числа для подсчета количества положительных. Для оставновки введите '0'!");
    
    while(true)
    {
        int number;
        if(!int.TryParse(Console.ReadLine(), out number)) continue;
        if(number == 0) break;
        if(number > 0) count++;
    }

    return count;
}

int PositiveNumber = GetPositiveNumbers();
Console.WriteLine($"Количество введенных положительных чисел: {PositiveNumber}");

Console.WriteLine("==============     Второй вариант     ====================");

// Второй вариант. С использованием массива.
int[] GetArray()
{
    Console.WriteLine("Вводите любые числа для подсчета количества положительных. Для оставновки введите '0'!");
    
    int count = 0;
    string str = string.Empty;
    
    while(true)
    {
        string s = Console.ReadLine();
        if(s == "0") break;
        int num;
        if(!int.TryParse(s, out num)) continue;
        str += s + " ";
        count++;
    }
    
    string[] sarr = str.Split(" ");
    int[] arr = new int[count];

    for (int i = 0; i < count; i++)
    {
        arr[i] = int.Parse(sarr[i]);
    }

    return arr;
}

int GetPositiveNumberByArray(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }

    return count;
}

int[] array = GetArray();
Console.WriteLine($"Введенные чисела: {string.Join(", ", array)}");

Console.WriteLine($"Количество введенных положительных чисел: {GetPositiveNumberByArray(array)}");
*/

/*
Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

x*k1 + b1 = x*k2 + b2
x*k1 - x*k2 = b2 - b1
x*(k1-k2) = (b2-b1)
x = (b2-b1) / (k1-k2)
*/

Console.Write("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());

void GetCross(double b1, double k1, double b2, double k2, ref double x, ref double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = x * k1 + b1;
}

double x = 0;
double y = 0;

GetCross(b1, k1, b2, k2, ref x, ref y);
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} --> ({x}; {y})");