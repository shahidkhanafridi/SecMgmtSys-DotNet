global using SMSApi.Models;
using SMSApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.BLL.Helpers
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SMSApi.Models.UserDto, User>()
                .ForMember(m => m.UserName, opt => opt.MapFrom(f => f.Email)).ReverseMap();
        }
    }
}
