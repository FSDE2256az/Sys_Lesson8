using Sys_Lesson8.Dtos.Student;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;

namespace Sys_Lesson8.Repositories.Abstracts;

public interface IStudentRepository : IGenericRepository<Student>
{
    Task<List<StudentWithGroupName>> GetAllStudentWithGroupNameAsync();
}
