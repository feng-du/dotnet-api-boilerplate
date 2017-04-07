using Abp.Application.Services;
using MyProject.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Persons
{
    public interface IPersonAppService: IApplicationService
    {
        GetPersonsOutput GetPersons();
        int CreatePerson(CreatePersonInput dto);
    }
}
