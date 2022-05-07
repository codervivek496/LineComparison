using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComp
{
    public class LineComparison
    {
        double lengthLine1;
        double lengthLine2;
        public void calculatingLineLength()
        {
            Console.Write("Enter the point X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point X2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            lengthLine1 = Math.Sqrt(length1);
            Console.WriteLine("length of line is {0}", lengthLine1);

            //********Calculating Another line length****************

            Console.Write("Enter the point X3: ");
            int X3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point X4 ");
            int X4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y3 ");
            int Y3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the point Y4 ");
            int Y4 = Convert.ToInt32(Console.ReadLine());
            double length2 = Math.Pow(X4-X3, 2) + Math.Pow(Y4-Y3, 2);
            lengthLine2 = Math.Sqrt(length2);
            Console.WriteLine("length of line is {0}", lengthLine2);

        }

        //******* Line is Equal OR NOt *******
        public void equalityOfTwoLines()
        {
            if (lengthLine1 == lengthLine2)
            {
                Console.WriteLine("Lenght of both lines are equal");
            }
            else
            {
                Console.WriteLine("Length of both lines are not equal");
            }      
        }
        
        //***First Line is equal or Greater Or LesserI***

        public void comparison()
        {
            if (lengthLine1 == lengthLine2)
            {
                Console.WriteLine("Both the length os line is equal");
            }
            else if (lengthLine1 > lengthLine2)
            {
                Console.WriteLine("The length of First line is greater that second line");
            }
            else
            {
                Console.WriteLine("The lenght of second line is greater than first line");
            }
        }
    }
}
