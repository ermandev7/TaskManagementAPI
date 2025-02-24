using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Dto;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Categories, DtoCategories>().ReverseMap();
          
            CreateMap<Categories, DtoCategoriesTask>()
                 .ForMember(dest => dest.Tasks, opt => opt.MapFrom(src => src.Tasks.Select(detalle => new DtoTasks
                 {
                     TaskId = detalle.TaskId,
                     Title = detalle.Title,
                     Description = detalle.Description
                 })))
                 .ReverseMap();
        }
    }
}
