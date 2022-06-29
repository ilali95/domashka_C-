// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Clear();

// string num = Console.ReadLine();
// while n > 100
// {
// 	// string num = Console.ReadLine();
// 	Console.WriteLine("Третья цифра числа {0}, это {2}.", num, num[1], num[2]);
// }
// else
// {
// 	Console.WriteLine("Третьей цифры нет");
// }
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
	// int num1 = (num / 100) % 10;
	Console.WriteLine("{0} -> {2}", num.ToString(), num.ToString()[1], num.ToString()[2]);
	// Console.WriteLine($"{num} -> {num1}");
}
else
{
	Console.WriteLine("Третьей цифры нет");
}
// string result = num > 99 ? "{0} -> {2}", num.ToString(), num.ToString()[1], num.ToString()[2] : "Третьей цифры нет"; не понимаю как этот условие записать в тернарном в виде