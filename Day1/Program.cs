using System;
using System.Globalization;

class Program
{

    static void Task1()
    {
        int n = 0;
        do
        {
            Console.WriteLine("Put in n>0 and n<1000:");
            int.TryParse(Console.ReadLine(), out n);
        } while (n <= 0 || n > 1000);


        int[] arr = new int[n];
        Console.WriteLine("Fill the array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("arr[:" + i + ']');
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        int s = 0;
        for (int i = 0; i < n; i++)
        {
            s += arr[i];
        }
        Console.WriteLine("sum: " + s);
    }

    static void Task2()
    {
        int pointA = 0, pointB=0;
        int[] Alice = new int[3]; 
        int[] Bob = new int[3];
        Console.WriteLine("Put in Alice data: ");
        for(int i=0; i<3; i++)
        {
            Console.WriteLine("arr[:" + i + ']');
            int.TryParse(Console.ReadLine(), out Alice[i]);
        }
        Console.WriteLine("Put in Bob data: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Bob[:" + i + ']');
            int.TryParse(Console.ReadLine(), out Bob[i]);
        }
        for (int i = 0; i < 3; i++)
        {
            if (Alice[i] > Bob[i]) pointA += 1;
            if (Alice[i] < Bob[i]) pointB += 1;
            if (Alice[i] == Bob[i]) {
                pointA += 0;
                pointB += 0;
            };
        }
        int[] res = new int[2];
        res[0] = pointA;
        res[1] = pointB;
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Final("+ i + "): "+ res[i]);
        }
    }
    static void Main(string[] args)
    {
        Task1();
        Task2();
    }
}