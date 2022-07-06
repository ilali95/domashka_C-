// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// int[] array = new int[8];
// Random rand = new Random();
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// 	array[i] = rand.Next(0, 9); 
// 	Console.Write(array[i] + ",");
// 	// Console.WriteLine(MyString.Remove(0,5));
// }
// Console.Write("]");

int[] array = new int[8];
Random rand = new Random();

void Array(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = rand.Next(0, 8);
	}
}

void Print(int[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{arr[i]},");
		}
	Console.Write("]");
}
Array(array);
Print(array);