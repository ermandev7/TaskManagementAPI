using System;
using System.Collections.Generic;

namespace TaskManagement.Domain.Entities;

public partial class Tasks
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? IsCompleted { get; set; }

    public int? CategoryId { get; set; }

    public int? UserId { get; set; }

    public virtual Categories? Category { get; set; }

    public virtual ICollection<Comments> Comments { get; set; } = new List<Comments>();

    public virtual Users? User { get; set; }
}
