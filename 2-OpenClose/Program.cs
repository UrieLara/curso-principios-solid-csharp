using OpenClose;

ShowSalary(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180), 
    new EmployeeContractor("Manuel Lopera", 180)
});

void ShowSalary(List<Employee> employees)
{
    foreach (var employee in employees)
    {
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago mensual: {employee.CalculateSalaryMonthly():C1}");
        Console.WriteLine($"Pago anual: {employee.CalculateSalaryYearly():C1}");
    }
}
