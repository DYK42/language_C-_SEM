/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Реализовать функцию возведения в степень самостоятельно!
*/

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