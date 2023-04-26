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
    }
}
