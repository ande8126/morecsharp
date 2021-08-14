using System;

namespace MoreCSharp
{
    class testingLoops
    {
        public static void Main()
        {
            //while loop
            int x = 1;
            while (x <= 4)
            {
                Console.Write("Hello World!");
                //increment
                x++;
            }
            //for loop
            for (int i=1; i<4; i++)
            {
                Console.Write("Hello Again World!");
            }
            //do-while loop
            int y = 21;
            do
            {
                //line will be printed regardless
                Console.Write("Hello one more time!");
                y++;
            }
            while (y < 20);
        }
    }
} 