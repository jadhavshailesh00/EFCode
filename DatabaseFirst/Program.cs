using (var context = new CompanyDBContext())
{
    var employees = context.employee
        .Where(e => e.Salary > 50000)
        .ToList();

    foreach (var emp in employees)
    {
        Console.WriteLine(emp.Name);
    }
}