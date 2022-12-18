/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100,1000);
    }

    return array;
}

// печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// подсчитывает количество чётных чисел
int Count(int[] array)
{
   int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count ++;
    }
    return count;
}



int[] arr = InitArray(7);
PrintArray(arr);



Console.WriteLine();
Console.WriteLine($"{Count(arr)}");



