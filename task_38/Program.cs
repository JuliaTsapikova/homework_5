// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double [] randomArray(int length, int start, int end)
{   double[] result = new double[length];
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

void prdoubleArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
            Console.Write(" ");
        }
        else
        {
            Console.WriteLine("]");
        }
    }
}

double getMaxNumber (double[] array)
{
    double maxNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}
    
double getMinNumber(double[] array)
{
   double minNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]<minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber; 
}
int length = getUserData("Введите длину массива: ");
double[] array = randomArray(length, -100, 100);
prdoubleArray(array);
double maxNumber = getMaxNumber(array);
Console.WriteLine($"Максимальный элемент массива равен: {maxNumber}");
double minNumber = getMinNumber(array);
Console.WriteLine($"Минимальный элемент массива равен: {minNumber}");
double subtraction = maxNumber-minNumber;
Console.WriteLine($"Разница максимального и минимального элементов равна: {subtraction}");