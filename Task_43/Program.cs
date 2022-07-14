// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите переменную b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите переменную k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите переменную b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите переменную k2: ");
double k2 = double.Parse(Console.ReadLine());

double CoordinateX(double number1, double factor1, double number2, double factor2)
{
	double coordinateX = (number2 - number1) / (factor1 - factor2);
	return coordinateX;
}

double CoordinateY(double number1, double factor1, double coordinateX)
{
	double coordinateY = factor1 * coordinateX + number1;
	return coordinateY;
}

void Print(double firstCoordinate, double secondCoordinate)
{
	Console.WriteLine($"Точка пересечения лежит в координатах ({firstCoordinate};{secondCoordinate})");
}

CoordinateX(b1, k1, b2, k2);
double x = CoordinateX(b1, k1, b2, k2);
CoordinateY(b1, k1, x);
double y = CoordinateY(b1, k1, x);
Print(x, y);