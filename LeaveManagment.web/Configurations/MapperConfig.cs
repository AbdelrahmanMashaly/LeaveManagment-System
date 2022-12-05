using AutoMapper;
using LeaveManagment.web.Data.Migrations;
using LeaveManagment.web.Models;

namespace LeaveManagment.web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
