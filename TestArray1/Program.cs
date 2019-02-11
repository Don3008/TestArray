using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int from = 1;
            int to = 35;
            int temp;
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int randomNumber = rnd.Next(from, to);
                arr[i] = randomNumber;
            }
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                
            }
            foreach (int elem in arr)
            Console.Write(elem + "\t");
            Console.WriteLine();
            int l = arr[0];
            int r = arr.Last();
            int s = 32;
            while (l < r)
            {
                if (l + r == s)
                {
                    Console.WriteLine("S = " + l + " " + r);
                }
                else if (l + r > s)
                {
                    r = arr[n - 1];
                    //break;
                }
                else if (l + r < s)
                {
                    l = arr[l + 1];
                    //break;
                    
                }else
                Console.WriteLine("Такой суммы нет.");
                
            }
            

           
        }
    }
}
