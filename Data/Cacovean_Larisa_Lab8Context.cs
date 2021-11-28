using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cacovean_Larisa_Lab8.Models;

namespace Cacovean_Larisa_Lab8.Data
{
    public class Cacovean_Larisa_Lab8Context : DbContext
    {
        public Cacovean_Larisa_Lab8Context (DbContextOptions<Cacovean_Larisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cacovean_Larisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cacovean_Larisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cacovean_Larisa_Lab8.Models.Category> Category { get; set; }
    }
}
