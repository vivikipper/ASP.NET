using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Output_Student_200541042.Models;

namespace Output_Student_200541042.Data
{
    public class Output_Student_200541042Context : DbContext
    {
        public Output_Student_200541042Context (DbContextOptions<Output_Student_200541042Context> options)
            : base(options)
        {
        }

        public DbSet<Output_Student_200541042.Models.Car> Car { get; set; } = default!;
    }
}
