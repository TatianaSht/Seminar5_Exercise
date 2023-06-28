// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray (int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-99, 99);
    }
}


void SumNonEvenIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    Console.Write($"Сумма элементов нечетных позиций массива равна: {sum}");
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

int [] array = new int [4];
FillArray(array);
PrintArray(array);
SumNonEvenIndex(array);
