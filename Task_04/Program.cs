﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите первое числа: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе числа: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье числа: ");
int numС = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numB > max) max = numB;
if (numС > max) max = numС;
{
	Console.Write(max);
}