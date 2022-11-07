using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DangThiAnhBTH2.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<DangThiAnhBTH2.Models.Employee> Employee { get; set; } = default!;

        public DbSet<DangThiAnhBTH2.Models.Student>? Student { get; set; }

        public DbSet<DangThiAnhBTH2.Models.Person>? Person { get; set; }

        public DbSet<DangThiAnhBTH2.Models.Customer>? Customer { get; set; }
    }
