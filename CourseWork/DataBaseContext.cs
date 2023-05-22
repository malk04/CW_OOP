using CourseWork.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    /// <summary>
    /// Класс контекста базы данных
    /// </summary>
    internal class DataBaseContext: DbContext
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DataBaseContext()
        {
            // Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        /// <summary>
        /// Переопределение метода OnConfiguring
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(appDataPath, "CourseWork", "cw_oop.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        /// <summary>
        /// Таблица участников
        /// </summary>
        public DbSet<Participant> Participants { get; set; } = null!;

        /// <summary>
        /// Таблица стихотворений
        /// </summary>
        public DbSet<Poem> Poems { get; set; } = null!;

        /// <summary>
        /// Таблица конкурсов поэтов
        /// </summary>
        public DbSet<Competition> Competitions { get; set; } = null!;

    }
}
