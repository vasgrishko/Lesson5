// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

var array = FillArray(5);
Print(array);
Console.WriteLine();
Console.WriteLine(GetDiff(array));

int GetDiff(int[] array)
{
    int sum = 0;
    int count = array.Length;
    int min = array[0];
    int max = array[0];
    
    for(int i = 0; i < count; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
        
        if(array[i] > max && array[i] > min)
        {
           max = array[i];
        }
        
        sum = max - min;
    } 
          
    return sum;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
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