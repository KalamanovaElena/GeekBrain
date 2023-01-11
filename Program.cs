Console.WriteLine("Введи число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 > num2) 
	{Console.WriteLine($"Большее число {num1}, меньшее число {num2}");}
    else if (num2 > num1)
		{Console.WriteLine($"Большее число {num2}, меньшее число {num1}");}