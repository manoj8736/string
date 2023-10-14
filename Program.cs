using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, temp;
            Console.WriteLine("how many terms u want in array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter" + n + "elements:");
            for(i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("display original elements:");
            for(i=0;i<n;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("display sort elements:");
            for(i=0;i<n;i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
