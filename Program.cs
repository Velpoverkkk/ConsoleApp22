using System;
class Program
{   //Для матрицы MxN поменять местами строку, содержащую элемент с наибольшим значением ,со строкой, с наименьшим 
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int N, M, a= 0,min,max;
        System.Console.WriteLine("Razmer massiva NxM");
        N = System.Convert.ToInt32(Console.ReadLine());
        M = System.Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[N, M];
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                array[j, k] = rnd.Next(0, 10);
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }
         System.Console.WriteLine();
        min = search_min(array, N, M);
        Console.WriteLine(min);
        max = search_max(array, N, M);
        Console.WriteLine(max);
        if (min == max) Console.WriteLine("V odnoi stroke");
        else
        {
            for (int i = 0; i < N; i++)
            {
                a = array[max, i];
                array[max, i] = array[min, i];
                array[min, i] = a;
            }
        }
        for (int j = 0; j < N; j++)
        {
            for (int k = 0; k < M; k++)
            {
                Console.Write(array[j, k] + " ");
            }
            Console.WriteLine();
        }


    }
    static int search_min(int[,] a,int N,int M)
    {
        int min = a[0,0], u = 0;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {
                if (min > a[i, j])
                {
                    min = a[i, j];
                    u = i;
                }
            }
        }
        return u;        
    }
    static int search_max(int[,] a, int N, int M)
    {
        int max = a[0, 0], u = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (max < a[i, j])
                {
                    max = a[i, j];
                    u = i;
                }
            }
        }
        return u;
    }


}
