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
        public DateTime Year { get; set; }
        public string Text { get; set; }
        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }
    }
}
