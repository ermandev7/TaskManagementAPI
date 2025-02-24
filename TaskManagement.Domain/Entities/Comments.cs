using System;
using System.Collections.Generic;

namespace TaskManagement.Domain.Entities;

public partial class Comments
{
    public int CommentId { get; set; }

    public int? TaskId { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Tasks? Task { get; set; }
}
