// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Задайте число M: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());

NumSum(num, num1);

int NumSum(int n, int n1)
{
	return n == n1 ? n : n + NumSum(n + 1, n1);
	// 	if (n == n1) return n;
	// 	return n + NumSum(n + 1, n1);
}


void PrintDegree(int res)
{
	Console.Write($"M = {num}; N = {num1}. -> {res}");
}

int res = NumSum(num, num1);
PrintDegree(res);
