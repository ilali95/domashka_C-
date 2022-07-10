// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



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
		if (i % 2 == 0) result += arr[i];
	}
	return result;
}


int[] array = RanArray(4, -99,100);
int number = NumArr(array);
PrintArray(array);
Console.Write($" Сума чисел на нечётных позициях = {number}");