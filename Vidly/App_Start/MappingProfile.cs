using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            /*
            Property ‘Id’ is part of object’s key information and cannot be modified.
            This exception happens at the following line: Mapper.Map(customerDto, customer); 
            The exception is thrown when AutoMapper attempts to set the Id of customer: customer.Id = customerDto.Id; 
            Id is the key property for the Movie class, and a key property should not be changed.
            That’s why we get this exception.
            To resolve this, you need to tell AutoMapper to ignore Id during mapping of a CustomerDto to Customer.
            */


            // Domain to DTO
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            //DTO to Domain
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}