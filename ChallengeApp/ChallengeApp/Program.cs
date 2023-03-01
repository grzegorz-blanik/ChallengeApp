﻿using ConsoleApp1;

var employee = new Employee("Grzegorz", "Błanik");
employee.AddGrade(1);
employee.AddGrade(3);
employee.AddGrade(7);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");