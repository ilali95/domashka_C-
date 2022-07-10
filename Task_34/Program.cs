// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int[] RanArray(int size, int min, int max)
{
	int[] arr = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rnd.Next(min, max + 1);
	}
	return arr;
}

void PrintArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (i == 0) Console.Write("[");
		if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
		else Console.Write(arr[i] + "]");
	}
}
int NumArr(int[] arr)

{
	int result = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] % 2 == 0) result += 1;
	}
	return result;
}


int[] array = RanArray(4, 100, 1000);
int number = NumArr(array);
PrintArray(array);
Console.Write($" Количество четных чисел = {number}");