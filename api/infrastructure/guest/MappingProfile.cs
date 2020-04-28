using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;

using model;

namespace infrastructure.guest
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Guest, GuestDto>();
        }
    }
}
