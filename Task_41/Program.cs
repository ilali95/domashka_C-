// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа, через запятую: ");
string[] numbers = Console.ReadLine().Split(',');

int NumbersAboveZero(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		int num = Convert.ToInt32(array[i]);
		if (num > 0) count++;
	}
	return count;
}

NumbersAboveZero(numbers);
int result = NumbersAboveZero(numbers);
Console.Write($"-> {result} числа(ел) больше 0!");