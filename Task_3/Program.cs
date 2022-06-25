// Есть 2-х фикс. числа -> вывод их суммы
// int number1 = 5;
// int number2 = 12;
// Console.Write(number1 + number2);

// Ввод 2-х чисел и вывод их суммы
// Console.Write("Pleas, enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Pleas, enter second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("SUM = ");
// Console.Write(number1 + number2);

// Рандомный выбор 2-х чисел (1 - 10) и вывод их суммы
int number1 = new Random().Next(1, 10);
Console.WriteLine("First number = " + number1);
int number2 = new Random().Next(1, 10);
Console.WriteLine("Second number = " + number2);
Console.Write("SUM = ");
Console.Write(number1 + number2);
