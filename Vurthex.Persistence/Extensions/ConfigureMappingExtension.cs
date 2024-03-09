using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Application.DTOs;
using Vurthex.Domain.Models;

namespace Vurthex.Persistence.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });
            IMapper mapper = mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
            return service;

        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<Accordion, AccordionDTO>();
            CreateMap<AccordionDTO, Accordion>();

            CreateMap<Blog, BlogDTO>();
            CreateMap<BlogDTO, BlogDTO>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, CategoryDTO>();

            CreateMap<Contact, ContactDTO>();
            CreateMap<ContactDTO, ContactDTO>();

            CreateMap<Project, ProjectDTO>();
            CreateMap<ProjectDTO, ProjectDTO>();

            CreateMap<Role, RoleDTO>();
            CreateMap<RoleDTO, RoleDTO>();

            CreateMap<Service, ServiceDTO>();
            CreateMap<ServiceDTO, ServiceDTO>();

            CreateMap<SocialMedia, SocialMediaDTO>();
            CreateMap<SocialMediaDTO, SocialMedia>();

            CreateMap<Technology, TechnologyDTO>();
            CreateMap<TechnologyDTO, Technology>();

            CreateMap<User, UserDTO>()
                .ForMember(c => c.FullName, y => y.MapFrom(y => y.FirstName + " " + y.LastName));
            CreateMap<UserDTO, User>();

            CreateMap<UserMedia, UserMediaDTO>();
            CreateMap<UserMediaDTO, UserMedia>();
        }
    }
}
