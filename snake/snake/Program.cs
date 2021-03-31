using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.SetBufferSize(100, 35);
            HorizontLine upLine = new HorizontLine(0, 78, 0, '+');
            HorizontLine downLine = new HorizontLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            // Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //HorizontLine line = new HorizontLine(5, 10, 8, '+');
            //line.Drow();


            //Console.ReadLine();//
        }
    }
}
