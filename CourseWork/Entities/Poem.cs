using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Entities
{
    internal class Poem
    {
        public int PoemId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Theme { get; set; }
        [Column(TypeName = "date")]
        public DateTime Year { get; set; }
        public string Text { get; set; }
        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }

        public Poem(string name, string theme, DateTime year, string text, int participantId)
        {
            Name = name;
            Theme = theme;
            Year = year;
            Text = text;
            ParticipantId = participantId;
        }

        internal void AddToDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Poems.Add(this);
                db.SaveChanges();
            }
        }

        internal static Poem FindById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Poems.First(p => p.PoemId == id);
            }
        }

        internal void DeleteFromDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Poems.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
