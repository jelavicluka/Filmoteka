using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Filmoteka.Models;
using Filmoteka.Dtos;

namespace Filmoteka.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Movies, MovieDto>();
            Mapper.CreateMap<MovieDto, Movies>();

            Mapper.CreateMap<MembershipType, membershipTypeDto>();
            Mapper.CreateMap<membershipTypeDto, MembershipType>();

            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<GenreDto, Genre>();
        }
    }
}