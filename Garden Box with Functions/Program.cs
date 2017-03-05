using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Box_with_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int boxLength = GetDimension("What is the length of your garden box?");
            int boxWidth = GetDimension("What is the width of your box?");


            Console.WriteLine("The perimeter is: " + ((2 * boxLength) + (2 * boxWidth)));
            Console.WriteLine("The area is: " + (boxWidth * boxLength));
            Console.WriteLine("You can plant " + (9.0 / 16 * (boxWidth * boxLength)) + " beets.");
            Console.WriteLine("You can plant " + (16.0 / 16 * (boxWidth * boxLength)) + " carrots.");
            Console.WriteLine("You can plant " + (3.0 / 16 * (boxWidth * boxLength)) + " corn.");
            Console.ReadLine();
        }
        // The GetDimension function can be used in place of using the GetBoxLength and GetBoxWidth functions together (more efficient - DRY)

        //static int GetBoxLength()
        //{
        //    Console.WriteLine("What is the length of your garden box?");
        //    string length = Console.ReadLine();
        //    int boxLength;
        //    boxLength = Convert.ToInt32(length);
        //    return boxLength;
        //} 
        //static int GetBoxWidth()
        //{
        //    Console.WriteLine("What is the width of your garden box?");
        //    string width = Console.ReadLine();
        //    int boxWidth;
        //    boxWidth = Convert.ToInt32(width);
        //    return boxWidth;
        //}

        static int GetDimension(string prompt)
        {
            Console.WriteLine(prompt);
            string dimension = Console.ReadLine();
            int boxDimension;
            boxDimension = Convert.ToInt32(dimension);
            return boxDimension;
        }
    }
}
