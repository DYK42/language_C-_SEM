/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа 
с циклами и арифметическими опреациями!!!
14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

if(number < 10000 || number > 99999) {
    Console.WriteLine("Не корректное число!");
} else {
    int div1 = 10000;
    int div2 = 10;
    for(int i=0; i<2; i++) {
        int num1 = number / div1;
        int num2 = number % div2;
        if(num1 != num2) {
            Console.WriteLine($"Число не является палиндромом!");
            return;
        }
        number = (number % div1) / div2;
        div1 /= 100;
    }
    Console.WriteLine("Введенное число является палиндромом!");
}
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между двумя точками в 3D: {dist:f3}");
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number <= 0) {
    Console.Write("Число должно быть больше нуля!");
    return;
}

for(int i=1; i<=number; i++) {
    Console.Write(Math.Pow(i, 3) + (i<number?", ":""));
}