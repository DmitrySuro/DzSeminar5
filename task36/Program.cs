/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

System.Console.Clear();

int[] NewArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int SumOddIndex(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
        {
            sum += array[i];
            i +=2;
        }
    return sum;
}


System.Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
array = NewArray(array);
System.Console.WriteLine("Вот массив");
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine("Сумма нечетных элементов = " + SumOddIndex(array));