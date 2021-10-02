using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VeterinariaSJ.Models;

namespace VeterinariaSJ.Data
{
    public class VeterinariaSJContext : DbContext
    {
        public VeterinariaSJContext (DbContextOptions<VeterinariaSJContext> options)
            : base(options)
        {
        }

        public DbSet<VeterinariaSJ.Models.Veterinaria> Veterinaria { get; set; }
    }
}
