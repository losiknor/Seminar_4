// № 29 Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите значение N: ");
int a = int.Parse(Console.ReadLine());
int i = 1;
int num = 1;
while (i <= a)
{
    num = num * i;
    i++;
}
Console.WriteLine("Произведение чисел от 1 до " + a + "   равно   " + num);
