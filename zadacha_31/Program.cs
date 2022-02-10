// № 31 Задать массив из 8 элементов и вывести их на экран
int [] array = new int [8];
Random rnd1 = new Random();

for (int a = 0; a < array.Length; a++)
{array[a] = rnd1.Next(1,7);
Console.Write(array[a] + " ");
}
Console.WriteLine();