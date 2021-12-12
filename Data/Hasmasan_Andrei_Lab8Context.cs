using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hasmasan_Andrei_Lab8.Models;

namespace Hasmasan_Andrei_Lab8.Data
{
    public class Hasmasan_Andrei_Lab8Context : DbContext
    {
        public Hasmasan_Andrei_Lab8Context (DbContextOptions<Hasmasan_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hasmasan_Andrei_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hasmasan_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hasmasan_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
