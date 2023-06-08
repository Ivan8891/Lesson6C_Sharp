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


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine(Count(FillArray("Введите длину множества: ")));

