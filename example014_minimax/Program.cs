// Отсортировать массив от мин к макс

 int[] array = { 1, 7, 9, 3, 4 , 5, 8, 2, 4, 2, 1};

 PrintArray(array);
 SelectionSort(array);
 PrintArray(array);

// Первая функция, на вывод массива:
  void PrintArray(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"\n");
 }


// Вторая функция, на упорядочение массива:
 void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}