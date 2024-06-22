using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AmigoPeludo.Models;

namespace AmigoPeludo.Data
{
    public class AmigoPeludoContext : DbContext
    {
        public AmigoPeludoContext (DbContextOptions<AmigoPeludoContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; } = default!;
        public DbSet<AmigoPeludo.Models.Pet> Pet { get; set; } = default!;
    }
}
