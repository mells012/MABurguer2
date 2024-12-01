using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MABurger2.Models;

    public class MABurguer2Context : DbContext
    {
        public MABurguer2Context (DbContextOptions<MABurguer2Context> options)
            : base(options)
        {
        }

        public DbSet<MABurger2.Models.Burger> Burger { get; set; } = default!;

public DbSet<MABurger2.Models.Promo> Promo { get; set; } = default!;
    }
