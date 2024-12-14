using AutoMapper;
using IssueTracker.Entities;
using IssueTracker.Entities.Dtos.Issue;
using IssueTracker.Entities.Dtos.Project;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Logic.Helpers
{
    public class DtoProvider
    {
        UserManager<IdentityUser> userManager;

        public Mapper Mapper { get; }

        public DtoProvider(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Project, ProjectShortViewDto>()
                .AfterMap((src, dest)=>
                {
                    dest.NumberOfNewIssues = src.Issues.Count(i => i.Status == "New");
                });
                cfg.CreateMap<Project, ProjectViewDto>();
                cfg.CreateMap<ProjectCreateUpdateDto, Project>();
                cfg.CreateMap<IssueCreateDto, Issue>();
                cfg.CreateMap<Issue, IssueViewDto>()
                .AfterMap((src, dest) =>
                {
                    dest.UserFullName = userManager.Users.First(u => u.Id == src.UserId).UserName!;
                });
                cfg.CreateMap<IssueStatusUpdateDto, Issue>();
            });

            Mapper = new Mapper(config);
        }
    }
}
