using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RentalShowcase.DTOs;
using RentalShowcase.Models;


namespace RentalShowcase.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //Domain to Dto
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();
            Mapper.CreateMap<Genre, GenreDTO>();



            Mapper.CreateMap<CustomerDTO, Customer>().ForMember(c => c.id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDTO, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}