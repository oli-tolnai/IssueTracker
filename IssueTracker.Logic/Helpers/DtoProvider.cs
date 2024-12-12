using AutoMapper;
using IssueTracker.Entities;
using IssueTracker.Entities.Dtos.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Logic.Helpers
{
    public class DtoProvider
    {
        public Mapper Mapper { get; }

        public DtoProvider()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Project, ProjectShortViewDto>();
                cfg.CreateMap<Project, ProjectViewDto>();
                cfg.CreateMap<ProjectCreateUpdateDto, Project>();
            });

            Mapper = new Mapper(config);
        }
    }
}
