using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DDAC3.Models;

namespace DDAC3.Models
{
    public class DDAC3Context : DbContext
    {
        public DDAC3Context (DbContextOptions<DDAC3Context> options)
            : base(options)
        {
        }

        public DbSet<DDAC3.Models.Book> Book { get; set; }

        public DbSet<DDAC3.Models.Order> Order { get; set; }
    }
}
