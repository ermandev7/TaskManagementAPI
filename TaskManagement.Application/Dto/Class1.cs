using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Dto
{
    public  class DtoTasks
    {
        public int TaskId { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

    }
}
