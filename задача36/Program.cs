//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Clear();
int[] arr = RandomArray();
System.Console.WriteLine($"[{String.Join(", ", arr)}] -> {ResultElements(arr)}");

int[] RandomArray()
{
    int size = new Random().Next(1,10);
    int[] ar = new int[size];
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = new Random().Next(1,20);
    }
    return ar;
}

int ResultElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        sum += array[i];
    }
    return sum;
}