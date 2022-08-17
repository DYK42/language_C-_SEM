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
*/

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