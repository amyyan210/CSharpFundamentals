using System;
using Xunit;

namespace Grades.Tests
{   
    public class GradeBookTests
    {
        [Fact]
        public void ComputesHighestGrade() 
        {
            Gradebook gradebook = new Gradebook();
            gradebook.AddGrade(10);
            gradebook.AddGrade(90);

            GradeStatistics result = gradebook.ComputeStatistics();
            Assert.Equal(90, result.HighestGrade);
        }

        [Fact]
        public void ComputesLowestGrade()
        {
            Gradebook gradebook = new Gradebook();
            gradebook.AddGrade(10);
            gradebook.AddGrade(90);

            GradeStatistics result = gradebook.ComputeStatistics();
            Assert.Equal(10, result.LowestGrade);
        }

        [Fact]
        public void ComputesAverageGrade()
        {
            Gradebook gradebook = new Gradebook();
            gradebook.AddGrade(91);
            gradebook.AddGrade(89.5f);
            gradebook.AddGrade(75);

            GradeStatistics result = gradebook.ComputeStatistics();
            //Difficult to make assertions about floating point number calculations
            Assert.Equal(85.1666666667f, result.AverageGrade);
        }
    }
}
