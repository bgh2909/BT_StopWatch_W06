using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] arr = new int[100000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)rnd.Next();
            }
            StopWatch sw = new StopWatch();

            sw.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                int minCurrent = arr[i];
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (minCurrent > arr[j])
                    {
                        minCurrent = arr[j];
                        minIndex = j;
                    }

                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            sw.Stop();

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            sw.GetElapseTime();

            Console.WriteLine("Elapsed time: " + sw.GetElapseTime() + " milliseconds");
            
            Console.ReadKey();
        }
    }
}
