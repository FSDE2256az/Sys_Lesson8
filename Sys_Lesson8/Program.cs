using Sys_Lesson8.DbContexts;
using Sys_Lesson8.Repositories.Concretes;

class Program
{
    static async Task Main(string[] args)
    {
        var dbContext = new LibraryContext();

        StudentRepository studentRepo = new StudentRepository(dbContext);

        CategoryRepository categoryRepository = new CategoryRepository(dbContext);

        var allStudent = await studentRepo.GetAllStudentWithGroupNameAsync();

        //  var allStudent = await studentRepo.GetAllAsync();
        // 
        foreach (var student in allStudent)
        {
            Console.WriteLine($"{student.Name} {student.Surname} => {student.GroupName}");
        }


    }
}