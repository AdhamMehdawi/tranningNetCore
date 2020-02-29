using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication38.DomainModels.StudentModels;

namespace WebApplication38.Context
{
    public class TCenterContext : DbContext
    {
        public TCenterContext
            (DbContextOptions<TCenterContext> options)
            :base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
