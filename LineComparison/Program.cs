using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Comparison Computation Program \n");
            CalcLength cal1 = new CalcLength(12, 2, 4, 8);
            CalcLength cal2 = new CalcLength(12, 2, 4, 8);
            double length1 = cal1.ShowResult();
            double length2 = cal2.ShowResult();

            if (length1 == length2)
            {
                Console.WriteLine( " Result :  Both the lines are having same length or both lines are equal."); 
            }
        }
    }
}
