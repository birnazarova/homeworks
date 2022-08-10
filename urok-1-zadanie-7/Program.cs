// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: "); // 325
int number = int.Parse(Console.ReadLine());
 
Console.WriteLine(number/10%10);
