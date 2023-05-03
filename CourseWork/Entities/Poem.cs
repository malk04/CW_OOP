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
    /// Класс стихотворения
    /// </summary>
    internal class Poem
    {
        /// <summary>
        /// Id стихотворения
        /// </summary>
        public int PoemId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        [Column(TypeName = "varchar(255)")]
        public string Theme { get; set; }

        /// <summary>
        /// Год написания
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        /// <summary>
        /// Текст стихотворения
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Id автора
        /// </summary>
        public int ParticipantId { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public Participant Participant { get; set; }

        /// <summary>
        /// Конструктор класса стихотворения
        /// </summary>
        /// <param name="name"> Название </param>
        /// <param name="theme"> Тема </param>
        /// <param name="year"> Год написания </param>
        /// <param name="text"> Текст стихотворения </param>
        /// <param name="participantId"> Id автора </param>
        public Poem(string name, string theme, DateTime year, string text, int participantId)
        {
            Name = name;
            Theme = theme;
            Year = year;
            Text = text;
            ParticipantId = participantId;
        }

        /// <summary>
        /// Добавление нового стихотворения в базу данных
        /// </summary>
        internal void AddToDataBase()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                db.Poems.Add(this);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Поиск стихотворения по id в базе данных
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Poem FindById(int id)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                return db.Poems.First(p => p.PoemId == id);
            }
        }

        /// <summary>
        /// Удаление стихотворения из базы данных
        /// </summary>
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
