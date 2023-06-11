using AutoMapper;
using DTO.DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO.Mapconn
{
    public class MapProile : Profile
    {

        public Mapper GetMapper()
        {

            var cng = new MapperConfiguration
                (C =>
                {
                    C.CreateMap<users, userDTO>();
                    C.CreateMap<userDTO, users>();
                });
            var Mapper = new Mapper(cng);
            return Mapper;

        }

    }
}