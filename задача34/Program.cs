//  34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] arrey = GiveAr();
Console.WriteLine($"[{String.Join(", ", arrey)}] -> " + Result(arrey));

int[] GiveAr()
{
    int dimension = new Random().Next(2,15);
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int Result(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        number++;
    }
    return number;
}