using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Entities
{
    /// <summary>
    /// Класс конкурсанта
    /// </summary>
    internal class Participant
    {
        /// <summary>
        /// Id конкурсанта
        /// </summary>
        public int ParticipantId { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string SecondName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Стихотворения
        /// </summary>
        public ICollection<Poem> Poems { get; set; }

        /// <summary>
        /// Конкурсы
        /// </summary>
        public ICollection<Competition> Competitions { get; set; }

        /// <summary>
        /// Конструктор класса конкурсанта
        /// </summary>
        /// <param name="surname"> Фамилия </param>
        /// <param name="name"> Имя </param>
        /// <param name="secondName"> Отчество </param>
        /// <param name="dateOfBirth"> Дата рождения </param>
        public Participant(string surname, string name, string secondName, DateTime dateOfBirth)
        {
            Surname = surname;
            Name = name;
            SecondName = secondName;
            DateOfBirth = dateOfBirth;
            Poems = new List<Poem>();
            Competitions = new List<Competition>();
        }

        /// <summary>
        /// Добавление нового конкурсанта в базу данных
        /// </summary>
        internal void AddToDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Participants.Add(this);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Поиск конкурсанта по id в базе данных
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Participant FindById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Participants.First(p => p.ParticipantId == id);
            }
        }

        /// <summary>
        /// Удаление конкурсанта из базы данных
        /// </summary>
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
