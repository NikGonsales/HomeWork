Console.Clear();

void FillArray(int[] nums)
{
	Random rnd = new Random();
	for (int i = 0; i < nums.Length; i++)
	{
		nums[i] = rnd.Next(100, 999);
	}
}

void FillArray1(int[] numbers, int minValue = -9, int maxvalue = 10)
{
	maxvalue++;
	Random rnd = new Random();
	for(int i = 0;i < numbers.Length;i++)
	{
		numbers[i] = rnd.Next(minValue, maxvalue);
	}

}
void PrintArray(int[] numbers)
{
	Console.Write("[");
	for (int i = 0; i < numbers.Length; i++)
	{
		Console.Write($"{numbers[i]},");
	}
	Console.Write("]");
	Console.WriteLine();
}

int EvenNumbers(int[] numbers)
{
	int count = 0;
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i]% 2 == 0)
		count++;
	}
	return count;
}

int Sum_Numbers_i(int[] numbers)
{
	int result = 0;
	for (int i = 0; i < numbers.Length; i++)
	{
		if(i % 2 != 0)
		{
			result = result + numbers[i];
		}
	}
	return result;
}

void Fill_double(double[] numbers)
{
	Random rnd = new Random();
	for (int i = 0; i < numbers.Length; i++)
	{
        numbers[i] = Math.Round(rnd.NextDouble( ) * 5 , 1);
    }
}

void Print_double(double[] numbers)
{
	for (int i = 0;i < numbers.Length; i++)
		{
			Console.Write(numbers[i]);
		}
	Console.WriteLine();
}

double min_num (double[] numbers)
{
	double min = numbers[0];
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] < min)
		{
			min = numbers[i];
		}
	}
	return min;    
}

double max_num (double[] numbers)
{
	double max = numbers[0];
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] > max)
		{
			max = numbers[i];
		}
	}
	return max;    
}


/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void Even()
{
	Console.WriteLine("Введите размер массива");
	int size = int.Parse(Console.ReadLine());
	int[] numbers = new int[size];
	Console.Write("Созданный массив:");
	FillArray(numbers);
	PrintArray(numbers);
	Console.WriteLine($"Количество четных чисел в массиве -> {EvenNumbers(numbers)}");
}
//Even();


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0*/

void Sum_i()
{
	Console.WriteLine("Введите размер массива");
	int size = int.Parse(Console.ReadLine());
	int[] numbers = new int[size];
	Console.Write("Созданный массив:");
	FillArray1(numbers);
	PrintArray(numbers);
	Console.WriteLine($"Сумма чисел с нечетным индексом = {Sum_Numbers_i(numbers)}");
}
//Sum_i();


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

[3,21 7,04 22,93 -2,71 78,24] -> 80,95*/
void min_difference_max()
{
	Console.WriteLine("Введите размер массива");
	int size = int.Parse(Console.ReadLine());
	double[] numbers = new double[size];
	Fill_double(numbers);
	Console.WriteLine("Созданный массив:");
	Print_double(numbers);
	double min = min_num(numbers);
	double max = max_num(numbers);
	double result = max - min;
    Console.WriteLine($"Минимальное значение: {min_num(numbers)}");
    Console.WriteLine($"Максимальное значение: {max_num(numbers)}");
    Console.WriteLine($"Разница между минимальным и максимальным числом -> {result}");
}
//min_difference_max();