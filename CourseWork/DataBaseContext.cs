using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class DataBaseContext: DbContext
    {
        public DataBaseContext()
        {
            // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cw_oop.db");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Participant> Participants { get; set; } = null!;
        public DbSet<Poem> Poems { get; set; } = null!;
        public DbSet<Competition> Competitions { get; set; } = null!;

    }
}
