using Sys_Lesson8.Models.Base;
using System;
using System.Collections.Generic;

namespace Sys_Lesson8.Models;

public partial class Lib : IEntity
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<SCard> SCards { get; set; } = new List<SCard>();

    public virtual ICollection<TCard> TCards { get; set; } = new List<TCard>();
}
