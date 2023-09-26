// Завести массив из 5 чисел и вывести суммму чисел массива

int n = 5;
int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", array) + "]");

int summa = 0;
for (int i = 0; i < n; i++)
    summa += array[i];
Console.WriteLine(summa);