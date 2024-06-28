using AmigoPeludo.Models;
using Microsoft.EntityFrameworkCore;

namespace AmigoPeludo.Data
{
    public class AmigoPeludoContext : DbContext
    {
        public AmigoPeludoContext (DbContextOptions<AmigoPeludoContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; } = default!;
        public DbSet<Pet> Pet { get; set; } = default!;
    }
}
