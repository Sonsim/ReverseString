using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ReverseString;
namespace ReverseString
{
    internal class ReverseStuff
    {
        public static void menu()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("1. Reversere en setning");
            Console.WriteLine("2. Gjør en setning til store bokstaver");
            Console.WriteLine("3. Gjør en setning til små bokstaver");
            Console.WriteLine("4. Stokk om en setning i tilfeldig rekkefølge");
            Console.WriteLine("**************************************************");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    reversestring();
                    break;
                case "2":
                    Console.Clear();
                    toUpperCase();
                    break;
                case "3":
                    Console.Clear();
                    toLowerCase();
                    break;
                case "4":
                    Console.Clear();
                    randomOrder();
                    break;
            }
        }

       public static char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅabcdefghijklmnopqrstuvwxyzæøå".ToCharArray();

        
        

         static void reversestring()
        {
            Console.WriteLine("Skriv et setning");
            var input = Console.ReadLine();
            

            string reversestring = "";
            int length;

            length = input.Length -1;


            while (length >= 0)
            {
                reversestring = reversestring + input[length];
                length--;
            }
            Console.WriteLine(reversestring);
            backtoMenu();
        }

        static void toUpperCase()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Skriv en setning som skal gjøres til store bokstaver");
            var input = Console.ReadLine();

            string upper = "";
            

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'a' && input[i] <= 'z')
                {
                    upper += (char)(input[i] - 32);
                }
                else upper += input[i];
            }
            Console.WriteLine(upper);
            backtoMenu();
        }

        static void toLowerCase()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Skriv en setning som skal gjøres til små bokstaver");
            var input = Console.ReadLine();

            string lower = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    lower += (char)(input[i] + 32);
                }
                else lower += input[i];
            }
            Console.WriteLine(lower);
            backtoMenu();
        }

        static void randomOrder()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Skriv en setning og få alt i en tilfeldig rekkefølge");
            var input = Console.ReadLine();

            char[] chars = new char[input.Length];
            Random rand = new Random(input.Length);

            int index = 0;
            while (input.Length > 0)
            {
                int next = rand.Next(0, input.Length -1);

                chars[index] = input[next];

                input = input.Substring(0, next) +input.Substring(next + 1);

                ++index;
            }
            Console.WriteLine(chars);
            backtoMenu();
        }

        static void backtoMenu()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Gjøre noe annet? Y/N");
            var ans = Console.ReadLine();
            if (ans.ToLower() == "y")
            {
                Console.Clear();
                menu();
            }
            else if (ans.ToLower() == "n")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"{ans} er ikke en gyldig kommando");
                backtoMenu();
            }
        }
        
    }
}
