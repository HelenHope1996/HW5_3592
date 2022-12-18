/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }

    return array;
}

int[] Summ(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
         summ = summ += array[i];    
    }
    Console.WriteLine($"Сумма нечетных элементов = {summ}");
   return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}, ");
    }
}

Console.WriteLine("Введите размер массива: ");
int[] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);
int[] arr = Summ(array);



