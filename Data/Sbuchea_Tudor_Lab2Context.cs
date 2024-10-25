using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sbuchea_Tudor_Lab2.Models;

namespace Sbuchea_Tudor_Lab2.Data
{
    public class Sbuchea_Tudor_Lab2Context : DbContext
    {
        public Sbuchea_Tudor_Lab2Context (DbContextOptions<Sbuchea_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sbuchea_Tudor_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sbuchea_Tudor_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Sbuchea_Tudor_Lab2.Models.Authors> Authors { get; set; } = default!;
    }
}
