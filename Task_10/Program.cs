// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// var rndNum = new Random().Next(100, 1000);
// int num = rndNum;
Console.Clear();
Console.Write("Введите трёхзначное число: ");

string num = Console.ReadLine();
Console.WriteLine("{0} -> {1}", num, num[1]);