using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VentaAutomoviles.Models;

namespace VentaAutomoviles.Data
{
    public class VentaAutomovilesContext : DbContext
    {
        public VentaAutomovilesContext (DbContextOptions<VentaAutomovilesContext> options)
            : base(options)
        {
        }

        public DbSet<VentaAutomoviles.Models.Carro> Carro { get; set; }
    }
}
