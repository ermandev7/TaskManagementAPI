using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.Dto
{
    public class DtoCategories
    {
        [JsonPropertyName("cod_categoria")]
        public int CategoryId { get; set; }

        [JsonPropertyName("nombre")]
        public string Name { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }

    public class DtoCategoriesTask
    {
        [JsonPropertyName("cod_categoria")]
        public int CategoryId { get; set; }

        [JsonPropertyName("nombre")]
        public string Name { get; set; } = null!;


       
        public virtual ICollection<DtoTasks> Tasks { get; set; } = new List<DtoTasks>();
    }
}
