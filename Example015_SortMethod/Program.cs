// Сортировка массива по возрастанию 

int[] arr = {1, 5, 4, 3, 7, 3, 9, 4, 34, 25, 9827, 8734, 092374, 48,3498, 8974, 298,254,36740,7434,3, 2, 5, 4, 6, 3, 6, 18};

void PrintArray(int[] array)
{
    int count = array.Length;
    for( int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for( int i=0; i<array.Length; i++)
    {
        int minPosition = i;
        for(int j = i+1; j<array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);