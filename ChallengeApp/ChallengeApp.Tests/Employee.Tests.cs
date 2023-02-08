using ConsoleApp1;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeGetThreePoints_ThenReturnCorrectResult()
        {
            // arrange
            var employee4 = new Employee("Jan", "Kowalski", "26");
            employee4.AddScore(1);
            employee4.AddScore(2);
            // act
            var result = employee4.Result;
            // assert
            Assert.AreEqual(3, result);
        }
        [Test]
        public void WhenEmployeeCollectScoresEqualZero_ThenReturnZero()
        {
            // arrange
            var employee5 = new Employee("Kamil", "Kozak", "23");
            employee5.AddScore(5);
            employee5.AddScore(2);
            employee5.AddScore(4);
            employee5.RemoveScore(11);
            // act
            var result = employee5.Result;
            // assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void WhenEmployeeCollectScoresBelowZero_ThenReturnResultBelowZero()
        {
            // arrange
            var employee6 = new Employee("Jan", "Kowalski", "27");
            employee6.AddScore(3);
            employee6.AddScore(9);
            employee6.RemoveScore(15);
            // act
            var result = employee6.Result;
            // assert
            Assert.AreEqual(-3, result);
        }
    }
}