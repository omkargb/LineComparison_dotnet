using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class CalcLength
    {

        public double CalcResult(int x1, int y1, int x2, int y2)
        {
            int point1 = (x2 - x1);
            int point2 = (y2 - y1);
            Console.WriteLine(" Line points (x,y) are : ("+x1+" , " +y1+ ") , (" +x2+ " , " +y2+ ") ");
            double result = Math.Sqrt(Math.Pow(point1, 2) + Math.Pow(point2, 2));
            Console.WriteLine(" Length of line : " + result + " units\n");
            return result;
        }

        public void displayResult(double length1, double length2)
        {
            int eqCheck = (length1.CompareTo(length2));
            if (eqCheck.Equals(0))
            {
                Console.WriteLine(" Result : Both the lines are having same length or both lines are equal.");
            }
            else if (eqCheck.Equals(-1))
            {
                Console.WriteLine(" Result : Length of FirstLine Is lesser Than secondLine");
            }
            else
            {
                Console.WriteLine(" Result : Length of FirstLine Is Greater Than secondLine");
            }
        }
    }
}
