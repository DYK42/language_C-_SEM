/*
Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

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