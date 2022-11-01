using System;

namespace UC1_CalculateLineLength
{
    class LengthofLine
    {
        public LengthofLine()
        {
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            Console.WriteLine("------------------------------------------------");
        }
        //Method For Calculate Line Length
        public static double Distance(double x1, double x2, double y1, double y2)
        {
           
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }
        // Input Value and Print The Output Result
        static void Main(string[] args)
        {
            LengthofLine lengthofLine = new LengthofLine();

            Console.WriteLine("Please enter x1 coordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y1 coordinates: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter x2  coordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y2 coordinates: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double finalResult = Distance(x1, y1, x2, y2);
            Console.WriteLine("Distance between two points : " + finalResult);

        }
    }

}
