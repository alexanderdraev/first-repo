using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsMoreExercises
{
    class Program
    {
        static void Main(string[] args) // X
        {
            
            int xSize = int.Parse(Console.ReadLine());

            int spacesAfterX = xSize - 2;
            for (int i = 0; i < xSize /2; i++, spacesAfterX -= 2)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', i), new string(' ', spacesAfterX));
            }
            Console.WriteLine("{0}x", new string(' ', xSize / 2));
            spacesAfterX = 1;
            for (int i = xSize / 2; i > 0; i--, spacesAfterX += 2)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', i - 1), new string(' ', spacesAfterX));
            }   
        }
    }
}
