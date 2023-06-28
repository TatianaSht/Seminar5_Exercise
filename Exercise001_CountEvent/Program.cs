// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray (int [] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
}


void PrintArray (int [] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}


void CountEvent (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
            count += 1;
        }
    }
    Console.Write($"Количество четных чисел в массиве равно: {count}");
}

int [] array = new int [4];
FillArray (array);
PrintArray (array);
CountEvent (array);