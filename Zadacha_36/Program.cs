// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray (int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
}
int arraySize = 4;
int[] array = new int[arraySize];
FillArray(array);
Console.WriteLine(string.Join(",", array));


int sum = 0;
for (int j = 1; j < array.Length; j+=2)
    {
        sum = sum + array[j];
    }

Console.WriteLine(sum);