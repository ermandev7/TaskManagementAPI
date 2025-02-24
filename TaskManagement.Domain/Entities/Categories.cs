using System;
using System.Collections.Generic;

namespace TaskManagement.Domain.Entities;

public partial class Categories
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
}
