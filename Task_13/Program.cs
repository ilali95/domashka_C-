// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Clear();
Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
string num = Console.ReadLine();

// while n > 100
// {
// 	// string num = Console.ReadLine();
// 	Console.WriteLine("Третья цифра числа {0}, это {2}.", num, num[1], num[2]);
// }
// else
// {
// 	Console.WriteLine("Третьей цифры нет");
// }
if (num > 99)
{
	// int num1 = (n % 100) % 10;
	Console.WriteLine("{0} -> {3}", num, num[3]);
}
else
{
	Console.WriteLine("Третьей цифры нет");
}