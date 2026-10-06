using Sys_Lesson8.Models;
using Sys_Lesson8.Generics;
using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Dtos.Student;

namespace Sys_Lesson8.Repositories.Concretes;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    public StudentRepository(DbContext context) : base(context)
    {
    }

    public async Task<List<StudentWithGroupName>> GetAllStudentWithGroupNameAsync()
    {
        var students = await _dbSet.ToListAsync();

        var result = students.Select(x => new StudentWithGroupName()
        {
            Name = x.FirstName,
            Surname = x.LastName,
            GroupName = x.IdGroupNavigation.Name
        }).ToList();

        return result;
    }
}
