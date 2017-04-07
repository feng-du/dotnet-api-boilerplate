using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Persons.Dtos
{
    public class CreatePersonInput
    {
        [Required]
        public string Value { get; set; }
    }
}
