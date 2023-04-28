using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Entities
{
    internal class Participant
    {
        public int ParticipantId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Surname { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string SecondName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Poem>? Poems { get; set; }
        public ICollection<Competition>? Competitions { get; set; }

        public Participant(string surname, string name, string secondName, DateTime dateOfBirth)
        {
            Surname = surname;
            Name = name;
            SecondName = secondName;
            DateOfBirth = dateOfBirth;
            Poems = new List<Poem>();
            Competitions = new List<Competition>();
        }

        internal void AddToDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Participants.Add(this);
                db.SaveChanges();
            }
        }

        internal static Participant? FindById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Participants.Find(id);
            }
        }

        internal void DeleteFromDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Participants.Remove(this);
                db.SaveChanges();
            }
        }
    }
}
