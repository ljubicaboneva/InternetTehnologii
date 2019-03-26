using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._4
{
    enum PasswordStrenght
    {
        easy,
        normal,
        hard
    }
    class Program
    {
        static string GeneratePassword(PasswordStrenght passwordStrenght)
        {
            Random rd = new Random();
            StringBuilder sb=new StringBuilder();
            
            string bukvi1 = "abcdefghijklmnopqrstuvwxyz";
            string bukvi2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string bukvi3 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?!#$%&*";
            

            if (passwordStrenght == PasswordStrenght.easy)
            {
                int i = rd.Next(1, 6);
                while(i>0)
                {
                    sb.Append(bukvi1[rd.Next(1,26)]);
                    i--;
                }
            }
            else if(passwordStrenght == PasswordStrenght.normal)
            {
                int j = rd.Next(6, 10);
                while (j>0)
                {
                    sb.Append(bukvi2[rd.Next(1, 61)]);
                    j--;
                }
            }
            else if (passwordStrenght == PasswordStrenght.hard)
            {
                int k = rd.Next(10, 50);
                while (k>0)
                {
                    
                    sb.Append(bukvi3[rd.Next(1, 59)]);
                    k--;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }

            return sb.ToString();
        }


        static void Main(string[] args)
        {
            string pass1 = GeneratePassword(PasswordStrenght.hard);
            string pass2 = GeneratePassword(PasswordStrenght.normal);
            string pass3 = GeneratePassword(PasswordStrenght.easy);
            
            string passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);

            for(int i = 0; i < parts.Length; i++)
            {
                if(pass1==parts[i])
                {
                    Console.WriteLine("Tochen pass1 na {0} pozicija od parts",i);
                }
                else if (pass2 == parts[i])
                {
                    Console.WriteLine("Tochen pass2 na {0} pozicija od parts", i);
                }
                else if (pass3 == parts[i])
                {
                    Console.WriteLine("Tochen pass3 na {0} pozicija od parts", i);
                }
                else
                {
                    Console.WriteLine("Pogreshena lozinka vo {0} obid",i);
                    
                    
                }
            }
            Console.ReadLine();



        }
    }
}
