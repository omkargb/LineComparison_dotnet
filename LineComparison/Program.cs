using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Line Comparison Computation Program \n");
            CalcLength cw = new CalcLength(2, 1, 6, 4);
            cw.ShowResult();
        }
    }
}
