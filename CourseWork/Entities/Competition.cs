using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Entities
{
    internal class Competition
    {
        public int CompetitionId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int  MinAge { get; set; }
        public ICollection<Participant>? Participants { get; set; }
        public int? WinnerId { get; set; }

        public Competition(string name, DateTime date, int minAge, int? winnerId)
        {
            Name = name;
            Date = date;
            MinAge = minAge;
            WinnerId = winnerId;
            Participants = new List<Participant>();
        }

        internal void AddToDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Competitions.Add(this);
                db.SaveChanges();
            }
        }

        internal static Competition? FindById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Competitions.Include(c => c.Participants).FirstOrDefault(c => c.CompetitionId == id);
            }
        }

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
