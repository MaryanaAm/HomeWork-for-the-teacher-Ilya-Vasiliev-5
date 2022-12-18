// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    return result;
}


double[] InitArray(int dimention)
{
    double[]array = new double[dimention];
    Random rnd = new Random();

    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next(10, 40);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

(double, double, double) GetNMinMaxAndResalt(double[]array)
{
    double max = array[0];
    double min = array[1];
    if(min > max)
    {
        double temp = max;
        max = min;
        min = temp;
    }

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
    }
    
    double result = max - min;
    return (max, min, result);
}

int dimention = GetNumber("Введите длину массива: ");
double[] array = InitArray(dimention);
PrintArray(array);
(double max, double min, double result) = GetNMinMaxAndResalt(array);
Console.WriteLine($"Max number: {max}, Min number: {min}, Result: max - min = {result} ");