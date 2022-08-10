/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.


Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number < 100 || number > 999) {
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


Console.Write("Введите число: ");
string number = Console.ReadLine();

int length = number.Length;

if(length < 3) {
    Console.Write("Третьей цифры нет!");    
} else {
    Console.Write($"Третья цифра числа {number}: {number[2]}");
}

int num = int.Parse(number);

if(num < 100) {
    Console.Write("Третьей цифры нет!");    
} else {
    int len = ((int)(Math.Ceiling(Math.Log10(num))));
    int num3 = ((int)(num % Math.Pow(10, (--len))));
    num3 = ((int)(num3 % Math.Pow(10, (--len))));
    num3 /= ((int)(Math.Pow(10, (--len))));
    //Console.Write($"Цифр в числе {num}: {len}");
    Console.Write($"Третья цифра числа {num}: {num3}");
}
*/


/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

Console.Write("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine());
if(number > 5 && number < 8) Console.Write("Да");
else Console.Write("Нет");
