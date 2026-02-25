using EFCode.Model;
using EFCode;
using Microsoft.EntityFrameworkCore;


using (var context = new AppDbContext())
{
    context.Database.Migrate();
}

using (var context = new AppDbContext())
{
    // INSERT
    context.student.Add(new Student { Name = "John", Age = 22 });
    context.SaveChanges();

    // SELECT
    var students = context.student.ToList();

    // UPDATE
    var student = context.student.First();
    student.Age = 25;
    context.SaveChanges();

    // DELETE
    context.student.Remove(student);
    context.SaveChanges();
}