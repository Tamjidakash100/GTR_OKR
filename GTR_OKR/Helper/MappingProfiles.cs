using AutoMapper;
using GTR_OKR.DTO;
using GTR_OKR.Models;

namespace GTR_OKR.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<DepartmentDTO, Department>();
            CreateMap<CompanyDTO, Company > ();
            CreateMap<UserDTO, User > ();
            CreateMap<TemplateDTO, Template> ();
            CreateMap<TasksDTO, Tasks> ();
        }
    }
}
