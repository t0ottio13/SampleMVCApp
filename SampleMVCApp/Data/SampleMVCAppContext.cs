using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleMVCApp.Models;

    public class SampleMVCAppContext : DbContext
    {
        public SampleMVCAppContext (DbContextOptions<SampleMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<SampleMVCApp.Models.Todo> Todo { get; set; }
        public DbSet<SampleMVCApp.Models.Person> Person { get; set; }
    }
