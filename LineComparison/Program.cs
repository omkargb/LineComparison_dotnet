using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Comparison Computation Program \n");
            CalcLength cal1 = new CalcLength();
            CalcLength cal2 = new CalcLength();
            double length1 = cal1.CalcResult(3, 2, 9, 2);
            double length2 = cal2.CalcResult(12, 2, 4, 8);

            CalcLength cal3 = new CalcLength();
            cal3.displayResult(length1, length2);
        }
    }
}
