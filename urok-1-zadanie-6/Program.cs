// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();

char[] digits = number.ToCharArray();
 
Console.WriteLine(digits[2]);  
