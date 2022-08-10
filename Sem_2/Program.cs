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


Console.Write("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;

if(length < 3) {
    Console.Write("Третьей цифры нет!");    
} else {
    Console.Write($"Третья цифра числа {number}: {number[2]}");
}
*/

/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
*/

Console.Write("Введите цифру дня недели: ");
int number = int.Parse(Console.ReadLine());
string answer = "";
switch(number) {
    case 1:     answer = "Нет";    break;
    case 2:     answer = "Нет";    break;
    case 3:     answer = "Нет";    break;
    case 4:     answer = "Нет";    break;
    case 5:     answer = "Нет";    break;
    case 6:     answer = "Да";     break;
    case 7:     answer = "Да";     break;
    default:    answer = "Не корректное число!"; break;
}
Console.Write(answer);