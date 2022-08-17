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
int num3 = num1;

for (int i = 0; i < num2 - 1; i++)
{
    num3 *= num1;
}
Console.Write($"Число {num1} в степени {num2} равно: {num3}");