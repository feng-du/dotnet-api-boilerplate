using Abp.WebApi.Controllers;
using MyProject.Persons;
using MyProject.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class PersonController : AbpApiController
    {
        private IPersonAppService _service;

        public PersonController(IPersonAppService service)
        {
            _service = service;
        }

        // GET api/values
        public GetPersonsOutput Get()
        {
            Logger.Debug("test");
            return _service.GetPersons();
        }

        public object Post(CreatePersonInput input)
        {
            var result = _service.CreatePerson(input);

            return new { Id = result };
        }
    }

}
