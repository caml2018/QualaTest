using AutoMapper;
using Quala.domain.Entities.Dtos;
using Quala.domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quala.api
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Sucursal, SucursalDto>().ReverseMap();

            CreateMap<Monedum,MonedaDto>().ReverseMap();
        }
    }
}
