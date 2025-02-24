using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Interfaces
{
    public interface  ITaskService
    {
       
            Task<IEnumerable<Tasks>> GetAllTasksAsync();
            Task<Tasks> GetTaskByIdAsync(int id);
            Task<Tasks> CreateTaskAsync(Tasks tasks);
            Task UpdateTaskAsync(Tasks tasks);
            Task DeleteTaskAsync(int id);
        
    }
}
