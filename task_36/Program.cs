// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int [] randomArray(int length, int start, int end)
{   int[] result = new int[length];
    for(int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end+1);
    }
    return result;
}

int getUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine("]");
        }
    }
}

int getSumOfUnevenPositions(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
    
int length = getUserData("Введите длину массива: ");
int[] array = randomArray(length, -100, 100);
printArray(array);
int sum = getSumOfUnevenPositions(array);
Console.WriteLine($"Сумма чисел на нечетных позициях равна: {sum}");
