using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {


            Gradebook book = new Gradebook();
            book.AddGrade(31);
            book.AddGrade(98.7f);
            book.AddGrade(82.5f);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average grade: " + stats.AverageGrade);
            Console.WriteLine("Highest grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest grade: " + stats.LowestGrade);
        }
    }
}
