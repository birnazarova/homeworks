// Найти сумму чисел от 1 до А

int A = new Random().Next(1,10);
Console.WriteLine(A);

int i = 1;
int sum = 0;

while (i<=A)
{
    sum=sum+i;
    i++;
}

Console.WriteLine(sum);