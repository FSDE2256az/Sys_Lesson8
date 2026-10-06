using Sys_Lesson8.Models;
using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Generics;

namespace Sys_Lesson8.Repositories.Concretes;

public class BookRepository : GenericRepository<Book>, IBookRepository
{
    public BookRepository(DbContext context) : base(context)
    {
    }
}
