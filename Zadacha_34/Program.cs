// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

void FillArray (int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}
int arraySize = 4;
int[] array = new int[arraySize];
FillArray(array);
Console.WriteLine(string.Join(",", array));

int result = 0;
for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        result++;
    }
    
Console.WriteLine(result);
