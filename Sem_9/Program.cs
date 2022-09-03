/*
Задача 66:
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

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