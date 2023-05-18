Console.Clear();

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


void FillArray(double[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0;j < matr.GetLength(1); j++)
            Console.Write($"{matr[i,j]} ");
        Console.WriteLine();
    }
}
void Task47()
{
    double[,] matr = new double[3, 4];
    FillArray(matr);
    PrintArray(matr);
}
//Task47();


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет*/

void FillArray1(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray1(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

bool CheckNumbersInArray(int[,] matr, int num)
{
    for (int i = 0;i < matr.GetLength(0); i++)
    {
        for(int j = 0;j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num) 
                return true;
        }
    }
    return false;
}

void Task50()
{
    int[,] matr = new int[3,4];
    FillArray1(matr);
    PrintArray1(matr);
    Console.WriteLine("Введите число которое нужно проверить в массиве: ");
    int num = int.Parse(Console.ReadLine());
    var result = CheckNumbersInArray(matr, num);
    if (result)
    {
        Console.Write("Число есть в двумерном массиве");
    }
    else
    {
        Console.Write("Числа нет в двумерном массиве");
    }
}
//Task50();

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

double[] MidSumArray(int[,] matr)
{
    double[] middlesum = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            middlesum[j] += matr[i, j];
        }
        middlesum[j] /= matr.GetLength(0);
    }
    return middlesum;
}
void PrintMidlleSum(double[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое столбца №{i + 1} = {num[i]}");
    }
}

void Task52()
{
    int[,] matr = new int[3, 4];
    FillArray1(matr);
    PrintArray1(matr);
    var result = MidSumArray(matr);
    PrintMidlleSum(result);
}
//Task52();