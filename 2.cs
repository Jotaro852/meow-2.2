using System;

class meow22
{
    static void Main()
    {
        int n = 10; // Размер массива
        int[] oddNumbers = new int[n];
    
        for (int i = 0, num = 1; i < n; i++, num += 2)
        {
            oddNumbers[i] = num;
        }
    
        Console.WriteLine("Массив последовательных нечетных чисел:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
    }
}
