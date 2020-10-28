using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int wordNum = WordCount();
            Console.WriteLine("There is " + wordNum + " words in the sentence");
            Console.ReadKey();
        }
        static int WordCount()
        {
            int count = 1, lengt=0;
            Console.WriteLine("Enter a sentence: ");
            string array = Console.ReadLine();
            while(lengt<=array.Length -1)
            {
                if(array[lengt]==' ' || array[lengt]=='\n' || array[lengt]=='\t')
                {
                    count++;
                }
                lengt++;
            }
            return count;
        }
    }
}
