using Abp.EntityFramework;
using MyProject.Entities;
using MyProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.EntityFramework.Repositories
{
    public class PersonRepository:MyProjectRepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDbContextProvider<MyProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
           
        }
    }
}
