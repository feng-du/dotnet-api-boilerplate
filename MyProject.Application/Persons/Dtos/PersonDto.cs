using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Persons.Dtos
{
    public class PersonDto: EntityDto
    {
        public string Value { get; set; }
    }
}
