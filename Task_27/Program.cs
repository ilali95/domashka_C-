// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int sum = 0;
// Console.WriteLine("Введите количество цифр: ");
// int size = int.Parse(Console.ReadLine());
// int[] arr = new int[size];


// Console.WriteLine("Введите число: ");
// string s = Console.ReadLine();

// for (int i = 0; i < s.Length; i++)
// {
// 	arr[i] = int.Parse(s[i].ToString());
// }

// for (int i = 0; i < arr.Length; i++)
// {
// 	sum = arr[i] + sum;
// }

// Console.WriteLine(sum);
// Console.ReadLine();


// этот вариант мне подсказали я бы сам не додумался
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
	int summa = 0;
	while (number > 0)
	{
		summa += number % 10;
		number = number / 10;
	}
	return summa;
}

int sum = Sum(num);
Console.WriteLine($"{num} -> {sum}");