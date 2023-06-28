// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void FillArray (double [] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    }
}

void FindMax (double [] arr, out double numMax)
{
    numMax = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > numMax)
        {
            numMax = arr [i];
        }
    }
 }


void FindMin (double [] arr, out double numMin)
{
    numMin = arr [0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < numMin)
        {
            numMin = arr [i];
        }
    }
}

void PrintArray (double [] arr)
{
    Console.WriteLine($"[{string.Join ("  ", arr)}]");
}


double [] array = new double [5];
FillArray(array);
FindMax(array, out double numberMax);
FindMin(array, out double numberMin);
PrintArray(array);
double difference = Math.Round((numberMax - numberMin), 2);
Console.WriteLine($"Максимальное значение: {numberMax}");
Console.WriteLine($"Минимальное значение: {numberMin}");
Console.Write("Разница между максимальным и минимальным значениями равна: " + difference);
