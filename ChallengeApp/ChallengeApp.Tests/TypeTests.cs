using ConsoleApp1;
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenGetEmployeeThenReturnDifferentObjects()
        {
            // arrange
            var employee1 = GetEmployee("Grzegorz");
            var employee2 = GetEmployee("Jan");

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void WhenSelectedIntThenReturnTheSameNumber()
        {
            // arrange
            int number1 = 1;
            int number2 = 1;

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void WhenSelectedFloatThenReturnTheSameNumber()
        {
            // arrange
            float number3 = 2.5264f;
            float number4 = 2.5264f;

            // act

            // assert
            Assert.AreEqual(number3, number4);
        }

        [Test]
        public void WhenSelectedStringThenReturnDifferentObjects()
        {
            // arrange
            string employee3 = "Elektryk";
            string employee4 = "Informatyk";

            // act

            // assert
            Assert.AreNotEqual(employee3, employee4);
        }
        private Employee GetEmployee(string login)
        {
            return new Employee(login);
        }
    }
}