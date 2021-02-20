using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                int rInt = r.Next(0, 2);
                Console.WriteLine(rInt);
            }
        }
    }
}
