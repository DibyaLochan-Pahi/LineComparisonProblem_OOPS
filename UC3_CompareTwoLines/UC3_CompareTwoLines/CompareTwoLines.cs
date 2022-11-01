using System;

namespace UC3_CompareTwoLines
{
    class CompareTwoLines
    {
        // Print Welcome Message
        public CompareTwoLines()
        {
            Console.WriteLine("WELCOME TO LINE COMPARISON COMPUTATION PROGRAM");
            Console.WriteLine("------------------------------------------------");
        }
        // Method For Calculate Line Length And Return Length Value
        public static double Distance(double x1, double x2, double y1, double y2)
        {
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }

        static void Main(string[] args)
        {
            CompareTwoLines compareTwoLines = new CompareTwoLines();

            Console.WriteLine("Please enter x1 coordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y1 coordinates: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter x2  coordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y2 coordinates: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double finalResult1 = Distance(x1, y1, x2, y2);

            Console.WriteLine("Please enter a1  coordinates: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter  b1 coordinates: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a2 coordinates: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter b2 coordinates: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            double finalResult2 = Distance(a1, b1, a2, b2);
            CheckFinalResult(finalResult1, finalResult2);

        }
        
        // Using C# CompareTo Method to Compare Two Line Lengths
        // Print the Output Result
        private static void CheckFinalResult(double finalResult1, double finalResult2)
        {
            double status = finalResult1.CompareTo(finalResult2);
            if (status > 0)
            {
                Console.WriteLine("Line-1 [{0}]unit is Greater than Line-2 [{1}]unit", finalResult1, finalResult2);
            }
            else if (status < 0)
            {
                Console.WriteLine("Line-1 [{0}]unit is less than Line-2 [{1}]unit", finalResult1, finalResult2);
            }
            else
            {
                Console.WriteLine("Line-1 is equal to Line-2", finalResult1, finalResult2);
            }
            Console.WriteLine("Length of first Line = " + finalResult1);
            Console.WriteLine("Length of second Line = " + finalResult2);
        }
    }
}
