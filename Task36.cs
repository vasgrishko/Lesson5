// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

var array = FillArray(4);
Print(array);
Console.WriteLine();
Console.WriteLine(GetSum(array));

int GetSum(int[] array)
{
    int sum = 0;
    int count = array.Length;
     
     for(int i = 1; i < count; i+=2)
     {
        sum+= array[i];
     } 
            
    return sum;
}


int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}