Console.Clear();
Console.WriteLine("Задача 19\r\nНапишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.\r\n14212 -> нет\r\n12821 -> да\r\n23432 -> да");

bool Palindrom(string s)
{
    for (int i = 0; i < s.Length / 2; i++)

        if (s[i] != s[s.Length - i - 1])
            return false;
    return true;
}
Console.WriteLine("Введите число:");
int s = int.Parse(Console.ReadLine());
string str = s.ToString();
Console.WriteLine("Палиндром? -> " + Palindrom(str));

Console.ReadKey();


Console.Clear();

Console.WriteLine("Задача 21\r\nНапишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.\r\nA (3,6,8); B(2, 1, -7), -> 15.84\r\nA(7, -5, 0); B(1, -1, 9)-> 11.53");

Console.WriteLine("Введите координаты первой точки:");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine("Расстояние в 3D пространстве -> " + result);

Console.ReadKey();


Console.Clear();

Console.WriteLine("Задача 23\r\n\r\nНапишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.\r\n\r\n3 -> 1, 8, 27\r\n5 -> 1, 8, 27, 64, 125");


void Pow(double N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
Console.WriteLine("Введите число:");
Pow(double.Parse(Console.ReadLine()));
