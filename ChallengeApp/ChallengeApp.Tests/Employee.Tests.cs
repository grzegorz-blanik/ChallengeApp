using ConsoleApp1;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetSomePoints_ThenReturnMaxValue()
        {
            // arrange
            var employee4 = new Employee("Jan", "Kowalski");
            employee4.AddGrade(1);
            employee4.AddGrade(2);
            // act
            var statistics = employee4.GetStatistics();
            // assert
            Assert.AreEqual(2, statistics.Max);
        }
        [Test]
        public void WhenEmployeeGetSomePoints_ThenReturnMinValue()
        {
            // arrange
            var employee5 = new Employee("Kamil", "Kozak");
            employee5.AddGrade(5);
            employee5.AddGrade(2);
            employee5.AddGrade(4);
            // act
            var statistics = employee5.GetStatistics();
            // assert
            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void WhenEmployeeGetSomePoints_ThenReturnAverageValue()
        {
            // arrange
            var employee6 = new Employee("Jan", "Kowalski");
            employee6.AddGrade(6);
            employee6.AddGrade(4);
            employee6.AddGrade(7);
            // act
            var statistics = employee6.GetStatistics();
            // assert
            Assert.AreEqual(Math.Round(5.67, 2), Math.Round(statistics.Average, 2));
        }
    }
}