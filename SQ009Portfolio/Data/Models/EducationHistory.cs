using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Models
{
    public class EducationHistory
    {
        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public string DegreeOptained { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
