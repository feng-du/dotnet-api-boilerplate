using AutoMapper;
using MyProject.Entities;
using MyProject.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal static class DtoMappings
    {
        public static void Map(IMapperConfigurationExpression mapper)
        {
            //I specified mapping for AssignedPersonId since NHibernate does not fill Task.AssignedPersonId
            //If you will just use EF, then you can remove ForMember definition.
            mapper.CreateMap<Person, PersonDto>();
        }
    }
}
