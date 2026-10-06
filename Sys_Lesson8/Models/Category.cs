using Sys_Lesson8.Models.Base;
using System;
using System.Collections.Generic;

namespace Sys_Lesson8.Models;

public partial class Category : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
