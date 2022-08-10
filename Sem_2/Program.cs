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
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number < 100) {
    Console.Write("Третьей цифры нет!");    
} else {
    //int len = ((int)(Math.Ceiling(Math.Log10(number))));
    int num3 = -1;
    //int num3 = ((int)(num % Math.Pow(10, (--len))));
    //num3 = ((int)(num3 % Math.Pow(10, (--len))));
    //num3 /= ((int)(Math.Pow(10, (--len))));
    //Console.WriteLine($"Цифр в числе {number}: {len}");
        num3 = (number / 100) % 10;
    Console.Write($"Третья цифра числа {number}: {num3}");
}



/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

Console.Write("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine());
if(number > 5 && number < 8) Console.Write("Да");
else Console.Write("Нет");
*/