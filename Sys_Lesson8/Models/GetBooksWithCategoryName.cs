namespace Sys_Lesson8.Models;

public partial class GetBooksWithCategoryName 
{
    public string Name { get; set; } = null!;

    public int Pages { get; set; }

    public int Quantity { get; set; }

    public int YearPress { get; set; }

    public string CategoryName { get; set; } = null!;
}
