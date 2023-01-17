// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray (double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(rnd.Next(1, 100));
    }
}
int arraySize = 5;
double[] array = new double[arraySize];
FillArray(array);
Console.WriteLine(string.Join(",", array));

double MaxNumber = array[4];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > MaxNumber)
    MaxNumber = array[j];
}

double MinNumber = array[0];
for (int z = 0; z < array.Length; z++)
{
    if (array[z] < MinNumber)
    MinNumber = array[z];
}

double result = MaxNumber - MinNumber;
Console.WriteLine(result);

