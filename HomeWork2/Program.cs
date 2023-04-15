Console.Clear();
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число\r\nи на выходе показывает вторую цифру этого числа.\r\n456 -> 5\r\n782 -> 8\r\n918 -> 1");

Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());
int first = a / 10;
int second = first % 10;
Console.WriteLine("Вторая цифра чиcла:   " + second);

Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();




Console.Clear();
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,\r\nчто третьей цифры нет.\r\n645 -> 5\r\n78 -> третьей цифры нет\r\n32679 -> 6");

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if(numberText.Length > 2)
{
    Console.WriteLine("третья цифра ->" + numberText[2]);
}
else
{
    Console.WriteLine("-> Третьей цифры нет");
}

Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();





Console.Clear();
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,\r\nи проверяет, является ли этот день выходным.\r\n6 -> да\r\n7 -> да\r\n1 -> нет");

Console.WriteLine("Введите цифру, обозначающую день недели:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void day_of_the_Week (int dayNumber)
{
    if(dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else if(dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Это не день недели");
    }
    else
    {
        Console.WriteLine("Этот день не выходной");
    }
}
day_of_the_Week(dayNumber);

Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();