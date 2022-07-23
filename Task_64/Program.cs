﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num} -> ");
NaturalNumber(num);

void NaturalNumber(int number)
{
	if (number == 0) return;
	Console.Write($"{number} ");
	NaturalNumber(number - 1);
}