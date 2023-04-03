using ChallengeApp;
using System;
using System.Diagnostics;

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
        public Statistics GetStatisticsWithForEach()
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
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistic = new Statistics();

            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistic.Max = Math.Max(statistic.Max, this.grades[index]);
                statistic.Min = Math.Min(statistic.Min, this.grades[index]);
                statistic.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);

            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistic = new Statistics();

            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistic.Max = Math.Max(statistic.Max, this.grades[index]);
                statistic.Min = Math.Min(statistic.Min, this.grades[index]);
                statistic.Average += this.grades[index];
                index++;
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistic = new Statistics();

            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistic.Max = Math.Max(statistic.Max, this.grades[i]);
                statistic.Min = Math.Min(statistic.Min, this.grades[i]);
                statistic.Average += this.grades[i];
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
    }
}