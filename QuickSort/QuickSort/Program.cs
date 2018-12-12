using System;

public class Program
{
    public static void Main()
    {
        //https://en.wikipedia.org/wiki/Quicksort
        var a = new int[] { 3, 7, 8, 5, 2, 1, 9, 5, 4 };

        Show(a);

        int[] b = (int[])a.Clone();
        QuickSort(b, 0, b.Length - 1);
        Console.WriteLine();
        Show(b);

        Console.ReadLine();
    }

    private static void QuickSort(int[] array, int s, int e)
    {
        Console.WriteLine("QuickSort {0}-{1}", s, e);
        if (s < e) //elements to sort more then 1
        {
            int p = Partition(array, s, e);
            QuickSort(array, s, p - 1);
            QuickSort(array, p + 1, e);
        }
    }

    private static int Partition(int[] array, int s, int e)
    {
        int pivot = array[e];
        int i = s;
        for (int j = s; j <= e; j++)
        {
            if (array[j] <= pivot)
            {
                Swap(array, i, j);
                i++;
            }
        }
        return i - 1;
    }

    public static void Show(int[] values)
    {
        foreach (var i in values) { Console.Write(i); }
        Console.WriteLine();
    }

    private static void Swap(int[] array, int i1, int i2)
    {
        var tmp = array[i1];
        array[i1] = array[i2];
        array[i2] = tmp;
    }

}