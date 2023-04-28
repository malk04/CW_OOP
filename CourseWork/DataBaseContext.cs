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
        /*public DataBaseContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost; port=3306; username=root; password=; database=cw_oop; charset=utf8");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Poem> Poems { get; set; }
        public DbSet<Competition> Competitions { get; set; }


/*
        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=cw_oop");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }*/
    }
}
