using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Comparison Computation Program \n");
            CalcLength cal1 = new CalcLength(12, 2, 4, 8);
            CalcLength cal2 = new CalcLength(3, 2, 8, 2);
            double length1 = cal1.ShowResult();
            double length2 = cal2.ShowResult();

            int eqCheck = (length1.CompareTo(length2));
            if (eqCheck == 0)
            {
                Console.WriteLine(" Result : Both the lines are having same length or both lines are equal.");
            }
            else if (eqCheck == 1)
            {
                Console.WriteLine(" Result : Length of FirstLine Is Greater Than secondLine");
            }
            else
            {
                Console.WriteLine(" Result : Length of FirstLine Is lesser Than secondLine");
            }
        }
    }
}
