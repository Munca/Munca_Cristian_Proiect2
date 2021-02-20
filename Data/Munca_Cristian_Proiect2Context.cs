using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Munca_Cristian_Proiect2.Models;

namespace Munca_Cristian_Proiect2.Data
{
    public class Munca_Cristian_Proiect2Context : DbContext
    {
        public Munca_Cristian_Proiect2Context (DbContextOptions<Munca_Cristian_Proiect2Context> options)
            : base(options)
        {
        }

        public DbSet<Munca_Cristian_Proiect2.Models.Book> Book { get; set; }

        public DbSet<Munca_Cristian_Proiect2.Models.Publisher> Publisher { get; set; }
    }
}
