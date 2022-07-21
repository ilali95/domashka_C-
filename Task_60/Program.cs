// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента. 
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] CreateMatrixRndInt(int m, int n, int z)
{
	int[,,] arr = new int[m, n, z];
	Random rnd = new Random();

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				arr[i, j, k] = rnd.Next(10, 100);
				
			}
		}
	}
	return arr;
}

void PrintMatrix(int[,,] arr)
{
	Console.WriteLine($"Массив размерности [{arr.GetLength(0)},{arr.GetLength(1)},{arr.GetLength(2)}] ↓");

	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			for (int k = 0; k < arr.GetLength(2); k++)
			{
				Console.Write($"{arr[i, j, k]}({i},{j},{k})  ");
			}
		}
		Console.WriteLine();
	}
}

Console.Write("Введите m: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите z: ");
int num3 = int.Parse(Console.ReadLine());

int[,,] arrayResult = CreateMatrixRndInt(num1, num2, num3);
PrintMatrix(arrayResult);