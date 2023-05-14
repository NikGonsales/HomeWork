Console.Clear();

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/

void Fill_numbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число №{i + 1} : ");
        numbers[i] = int.Parse(Console.ReadLine());
    }
}


void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


void PositiveNumbers(int[] numbers)
{
    int size = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            size += 1;
        }
    }
    Console.WriteLine(size);
}


void Positive()
{
    Console.Write($"Количество чисел введенные пользователем: ");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];
    Fill_numbers(numbers);
    Console.Write($"Введенные числа: ");
    PrintArray(numbers);
    Console.Write($"Количество положительных чисел: ");
    PositiveNumbers(numbers);
}


//Positive();


/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

bool Fill_num(double[] numbers)
{
    Console.Write($"Введите число b1: ");
    numbers[0] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число k1: ");
    numbers[1] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число b2: ");
    numbers[2] = double.Parse(Console.ReadLine());
    Console.Write($"Введите число k2: ");
    numbers[3] = double.Parse(Console.ReadLine());
    if (numbers[1] == numbers[3])
    {
        System.Console.WriteLine("Линии будут паралелльны, потому x и y не будет найден ");
        return false;
    }
    return true;
}


double x(double[] numbers)
{
    double x = (numbers[2] - numbers[0]) / (numbers[1] - numbers[3]);
    return x;
}


double y(double[] numbers, double x)
{
    double y = numbers[1] * x + numbers[0];
    return y;
}


void PrintResult(double x, double y)
{
    Console.Write($"({x} ; {y})");
}


void PrintArray1(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}


void Intersection()
{
    int size = 4;
    double[] numbers = new double[size];

    if (Fill_num(numbers) == false)
    {
        return;
    }
    Console.Write($"Имеющиеся числа: ");
    PrintArray1(numbers);
    Console.Write($"x: {x(numbers)} ");
    Console.Write($"y: {y(numbers, x(numbers))} ");
}


//Intersection();