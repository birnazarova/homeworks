﻿// Подсчитать сумму цифр в числе

Console.Write("Type a number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;

while (number != 0) {
   sum += number % 10;
   number /= 10;
}
Console.WriteLine(sum);