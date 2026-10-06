namespace Sys_Lesson8.Generics;

public interface IGenericRepository<T>
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T student);
    Task UpdateAsync(T student);
    Task DeleteAsync(int id);
}
