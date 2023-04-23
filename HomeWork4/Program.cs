/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    power *= powerBase;
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель меньше нуля?");
        return false;
    }
return true;
}
int powerBase = Prompt("Введите число:");
int exponent = Prompt("Введите степень:");
if (ValidateExponent(exponent))
{
    Console.WriteLine($"Число{powerBase} в степени {exponent} равно {Power( powerBase, exponent)}");
}


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int Input(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int Sum(int numbers)
{
    int result = 0;
    while (numbers > 0)
    {
        result += numbers % 10;
        numbers /= 10;
    }
    return result;
}
int numbers = Input("Введите число: ");
Console.WriteLine($"Сумма всех цифр в числе {numbers} = {Sum(numbers)} ");





/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33-> [6, 1, 33]*/

int Input(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random rnd = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;

}
void PrintArray(int[] array)
{
    Console.WriteLine("[");
    for (int i = 0;i < array.Length;i++)
    {
        Console.WriteLine($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}");
    Console.WriteLine("]");
}
int Length = Input("Длина массива:");
int min = Input("Начальное значение чисел, для диапозона:");
int max = Input("Конечное значение чисел, для диапозона");
int[]array =  GenerateArray(Length, min, max);
PrintArray(array);