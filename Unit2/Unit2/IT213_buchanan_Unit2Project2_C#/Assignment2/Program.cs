using System;

namespace Assignment2
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            int par = 3;
            int strokes = 4;

            if (par < strokes)
            {
                Console.WriteLine("score is above par");
            }
            if (par == strokes)
            {
                Console.WriteLine("score is equal to par");
            }
            if (par > strokes)
            {
                Console.WriteLine("score is below par");
            }


        }
    }
}