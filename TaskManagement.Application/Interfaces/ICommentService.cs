using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface ICommentService
    {
        Task<IEnumerable<Comments>> GetCommentsByTaskIdAsync(int taskId);
        Task<Comments> CreateCommentAsync(Comments comments);
        Task DeleteCommentAsync(int id);
    }
}
