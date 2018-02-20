using System;

namespace Practice
{
    class Loops
    {
        static void Main(string[] args)
        {
            int num = 1;

            while(num <= 15)

            {
                if (num == 13)
                {
                    num = num + 1;
                    continue;
                }
                Console.WriteLine(num);
                num = num + 1;
            }
        }
    }
}
