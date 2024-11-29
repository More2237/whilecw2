using System;

namespace whilecw2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 10;
            
            int sum = 0;
            while (x < y)
            {
                sum += 1;
                x++;
                
            }
            Console.WriteLine(sum);   
        }
    }
}