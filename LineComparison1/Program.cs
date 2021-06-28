using System;

namespace LineComparison1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] StoringLength = new double[5];
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


                double length1 = Program.FindingLength(x1, x2, y1, y2);
                Console.WriteLine("Line Length :" + length1);
                StoringLength[i] = length1;
            }
            Program obj = new Program();
            obj.EqualityMethod(StoringLength[1].ToString(), StoringLength[2].ToString());
            obj.comparingLines(StoringLength[1].ToString(), StoringLength[2].ToString());

        }

        public void EqualityMethod(string len1, string len2)
        {
            if (len1.Equals(len2))
            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
        public static double FindingLength(int x1, int x2, int y1, int y2)
        {
            //Calculating a line length
            double LineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double len = Math.Round(LineLength, 2);
            return len;

        }
        public  void comparingLines(string len1,string len2)
        {
            if(len1.CompareTo(len2)>0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("both lines are equal");
            }
        }
    }
}



