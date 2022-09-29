using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Modules.Entities
{
    public class College
    {
        public int Id { get; set; }
        public string? CollegeName { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
    }
}
