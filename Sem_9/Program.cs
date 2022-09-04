/*
Задача 66:
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30


int GetSumRecursion(int numStart, int numStop)
{
    if(numStart == numStop) return numStart;
    else
    {
        if(numStart > numStop)
        {
            int temp = numStop;
            numStop = numStart;
            numStart = temp;
        }
    }
    
    return  numStart + GetSumRecursion(numStart + 1, numStop);
}

Console.Write("Введите число начала интервала для подсчета суммы элементов: ");
int numStart = int.Parse(Console.ReadLine());
Console.Write("Ввведите число окончания интервала для подсчета суммы элементов: ");
int numStop = int.Parse(Console.ReadLine());

int sum = GetSumRecursion(numStart, numStop);
Console.Write($"Сумма элементов интервала от {numStart} до {numStop} равна: {sum}");
*/

/*
Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29


int GetAkkermanMethod(int m, int n)
{
    if(m < 0 || n < 0) return -1;

    if(m == 0) return n + 1;
    else
    {
        if(m > 0)
        {
            if(n == 0) return GetAkkermanMethod(m - 1, 1);
            else return GetAkkermanMethod(m - 1, GetAkkermanMethod(m, n - 1));
        }
    }

    return -1;
}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Ввведите число n: ");
int n = int.Parse(Console.ReadLine());

int value = GetAkkermanMethod(m, n);

if(value < 0)
{
    Console.Write("Должны быть введены неотрицательные целые числа!");
}
else
{
    Console.Write($"Вычисление функции Аккермана ( где m = {m}; n = {n} ) равно: {value}");
}
*/

/*
Задача со звездочкой: 
Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, 
сгруппированных в упорядоченные пары.

Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена
*/


int CheckCharacterSequence(string seq, int i)
{
    int balance = 0;

    if("({[".Contains(seq[i].ToString()))
    {
        switch (seq[i].ToString())
        {
            case "(":
                balance++;
                break;
            case "{":
                balance += 2;
                break;
            case "[":
                balance += 3;
                break;
        }
        //Console.WriteLine($"{i} >> {balance}");
        return (i + 1 < seq.Length ? balance + CheckCharacterSequence(seq, i + 1) : balance);
    }
    if(")}]".Contains(seq[i].ToString()))
    {
        switch (seq[i].ToString())
        {
            case ")":
                balance--;
                break;
            case "}":
                balance -= 2;
                break;
            case "]":
                balance -= 3;
                break;
        }
        //Console.WriteLine($"{i} >> {balance}");
        return (i + 1 < seq.Length ? balance + CheckCharacterSequence(seq, i + 1) : balance);
    }
    if(" ".Contains(seq[i].ToString()))
    {
        return (i + 1 < seq.Length ? balance + CheckCharacterSequence(seq, i + 1) : balance);
    }
    return balance;
}

Console.Write("Введите скобочную последовательность: ");
string seq = Console.ReadLine();
Console.WriteLine();
int balance = CheckCharacterSequence(seq, 0);
Console.WriteLine($"{balance}");
Console.Write($"Была введена {(balance != 0 ? "НЕ" : "")}правильная скобочная последовательность.");

