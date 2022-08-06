Console.Write("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine());

if(Number1 > Number2)
    Console.Write("Первое число больше второго!");
else
    Console.Write("Второе число больше первого");