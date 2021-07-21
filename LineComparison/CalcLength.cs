using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    public class CalcLength
    {

        public int x1, x2, y1, y2;
    public CalcLength(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }

    public void ShowResult()
    {

            int pt1 = (x2 - x1);
            int pt2 = (y2 - y1);
            Console.WriteLine(" Line points (x,y) are : ("+x1+" , " +y1+ ") , (" +x2+ " , " +y2+ ") ");
            double result = Math.Sqrt(Math.Pow(pt1, 2) + Math.Pow(pt2, 2));
        Console.WriteLine(" Length of line : " + result + " units\n");
    }

}



}
