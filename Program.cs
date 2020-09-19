using System;

namespace alexp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool good = false;
            int a; int b; int c; int d; // Deklarera dessa innan for loopen

            for (int i = 0; i <= 500; i++)
            {
                // n % k beraknar resten nar n delas pa k
                a = i % 2;
                b = i % 3;
                c = i % 5;
                d = i % 7;
                if (a == 1 & b == 1 & c == 1 & d == 1)
                {
                    good=true;
                    Console.WriteLine(i.ToString() + " is good!");
                }
            }
            // Nu har den korts 501 ganger

            if (good) // Kollar om good = true
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Buhu ...");
            }
        }
    }
}

