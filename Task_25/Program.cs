// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int Num(int number1, int number2)
{
	int num = 1;

	for (int i = 0; i < number2; i++)
	{
		num = num * number1;
	}
	return num;
}

int step = Num(num1, num2);
Console.WriteLine($" {num1}, {num2} -> {step}");