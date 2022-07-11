// Напишите программу которая задаёт массив из 8 элементов и выводит их на экран.

void fillArray (int[] arr)
{
    int length = arr.Length;
    for (int index = 0; index < length; index++)
        {
            arr[index] = new Random().Next(1,100);
        }
}

int[] array = new int[8];

fillArray(array);

Console.Write("[ ");
Console.Write(string.Join(" | ", array));
Console.WriteLine(" ]");