Console.Clear();
Console.WriteLine("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,\r\nкакое число большее, а какое меньшее.\r\na = 5; b = 7 -> max = 7\r\na = 2 b = 10 -> max = 10\r\na = -9 b = -3 -> max = -3");
 
Console.WriteLine("Введите первое число:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Больше из двух чисел:");
if (a > b)
{
    double max = a;
    Console.WriteLine(max);
}
if (b > a)
{
    double max = b;
    Console.WriteLine(max);
}
Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();





Console.WriteLine("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.\r\n    2, 3, 7 -> 7\r\n    44 5 78 -> 78\r\n    22 3 9 -> 22");

Console.WriteLine("Введите три числа:");
int a1 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int c1 = int.Parse(Console.ReadLine());
Console.WriteLine("Максимальное число:");
if  (a1 > b1)
{
    int max = a1;
    Console.WriteLine(max);
}
if (b1 > c1)
{
    int max = b1;
    Console.WriteLine(max);
}
if (c1 > a1)
{
    int max = c1;
    Console.WriteLine(max); 
}

Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();





Console.WriteLine("Задача 6: Напишите программу, которая на вход принимает число и выдаёт,\r\nявляется ли число чётным (делится ли оно на два без остатка).\r\n4->да\r\n- 3->нет\r\n7->нет");

Console.WriteLine("Введите число:");
int a2 = int.Parse(Console.ReadLine());
if(a2 % 2 == 0)
{
    Console.WriteLine("Четное");
}
    else
{
    Console.WriteLine("Не делится без остатка, нечетное");
}

Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();






Console.WriteLine("Задача 8: Напишите программу, которая на вход принимает число (N),\r\nа на выходе показывает все чётные числа от 1 до N.\r\n5 -> 2, 4\r\n8 -> 2, 4, 6, 8");

Console.WriteLine("Введите число:");
int a3 = int.Parse(Console.ReadLine());
for (int b3 = 2; b3 <= a3; b3+=2)
{
    Console.Write(b3+" ");
}

Console.WriteLine("Задача завершена, нажмите что нибудь.");
Console.ReadKey();