// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите число строк: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите min число: ");
double min = double.Parse(Console.ReadLine());
Console.Write("Введите max число: ");
double max = double.Parse(Console.ReadLine());

Console.Clear();

double[,] CreateMatrixRndDouble(int m, int n, double min, double max)
{
	double[,] arr = new double[m, n];
	Random rnd = new Random();

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
		}
	}
	return arr;
}

void PrintMatrix(double[,] arr)
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

double[,] arrayResult = CreateMatrixRndDouble(number, num, min, max);
PrintMatrix(arrayResult);