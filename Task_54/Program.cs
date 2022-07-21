// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
			if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}| ");
			else Console.Write($"{arr[i, j],3} |");
		}
		Console.WriteLine();
	}
}

void MatrixDescending(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			int max = j;
			for (int k = j + 1; k < array.GetLength(1); k++)
			{
				if (array[i, k] > array[i, max]) max = k;
			}
			int temp = array[i, j];
			array[i, j] = array[i, max];
			array[i, max] = temp;
		}
	}
}



int[,] arrayResult = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(arrayResult);
Console.WriteLine();
MatrixDescending(arrayResult);
PrintMatrix(arrayResult);