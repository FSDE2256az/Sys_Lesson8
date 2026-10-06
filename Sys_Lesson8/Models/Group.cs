using Sys_Lesson8.Models.Base;
using System;
using System.Collections.Generic;

namespace Sys_Lesson8.Models;

public partial class Group : IEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdFaculty { get; set; }

    public virtual Faculty IdFacultyNavigation { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
