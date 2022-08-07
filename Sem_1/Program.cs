//Console.Write("Введите первое число: ");
//int Number1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//int Number2 = int.Parse(Console.ReadLine());

//if(Number1 > Number2)
//    Console.Write("Первое число больше второго!");
//else
//    Console.Write("Второе число больше первого");

/*
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
*/
/*
//Третья задача
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0) {
    Console.Write($"Число {number} четное!");
} else {
    Console.Write($"Число {number} нечетное!");
}
*/
/*
//Четвертая задача
Console.Write("Введите число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
int i = 2;
string txt = "";

while(i <= number) {
    txt += i.ToString() + ", ";
    i += 2;
}

Console.Write(txt);
*/


Console.Write("Введите порядковый номер дня недели: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
string txt = "";

switch(number) {
    case 1: txt = "Понедельник";    break;
    case 2: txt = "Вторник";        break;
    case 3: txt = "Среда";          break;
    case 4: txt = "Черверг";        break;
    case 5: txt = "Пятница";        break;
    case 6: txt = "Суббота";        break;
    case 7: txt = "Воскресенье";    break;
    default: txt = "Не корректное число!";  break;
}
Console.Write(txt);