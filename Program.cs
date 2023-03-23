// Подготовил Раевский Р.Ю.
// Task 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


/* int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void WriteArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
}

int Skolko(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++; 
    }
    return count;
}

Console.Write("Введите необходимое количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(N);

Console.WriteLine("В массиве: ");
WriteArray(newArray);
Console.WriteLine();
Console.WriteLine($"{Skolko(newArray)} чётных чисел.");
*/

// Task 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void WriteArray(int[]array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
}

int Sum(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        count = count + array[i]; 
    }
    return count;
}

Console.Write("Введите необходимое количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int mi = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int ma = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(N, mi, ma);

Console.WriteLine("В массиве: ");
WriteArray(newArray);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных по индексу чисел равна {Sum(newArray)}.");