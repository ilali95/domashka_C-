// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите число строк: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите min число: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите max число: ");
int max = int.Parse(Console.ReadLine());

Console.Clear();

int[,] CreateMatrixRndDouble(int m, int n, int min, int max)
{
	int[,] arr = new int[m, n];
	Random rnd = new Random();

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(min, max);
		}
	}
	return arr;
}

void PrintMatrix(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			if (j == 0) Console.Write("|");
			if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4} | ");
			else Console.Write($"{arr[i, j],4} | ");
		}
		Console.WriteLine();
	}
}

double ResultColumn(int[,] arr)
{
	double result = 0;
	double num = 0;
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			result += arr[i, j];
			num++;
		}
		result = Math.Round(result / num, 2);
	}
	return result;
}

int[,] arrayResult = CreateMatrixRndDouble(number, num, min, max);
double result = ResultColumn(arrayResult);
PrintMatrix(arrayResult);
Console.WriteLine($"Среднее арифметическое каждого столбца: {result}");