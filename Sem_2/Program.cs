/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
*/
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number / 100 < 1 || number / 100 >= 10) {
    Console.WriteLine("Не корректное число!");
    return;
}

int secondNumber = (number % 100) / 10;
Console.Write($"Вторая цифра числа {number}: {secondNumber}");