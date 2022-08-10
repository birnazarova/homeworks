// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,99);
Console.WriteLine($"Число: {number}");

if (number/10 > number%10) Console.WriteLine("Наибольшая цифра: " + number/10);
else Console.WriteLine("Наибольшая цифра: " + number%10);