int[] FillArray(string text)
{
    Console.WriteLine(text);
	int length = Convert.ToInt32(Console.ReadLine());
	int[] array = new int[length];
	for(int i = 0; i < length; i++)
	{
        Console.WriteLine("Введите число: ");
		int number = Convert.ToInt32(Console.ReadLine());
		array[i] = number;
	}
	return array;
}

string Count(int[] array)
{
	int count = 0;
	foreach(int i in array)
	{
		if (i > 0) count++;
	}
	return $"Колличество чисел больше 0 - {count}";
}

double InputNumber(string text)
{
    Console.WriteLine(text);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

string Point(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    return $"{y1}; {y2}";
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Задача 41:");
Console.WriteLine(Count(FillArray("Введите длину множества: ")));

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Задача 43:");
Console.WriteLine(Point(InputNumber("Введите k1: "), InputNumber("Введите b1: "), InputNumber("Введите k2: "), InputNumber("Введите b2: ")));
