using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImoveisMVC.Models
{
    public class SolutionContext : DbContext
    {
        public SolutionContext(DbContextOptions<SolutionContext> options) : base(options)
        {
        }

        public DbSet<ImovelModel> ImovelModel { get; set; }
    }
}
