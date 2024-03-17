// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello");
Console.WriteLine("World");
Console.WriteLine("Hi there");
public static double CalculateAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }

public static int FindMax(int[] array)
{
    int max = array[0];


    foreach (int num in array)
    {
        if (num > max)
        {
            max = num;
        }
    }

    return max;
}