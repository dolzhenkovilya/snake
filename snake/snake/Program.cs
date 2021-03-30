using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine("Hello World!");
=======
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontLine line = new HorizontLine(5, 10, 8, '+');
            line.Drow();


>>>>>>> Stashed changes
            Console.ReadLine();
        }
    }
}
