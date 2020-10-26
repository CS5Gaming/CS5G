using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Random random1 = new Random();
            Console.WriteLine("Roll both dice: ");
            
            int roll = 0 ;
            int roll1 = 1 ;
            int attempts = 0 ;
            while(roll != roll1 ) {
                Console.ReadKey();
                roll = random.Next(1, 7);
                roll1 = random1.Next(1, 7);
                Console.WriteLine("You rolled: " +roll);
                Console.WriteLine("You rolled: " +roll1);
                attempts++;
            }
            Console.WriteLine("It took you " +attempts+ " attempts to get same dice");

            Console.ReadKey();
        }
    }
}
