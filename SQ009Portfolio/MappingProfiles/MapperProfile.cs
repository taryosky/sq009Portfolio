using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;

using SQ009Portfolio.Data.Dtos;
using SQ009Portfolio.Data.Models;

namespace SQ009Portfolio.MappingProfiles
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {

            CreateMap<AppUser, UserToReturnDto>().ReverseMap();
            CreateMap<Skill, SkillToReturnDto>().ReverseMap();
            CreateMap<WorkHistory, WorkHistoryToReturnDto>().ReverseMap();
            CreateMap<EducationHistory, EducationHistoryToReturnDto>().ReverseMap();
            CreateMap<Project, ProjectToReturnDto>().ReverseMap();
        }
    }
}
