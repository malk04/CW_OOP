using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Entities
{
    /// <summary>
    /// Класс конкурса поэтов
    /// </summary>
    internal class Competition
    {
        /// <summary>
        /// Id конкурса
        /// </summary>
        public int CompetitionId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        /// <summary>
        /// Дата и время проведения
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Минимальный возраст участников
        /// </summary>
        public int  MinAge { get; set; }

        /// <summary>
        /// Участники конкурса
        /// </summary>
        public ICollection<Participant> Participants { get; set; }

        /// <summary>
        /// Id победителя
        /// </summary>
        public int? WinnerId { get; set; }

        /// <summary>
        /// Конструктор класса конкурса поэтов
        /// </summary>
        /// <param name="name"> Название </param>
        /// <param name="date"> Дата и время проведения </param>
        /// <param name="minAge"> Минимальный возраст участников </param>
        /// <param name="winnerId"> Id победителя </param>
        public Competition(string name, DateTime date, int minAge, int? winnerId)
        {
            Name = name;
            Date = date;
            MinAge = minAge;
            WinnerId = winnerId;
            Participants = new List<Participant>();
        }

        /// <summary>
        /// Добавление нового конкурса в базу данный
        /// </summary>
        internal void AddToDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Competitions.Add(this);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Поиск конкурса по id в базе данных
        /// </summary>
        /// <param name="id"> Id конкурса </param>
        /// <returns></returns>
        internal static Competition FindById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Competitions.Include(c => c.Participants).First(c => c.CompetitionId == id);
            }
        }

        /// <summary>
        /// Удаление конкурса из базы данных
        /// </summary>
        internal void DeleteFromDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Competitions.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
