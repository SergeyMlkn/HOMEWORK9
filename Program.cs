// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


int size = new Random().Next(5, 10);
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int newArraySize = NewArraySize(numbers);
int[] newArray = new int[newArraySize];

int indexLast = numbers.Length - 1;
for (int i = 0; i < numbers.Length; i++)
{
    if (i < indexLast)
    {
        newArray[i] = numbers[i] * numbers[indexLast];
        indexLast--;
    }
    else if (i == indexLast)
    {
        newArray[i] = numbers[i];
    }
}

PrintArray(newArray);

int NewArraySize(int[] array)
{
    int arrayLength = array.Length;
    int size = 0;
    if (arrayLength % 2 == 1)
    {
        size = (arrayLength / 2) + 1;
    }
    else
    {
        size = (arrayLength / 2);
    }
    return size;
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}