// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("число m: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("число n: ");
int num1 = Convert.ToInt32(Console.ReadLine());

AckermannFunc(num, num1);


int AckermannFunc(int m, int n)
{

	if (m == 0)
		return n + 1;
	if (m > 0)
		if (n == 0)
			return AckermannFunc(m - 1, 1);
	return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}

int result = AckermannFunc(num, num1);
Console.WriteLine(result);