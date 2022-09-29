using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Modules.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string? SubjectName { get; set; }
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public string? Description { get; set; }
        public List<StudentSubject>? StudentSubjects { get; set; }
    }
}
