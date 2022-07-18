// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите номер строки: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine());
// Console.Write("Введите число строк: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write("Введите число столбцо: ");
// int num = int.Parse(Console.ReadLine());
// Console.Write("Введите min число: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Введите max число: ");
// int max = int.Parse(Console.ReadLine());

Console.Clear();

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
	int[,] arr = new int[m, n];
	Random rnd = new Random();

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = rnd.Next(min, max + 1);
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
			if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
			else Console.Write($"{arr[i, j],3} | ");
		}
		Console.WriteLine();
	}
}

void ResultLinesColumns(int[,] arr, int lin, int colum)
{
	int i = lin;
	int j = colum;
	if (i < arr.GetLength(0) && j < arr.GetLength(1))
	{
		Console.WriteLine(arr[i, j]);
	}
	else Console.WriteLine("Такого числа в массиве нет");
	return;
}

// int[,] arrayResult = CreateMatrixRndInt(number, num, min, max);
int[,] arrayResult = CreateMatrixRndInt(3, 8, 1, 9);
PrintMatrix(arrayResult);
ResultLinesColumns(arrayResult, lines, columns);