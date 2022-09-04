// Задать номер четверти, показать диапазоны для возможных координат

int number = new Random().Next(1, 5);
Console.WriteLine(number);

if (number == 1) Console.WriteLine("Диапазон: x>0, y>0");
else if (number == 2) Console.WriteLine("Диапазон: x<0, y>0");
else if (number == 3) Console.WriteLine("Диапазон: x<0, y<0");
else Console.WriteLine("Диапазон: x>0, y<0");
