using System;

namespace LineComparison1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison problem");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter value for  coordinate x1");
                int x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for   coordinate y1");
                int y1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter value for  first coordinate x2");
                int x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter value for  first coordinate y2");
                int y2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Line Length:" + Program.FindingLength(x1, y1, x2, y2));
            }
        }

        public static double FindingLength(int x1, int x2, int y1, int y2)
        {
            //Calculating a line length
            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }
    }
}
 

