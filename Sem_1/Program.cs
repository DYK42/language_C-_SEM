//Console.Write("Введите первое число: ");
//int Number1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int Number2 = int.Parse(Console.ReadLine());

//if(Number1 > Number2)
//    Console.Write("Первое число больше второго!");
//else
//    Console.Write("Второе число больше первого");


// Вторая задача
Console.Write("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int Number3 = int.Parse(Console.ReadLine());

int max = Number1;
if(Number2 > max) {
    max = Number2;
}
if(Number3 > max) {
    max = Number3;
}
Console.Write($"Максимальное число из введенных: {max}");