using LocationsNigeria.Domain.Models.DatabaseModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationsNigeria.Infrastructure.Data
{
  public class LocationNigeriaDBContext : IdentityDbContext<User>
  {
    public LocationNigeriaDBContext(DbContextOptions<LocationNigeriaDBContext> options)
        : base(options)
    {
    }
  }
  
}
