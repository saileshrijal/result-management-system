using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Modules.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int CollegeId { get; set; }
        public College? College { get; set; }
        public int FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public List<StudentSubject>? StudentSubjects { get; set; }
    }
}
