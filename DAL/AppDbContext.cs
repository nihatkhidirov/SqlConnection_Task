using Microsoft.EntityFrameworkCore;
using ORM_Migrations_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Migrations_Task.DAL
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-77U60MC\\SQLEXPRESS; Database=Academy;Trusted_Connection=True");

        }

    }
}
