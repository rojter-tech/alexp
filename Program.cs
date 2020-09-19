using System; // C# grej som forenklar kodskrivningen, inget som ar absolut nodvandigt

namespace alexp // C# grej som maste finnas, har med projektets namn att gora
{ // "Curly braces", "Klammerparenteser" "Masvingar", "Curly brackets" markerar ett sa kallad "kodblock". 
  //Finns pa manga olika stallen. De kommer alltid i par, dvs {..}, oppning och stangning.
    class Program // C# grej som maste finnas, detta namn ska heta exakt som filen "Program.cs" men utan de tre sista tecknen ".cs"
    {
        static void Main(string[] args) // C# grej som maste finnas, har med att göra att programmet ska kunna koras fran konsollen
        {
            bool good = false;
            int a; int b; int c; int d; // Deklarera dessa innan for loopen (C# kraver det)

            for (int i = 0; i <= 500; i++) // Har strukturen -> | for (heltalsvariabel, maxvarde, att den ska oka med 1 efter varje steg)
            {
                // n % k beraknar resten nar n delas pa k (en sa kallad modulus operation)
                a = i % 2;
                b = i % 3;
                c = i % 5;
                d = i % 7;
                if (a == 1 & b == 1 & c == 1 & d == 1) // Kollar 4 olika villkor på samma gång
                {
                    // Allt har inne kors bara om villkoret ovan ar uppfyllt
                    good=true;
                    Console.WriteLine(i.ToString() + " is good!"); // Att printa ut i konsollen är lattare an att hantera varden separat
                }
                // Allt har ute kors varje gang loopen upprepas
            }
            // Nu har for loopen korts exakt 501 ganger
            // i=0, i=1, ... , i=500

            if (good) // Kollar om good == true
            {
                Console.WriteLine("Yay!");
            }
            else // I annat fall ... det vill saga good == false
            {
                Console.WriteLine("Buhu ...");
            }
        }
    } // Den näst sista klammerparentesen, matchar den andra parentesen, den på rad 7
} // Den sista klammerparentesen, matchar med den absolut första, den pa rad 4


