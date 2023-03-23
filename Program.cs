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

/* int[] CreateRandomArray(int size, int min, int max)
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
    int summa = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        summa = summa + array[i]; 
    }
    return summa;
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
*/

// Task 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

/* double[] CreateRandomArray(int size, int min,  int max)
{
    double[] array = new double[size];
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max) + new Random().NextDouble();
    }
    return array;
}

void WriteArray(double[]array)
{
    for(int i=0; i<array.Length; i++)
        Console.WriteLine(array[i]);
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<min) min = array[i];
    }
    return min;
}

Console.Write("Введите необходимое количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int mi = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int ma = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(N, mi, ma);

Console.WriteLine("В массиве: ");
WriteArray(newArray);
Console.WriteLine();
Console.WriteLine($"Разница минимального и максимального чисел равна {Max(newArray) - Min(newArray)}");
*/