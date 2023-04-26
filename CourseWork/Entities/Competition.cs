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
    }
}
