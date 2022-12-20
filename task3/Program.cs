/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] GetArray(int length)
{
    Random rnd = new Random();
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }

    return array;
}


// поиск max и min значения, нахождение разницы 
double MaxMin(double[] array)
{
    double max = 0;
    double min = 0;

    for (int i = 0; i < array.Length; i++)
    if (array[i] > max)
    {
        max = array[i];
    }

    else if (array[i] < min)
    {
        min = array[i];
    }

    Console.WriteLine($" Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

    return min;
    
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}

Console.WriteLine("Введите размер массива: ");
double[] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);


Console.WriteLine();
Console.WriteLine($"{MaxMin(array)}");

