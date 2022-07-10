// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] RanArray(int size)
{
	double[] arr = new double[size];
	Random rnd = new Random();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rnd.Next(1, 20);
	}
	return arr;
}

void PrintArray(double[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (i == 0) Console.Write("[");
		if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
		else Console.Write(arr[i] + "]");
	}
}

double MaxMin(double[] arr)
{
	double max = arr[0];
	double min = arr[0];
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > max) max = arr[i];
		if (arr[i] < min) min = arr[i];
	}
	return max - min;
}

double[] array = RanArray(10);
double result = MaxMin(array);
PrintArray(array);
Console.Write( $" -> {result}");