using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationsNigeria.Domain.Models.DatabaseModels
{
  public class User : IdentityUser
  {

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FirstName { get; set; }
    }
}
