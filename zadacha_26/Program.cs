// № 25 Найти сумму чисел от 1 до А
int numberA = new Random().Next(1, 100);
int sum = 0;
int i = 1;
while (i <= numberA)
{
    sum = sum + numberA;
    i++;
}
Console.WriteLine("Сумма чисел от 1 до " + numberA + "   равна   " + sum);

int a = 100;
int sum = (a*(a+1))/2;
Console.WriteLine(sum);
