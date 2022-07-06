// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int sum = 0;

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];


Console.WriteLine("Введите число, равное вашему массивному размеру");
string s = Console.ReadLine();


for (int i = 0; i < s.Length; i++)
{
	arr[i] = int.Parse(s[i].ToString());
}

for (int i = 0; i < arr.Length; i++)
{
	sum = arr[i] + sum;
}



Console.WriteLine(sum);
Console.ReadLine();