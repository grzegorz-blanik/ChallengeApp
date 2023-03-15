using ChallengeApp;

namespace ConsoleApp1
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Grade must be between 0 to 100");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String must be a number");
            }
        }
        public void AddGrade(double grade)
        {
            float doubleAsFloat = (float)grade;
            this.AddGrade(doubleAsFloat);
        }
        public void AddGrade(long grade)
        {
            float longAsFloat = (float)grade;
            this.AddGrade(longAsFloat);
        }
        public void AddGrade(int grade)
        {
            float intAsFloat = (float)grade;
            this.AddGrade(intAsFloat);
        }
        public Statistics GetStatistics()
        {
            var statistic = new Statistics();

            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
    }
}