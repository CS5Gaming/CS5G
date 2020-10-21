using System;

namespace If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prepare for your math exam: \n");
            double randomNumber;
            double randomNumber1;
            double randomNumber2;
            Random random = new Random();
            randomNumber = random.Next(0,10);
            randomNumber1 = random.Next(0,10);
            randomNumber2= random.Next(0,10);

            double result= randomNumber*randomNumber1/randomNumber2;
            Console.WriteLine(+randomNumber+"*"+randomNumber1+"/"+randomNumber2);
            double uresult = Convert.ToDouble( Console.ReadLine());
            if (uresult==result){
                Console.WriteLine(" Correct");
            }
            else
            Console.WriteLine("Incorrect");

            Console.ReadKey();
        }
    }
}
