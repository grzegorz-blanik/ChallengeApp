using ConsoleApp1;
Employee employee1 = new Employee("Jan", "Kowalski", "21");
Employee employee2 = new Employee("Marek", "Nowak", "30");
Employee employee3 = new Employee("Anna", "Wójcik", "25");

employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(6);
employee1.AddScore(10);

employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(8);
employee2.AddScore(10);
employee2.AddScore(2);

employee3.AddScore(7);
employee3.AddScore(3);
employee3.AddScore(6);
employee3.AddScore(9);
employee3.RemoveScore(5);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.Write("Proacownik z najlepszym wynikiem, to: ");
Console.Write(employeeWithMaxResult.Name + " ");
Console.Write(employeeWithMaxResult.Surname + ", ");
Console.Write(employeeWithMaxResult.Age + " lat, ");
Console.Write($"Wynik: {employeeWithMaxResult.Result} pkt.");
Console.WriteLine();