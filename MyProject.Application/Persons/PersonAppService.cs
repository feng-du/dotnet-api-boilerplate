﻿using Abp.Application.Services;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Persons.Dtos;
using AutoMapper;

namespace MyProject.Persons
{
    public class PersonAppService: MyProjectAppServiceBase, IPersonAppService
    {
        private readonly IPersonRepository _personRepository;

        public PersonAppService(IPersonRepository personRepositoryy)
        {
            _personRepository = personRepositoryy;
        }

        public GetPersonsOutput GetPersons()
        {
            var persons = _personRepository.GetAllList();

            return new GetPersonsOutput
            {
                Persons = Mapper.Map<List<PersonDto>>(persons)
            };
        }
    }
}
