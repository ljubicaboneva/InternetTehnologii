using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static float SrednaVrednost(int [] br) 
        {
            int suma = 0;
            foreach (int j in br)
            {
                suma += j;

            }
            float rez = suma / br.Length;
            return rez ;
        }
        static int Max(int [] br,out int max)
        {
             max = br[0];
            
            foreach (int j in br)
            {
                if (max < j)
                {
                    max = j;
                } 

            }
            return max;
        }
        static int Min(int[] br, out int min)
        {
             min = br[0];

            foreach (int j in br)
            {
                if (j<min)
                {
                    min = j;
                }

            }
            return min;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Glavno meni: ");
                Console.WriteLine("1. Opcija za vnesuvanje racno broevi \n2. Opcija za generiranje sluchajni broevi \n3. Izlez od programata");
                int broj = 0;
                int flag = 0;
                Random random = new Random();
                int izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Izbravte racno vnesuvanje na broevi! ");

                        break;


                    case 2:
                        Console.WriteLine("Izbravte sluchajno generiranje na broevi! ");

                        break;

                    case 3:

                        flag = 1;
                        break;

                    default:
                        Console.WriteLine("Nevaliden izbor! Probaj povtorno!");
                        break;
                }
                if (flag == 1)
                {
                    break;
                }


                Console.WriteLine("Vnesete vrednost na N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                int[] Broevi = new int[N];
                
                for (int i = 0; i < N; i++)
                {
                    if (izbor == 1) {
                        broj = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (izbor == 2) {
                        broj = random.Next(1, 1000);
                    }
                    Broevi[i] = broj;
                }
                Max(Broevi,out int max);
                Min(Broevi,out int min);
                float sredna = SrednaVrednost(Broevi);
                Console.WriteLine("Sredna vrednost na broevite e: {0}, Max: {1} i Min: {2}", sredna, max, min);


            }
        }
    }
}
