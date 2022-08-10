/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number / 100 < 1 || number / 100 >= 10) {
    Console.WriteLine("Не корректное число!");
    return;
}

int secondNumber = (number % 100) / 10;
Console.Write($"Вторая цифра числа {number}: {secondNumber}");
*/

/*
Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
*/


Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if(length < 3) {
    Console.Write("Третьей цифры нет!");    
} else {
    Console.Write($"Третья цифра числа {number}: {number[2]}");
}