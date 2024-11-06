using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab55.Models;

namespace lab55.Data
{
    public class lab55Context : DbContext
    {
        public lab55Context (DbContextOptions<lab55Context> options)
            : base(options)
        {
        }

        public DbSet<lab55.Models.book> book { get; set; } = default!;
        public DbSet<lab55.usersaccounts> usersaccounts { get; set; } = default!;
        public DbSet<lab55.Models.orders> orders { get; set; } = default!;
        public DbSet<lab55.Models.bookorder> bookorder { get; set; } = default!;
        public DbSet<lab55.Models.orderline> orderline { get; set; } = default!;
    }
}
