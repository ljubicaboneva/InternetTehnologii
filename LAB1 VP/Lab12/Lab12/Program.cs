using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesete vrednost na N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vnesete {0} broevi: ",N);
            int[] Broevi = new int[N];
            float suma = 0;
            for (int i=0; i<N; i++)
            {
                Broevi[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = Broevi[0];
            int min = Broevi[0];
            foreach (int j in Broevi)
            {
                suma += j;
                if (j > max)
                {
                    max = j;
                }
                if (j < min)
                {
                    min = j;
                }
                
            }
            Console.WriteLine("Sredna vrednost na broevite e: {0}, Max: {1} i Min: {2}", suma/N, max, min);
            Console.ReadKey();
            
        }
    }
}
