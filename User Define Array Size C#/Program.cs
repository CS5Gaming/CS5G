using System;

namespace NewArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many movies you want to store? ");

            int n = Convert.ToInt32(Console.In.ReadLine());

            string[] size = new string[n];
  
            for(int i = 0; i<n; i++){

                 size[i] = Convert.ToString (Console.ReadLine());
            }

            Console.WriteLine("\nSort by Name: ");
            Array.Sort(size);

            for(int i=0; i<n; i++){

                Console.WriteLine(size[i]);
            }

            
            Console.ReadKey();
        }
    }
}