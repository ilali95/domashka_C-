// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число: ");
int num =int.Parse(Console.ReadLine());
int sum = 0;
int i=0;

while (i < num.Length)
	{
		Console.WriteLine($"{num} -> {sum+i}");
		i++;
	}
// for (int i = 0; i<=num.Length; i++)
// {
//     Console.WriteLine($"{num} -> {sum+i}");
// }